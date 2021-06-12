using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BigTony
{
    class Program
    {
        // static void Main(string[] args)
        // {

        //     bool serverRunning = true;

        //     IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
        //     UdpClient newsock = new UdpClient(ipep);

        //     Console.WriteLine("Waiting for a client...");

        //     IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

        //     while (serverRunning)
        //     {

        //         byte[] data = newsock.Receive(ref sender);
        //         String stringData = Encoding.ASCII.GetString(data, 0, data.Length);

        //         if (stringData == "END") serverRunning = false;

        //         Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
        //         newsock.Send(data, data.Length, sender);
        //     }

        //     Console.WriteLine("Closing Server...");

        // }
    }
}
