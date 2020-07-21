using System;

namespace SocketAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Socket服务端启动，端口号:30011");
            SocketServer server = new SocketServer();
            server.StartListen();

            Console.ReadLine();
        }
    }
}
