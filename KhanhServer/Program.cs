using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace KhanhServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 2000);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket client;
            byte[] dataReceice = new byte[1024];
            byte[] datasend = new byte[1024];
            server.Bind(ipep);
            Console.WriteLine("Waitting ....");
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        client = server.Accept();
                        Console.WriteLine("Accept connect with {0}", client.RemoteEndPoint.ToString());
                        for(int i= 49; i > 0; --i)
                        {
                            datasend = Encoding.ASCII.GetBytes(i.ToString());
                            client.Send(datasend, datasend.Length, SocketFlags.None);
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                        }
                        
                        

                        //Thread receive = new Thread(()=>
                        //{
                        //    while (true)
                        //    {
                        //        int rec = client.Receive(dataReceice);
                        //        for(int i =50; i > 0; --i)
                        //        {

                        //        }
                        //        str = Encoding.ASCII.GetString(dataReceice, 0, rec);
                        //        Console.WriteLine("{0}", str);
                        //    }
                        //});
                        //receive.IsBackground = true;
                        //receive.Start();
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine("exception {0}", e.Message);
                    ipep = new IPEndPoint(IPAddress.Any, 2000);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();

        }
    }
}
