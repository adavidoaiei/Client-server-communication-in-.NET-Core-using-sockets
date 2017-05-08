using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server
    {
        private static TcpListener listener { get; set; }
        private static bool accept { get; set; } = false;
        public static object TcpHelper { get; private set; }

        public static void StartServer(int port)
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(address, port);

            listener.Start();
            accept = true;

            Console.WriteLine($"Server started. Listening to TCP clients at 127.0.0.1:{port}");
        }

        public static void Main(string[] args)
        {
            // Start the server  
            StartServer(5678);
            Console.ReadKey();
        }
    }
}