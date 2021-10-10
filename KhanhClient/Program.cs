using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace KhanhClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BauCua());

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2000);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(ipep);
            try
            {
                while (true)
                {


                    byte[] dataReceice = new byte[1024];
                    byte[] dataSend = new byte[1024];
                    int rec;
                    string str = "";
                    Thread receive = new Thread(() =>
                    {

                        rec = client.Receive(dataReceice);
                        str = Encoding.ASCII.GetString(dataReceice, 0, rec);
                        Console.WriteLine("{0}", str);

                        str = Console.ReadLine();
                        dataSend = Encoding.ASCII.GetBytes(str);
                        client.Send(dataSend, dataSend.Length, SocketFlags.None);

                    });
                    receive.IsBackground = true;
                    receive.Start();

                }
                client.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi {0}", e.Message);
            }

            client.Close();


        }
    }
}
