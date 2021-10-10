using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BauCuaServer
{
    public partial class MayChu : Form
    {
        private IPEndPoint ipep;
        private Socket client;
        private Socket server;
        private byte[] dataReceice = new byte[1024];
        private byte[] dataSend = new byte[1024];
        Random r = new Random();
        private List<Socket> listClient;

        public MayChu()
        {
            InitializeComponent();
            connect();
        }
        public void autoTime()
        {
            
            Thread time = new Thread(()=> {
                for (int i = 1; i >= 0; --i)
                {
                    dataSend = Encoding.ASCII.GetBytes(i.ToString());
                    int j = 1;
                    foreach(Socket item in listClient)
                    {
                        
                        item.Send(dataSend, dataSend.Length, SocketFlags.None);
                        j++;
                    }
                    Thread.Sleep(1000);
                }
            });
            time.Name = "Get Time";
            time.IsBackground = true;
            time.Start();
        }

       
        private void connect()
        {
            ipep = new IPEndPoint(IPAddress.Any, 2000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listClient = new List<Socket>();
            try
            {
                server.Bind(ipep);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread listen = new Thread(receipt);
            listen.Name = "Nghe client";
            listen.IsBackground = true;
            listen.Start();
        }
        private void receipt()
        {
            try
            {
                while (true)
                {
                    server.Listen(10);
                    client = server.Accept();
                    listClient.Add(client);
                    Invoke(new Action(() =>
                    {
                        TimeLabel.Text = client.RemoteEndPoint.ToString();
                    }));
                    Thread receive = new Thread(() =>
                    {
                        try
                        {
                            while (true)
                            {
                                client.Receive(dataReceice);
                                TienCuoc tienCuoc = new TienCuoc(dataReceice);
                                TienCuoc tienCuocResult = calMoney(tienCuoc);
                                dataSend = tienCuocResult.toByteArray();
                                client.Send(dataSend, dataSend.Length, SocketFlags.None);
                            }
                        }
                        catch(Exception e)
                        {
                            client.Close();
                        }
                        
                    });
                    receive.Name = "Nhận client";
                    receive.IsBackground = true;
                    receive.Start();
                }

            }
            catch (Exception e)
            {
                ipep = new IPEndPoint(IPAddress.Any, 2000);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
        }
        private TienCuoc calMoney(TienCuoc tienCuoc)
        {
            int huou = 0;
            int bau = 0;
            int ga = 0;
            int tom = 0;
            int cua = 0;
            int ca = 0;
            TienCuoc tienCuocResult = new TienCuoc(0,0,0,0,0,0);
            for (int i = 0; i < 3; ++i)
            {
                int random = r.Next(1, 6);
                if(i == 0)
                {
                    Invoke(new Action(() => {
                        result1.Text = random.ToString();
                    }));
                    
                }
                else if(i == 1)
                {
                    Invoke(new Action(() => {
                        result2.Text = random.ToString();
                    }));
                }
                else
                {
                    Invoke(new Action(() => {
                        result3.Text = random.ToString();
                    }));
                }
                switch (random)
                {
                    case 1:
                        huou++;
                        break;
                    case 2:
                        bau++;
                        break;
                    case 3:
                        ga++;
                        break;
                    case 4:
                        tom++;
                        break;
                    case 5:
                        cua++;
                        break;
                    case 6:
                        ca++;
                        break;
                }
            }
            if(huou > 0)
            {
                tienCuocResult.huou = tienCuoc.huou *(huou + 1);
            }
            if (bau > 0)
            {
                tienCuocResult.bau = tienCuoc.bau * (bau + 1);
            }
            if (ga > 0)
            {
                tienCuocResult.ga = tienCuoc.ga * (ga + 1);
            }
            if (tom > 0)
            {
                tienCuocResult.tom = tienCuoc.tom * (tom + 1);
            }
            if (ca > 0)
            {
                tienCuocResult.ca = tienCuoc.ca * (ca + 1);
            }
            if (cua > 0)
            {
                tienCuocResult.cua = tienCuoc.cua * (cua + 1);
            }
            return tienCuocResult;

        }
        private TienCuoc getTienCuocdefault(TienCuoc t)
        {
            int huou = t.huou * (-1);
            int bau = t.bau * (-1);
            int ga = t.ga * (-1);
            int ca = t.ca * (-1);
            int cua = t.cua * (-1);
            int tom = t.tom * (-1);

            return new TienCuoc(huou, bau, ga, tom, cua, ca);
        }
        private byte[] serialize(object t)
        {
            MemoryStream stream = new MemoryStream();

            BinaryFormatter b = new BinaryFormatter();

            b.Serialize(stream, t);
            return stream.ToArray();
        }
        private object deliziable(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);

            BinaryFormatter b = new BinaryFormatter();

            return b.Deserialize(stream);
        }
        private void close()
        {
            client.Close();
        }

        private void TimeBtn_Click(object sender, EventArgs e)
        {
            autoTime();
        }
    }
}
