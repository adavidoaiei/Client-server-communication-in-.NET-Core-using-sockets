﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client
    {

        private static System.Net.Sockets.TcpListener listener { get; set; }
        private static bool accept { get; set; } = false;
        public static void Listen()
        {
            int port = 1400;
            IPAddress address = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(address, port);

            if (listener != null && accept)
            {

                // Continue listening.  
                while (true)
                {
                    Console.WriteLine("Waiting for client...");
                    var clientTask = listener.AcceptTcpClientAsync(); // Get the client  

                    if (clientTask.Result != null)
                    {
                        Console.WriteLine("Client connected. Waiting for data.");
                        var client = clientTask.Result;
                        string message = "";

                        while (message != null && !message.StartsWith("quit"))
                        {
                            byte[] data = Encoding.ASCII.GetBytes("Send next data: [enter 'quit' to terminate] ");
                            client.GetStream().Write(data, 0, data.Length);

                            byte[] buffer = new byte[1024];
                            client.GetStream().Read(buffer, 0, buffer.Length);

                            message = Encoding.ASCII.GetString(buffer);
                            Console.WriteLine(message);
                        }
                        Console.WriteLine("Closing connection.");
                        client.GetStream().Dispose();
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Listen();
            Console.ReadKey();
        }
    }
}