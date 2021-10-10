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

namespace BauCua
{
    public partial class BauCuaGame : Form
    {
        private IPEndPoint ipep; 
        private Socket client;
        private byte[] dataReceice = new byte[1024*5000];
        private byte[] dataSend = new byte[1024*1000];
        public BauCuaGame()
        {
            InitializeComponent();
            Money.Text = "50000";
            setDefault();
            connect();
        }
        private void setDefault()
        {
            HuouMoney.Text = BauMoney.Text = GaMoney.Text = TomMoney.Text = CuaMoney.Text = CaMoney.Text = "0";
            
        }
        private void connect()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(ipep);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread listen = new Thread(receipt);
            listen.IsBackground = true;
            listen.Start();
        }
        private void receipt()
        {
            try
            {
               
                int rec;
                string str = "";
                while (true)
                {
                    rec = client.Receive(dataReceice);
                    
                    str = Encoding.ASCII.GetString(dataReceice, 0, rec);
                    if(str != "0")
                    {
                        Invoke(new Action(() => {
                            Timelabel.Text = str;
                        }));
                    }
                    else
                    {
                        TienCuoc tienCuoc = getTienCuoc();
                        dataSend = tienCuoc.toByteArray();
                        client.Send(dataSend, dataSend.Length, SocketFlags.None);
                        
                        client.Receive(dataReceice);
                        TienCuoc t = new TienCuoc(dataReceice);
                        show(t);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private TienCuoc getTienCuoc()
        {
            int huou = Int32.Parse(HuouMoney.Text);
            int bau = Int32.Parse(BauMoney.Text);
            int ga = Int32.Parse(GaMoney.Text);
            int ca = Int32.Parse(CaMoney.Text);
            int cua = Int32.Parse(CuaMoney.Text);
            int tom = Int32.Parse(TomMoney.Text);

            return new TienCuoc(huou, bau, ga, tom, cua, ca);
        }
        private void show(TienCuoc t)
        {
            int money = Int32.Parse(Money.Text);
            money += t.huou;
            money += t.bau;
            money += t.ga;
            money += t.tom;
            money += t.cua;
            money += t.ca;
            Invoke(new Action(() => {
                Money.Text = money.ToString();
                setDefault();
            }));
            
        }
        private byte[] serialize(TienCuoc t)
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

        private void HuouBtn_Click(object sender, EventArgs e)
        {
            int money = Int32.Parse(Money.Text);
            if(money > 10000)
            {
                int bets = Int32.Parse(HuouMoney.Text);
                HuouMoney.Text = (bets + 10000).ToString();
                money -= 10000;
                Money.Text = money.ToString();
            }
        }

        private void BauBtn_Click(object sender, EventArgs e)
        {
            int money = Int32.Parse(Money.Text);
            if (money > 10000)
            {
                int bets = Int32.Parse(BauMoney.Text);
                BauMoney.Text = (bets + 10000).ToString();
                money -= 10000;
                Money.Text = money.ToString();
            }
        }

        private void GaBtn_Click(object sender, EventArgs e)
        {
            int money = Int32.Parse(Money.Text);
            if (money > 10000)
            {
                int bets = Int32.Parse(GaMoney.Text);
                GaMoney.Text = (bets + 10000).ToString();
                money -= 10000;
                Money.Text = money.ToString();
            }
        }

        private void Tombtn_Click(object sender, EventArgs e)
        {
            int money = Int32.Parse(Money.Text);
            if (money > 10000)
            {
                int bets = Int32.Parse(TomMoney.Text);
                TomMoney.Text = (bets + 10000).ToString();
                money -= 10000;
                Money.Text = money.ToString();
            }
        }

        private void CuaBtn_Click(object sender, EventArgs e)
        {
            int money = Int32.Parse(Money.Text);
            if (money > 10000)
            {
                int bets = Int32.Parse(CuaMoney.Text);
                CuaMoney.Text = (bets + 10000).ToString();
                money -= 10000;
                Money.Text = money.ToString();
            }
        }

        private void CaBtn_Click(object sender, EventArgs e)
        {
            int money = Int32.Parse(Money.Text);
            if (money > 10000)
            {
                int bets = Int32.Parse(CaMoney.Text);
                CaMoney.Text = (bets + 10000).ToString();
                money -= 10000;
                Money.Text = money.ToString();
            }
        }
    }
}
