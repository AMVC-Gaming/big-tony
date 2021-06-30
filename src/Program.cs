using BigTony.Examples;
using BigTony.Utility;
using BigTony.Core;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

namespace BigTony.Core
{
    class Program
    {

        private static bool serverRunning = true;

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

        /// <summary>
        /// A function to close the server.
        /// </summary>
        public static void Close()
        {

            serverRunning = false;

        }

        static void Main(string[] args)
        {

            // Server Setup
            CommandParser.FindCommands();
            SettingsParser.SetParams(args);

            // Check if the Developer Wants a UDP Server
            if (!SettingsParser.GetBoolParam("UDP_SERVER")) return;

            List<Client> clients = new List<Client>();

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

                        StringBuilder res = new StringBuilder();

                        foreach (Client client in clients)
                        {

                            res.Append(client.IP);
                            res.Append("\u000A");
                            res.Append(client.port.ToString());
                            res.Append("\u000A");
                            res.Append(client.username);
                            res.Append("\u000C");

                        }

                        newsock.Send(Encoding.ASCII.GetBytes(res.ToString()), res.Length, sender);
                        break;

                    case 0x03:

                        // Get Console Command and Parse It
                        char[] charInputCommand = new char[req.Length - 1];
                        Encoding.ASCII.GetChars(req, 1, req.Length - 1, charInputCommand, 0);

                        string inputCommand = new string(charInputCommand);
                        string[] inputCommandSegments = inputCommand.Split("\n");

                        // If the Command is Null, Return Nothing
                        if (inputCommandSegments[0].Length == 0) break;

                        // Send back command output
                        byte[] commandOutput = CommandParser.RunCommand(inputCommandSegments[0], inputCommandSegments.AsSpan().Slice(1));
                        newsock.Send(commandOutput, commandOutput.Length, sender);

                        break;

                }

                // Console.Log(Encoding.ASCII.GetString(data, 0, data.Length));
                // newsock.Send(data, data.Length, sender);
            }

            Console.Log("Closing Server...");

        }
    }
}
