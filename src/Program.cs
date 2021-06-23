using BigTony.Examples;
using BigTony.Utility;
using BigTony.Core;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

namespace BigTony.Core
{
    class Program
    {

        // Maybe this will trigger Doxygen?

        public class Client
        {

            public Client(IPEndPoint _connection, string _username)
            {

                IP = _connection.Address.ToString();
                port = _connection.Port;
                username = _username;

            }

            public string IP;
            public int port;
            public string username;

        }

        static void Main(string[] args)
        {

            List<Client> clients = new List<Client>();
            bool serverRunning = true;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            UdpClient newsock = new UdpClient(ipep);

            Console.Log("Waiting for a client...");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            while (serverRunning)
            {

                byte[] req = newsock.Receive(ref sender);

                switch (req[0])
                {

                    // Close the Server
                    case 0x00:
                        serverRunning = false;
                        break;

                    // Register New Player
                    case 0x01:

                        // Convert the Input Bytes into String 
                        char[] charsAsAscii = new char[req.Length - 1];
                        Encoding.ASCII.GetChars(req, 1, req.Length - 1, charsAsAscii, 0);

                        // Register the Client to the Database 
                        clients.Add(new Client(sender, new string(charsAsAscii)));
                        break;

                    case 0x02:

                        List<byte> res = new List<byte>();

                        foreach (Client client in clients)
                        {


                            res.AddRange(Encoding.ASCII.GetBytes(client.IP));
                            res.Add(0x0A);
                            res.AddRange(Encoding.ASCII.GetBytes(client.port.ToString()));
                            res.Add(0x0A);
                            res.AddRange(Encoding.ASCII.GetBytes(client.username));
                            res.Add(0x0C);

                        }

                        newsock.Send(res.ToArray(), res.Count, sender);
                        break;

                }

                // Console.Log(Encoding.ASCII.GetString(data, 0, data.Length));
                // newsock.Send(data, data.Length, sender);
            }

            Console.Log("Closing Server...");

        }
    }
}
