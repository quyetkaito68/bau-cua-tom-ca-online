using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace BauCua
{
    [Serializable]
    class TienCuoc
    {
        public TienCuoc(int huou, int bau, int ga, int tom, int cua, int ca)
        {
            
            this.huou = huou;
            this.bau = bau;
            this.ga = ga;
            this.tom = tom;
            this.cua = cua;
            this.ca = ca;
        }

        
        public int huou { get; set; }
        public int bau { get; set; }
        public int ga { get; set; }
        public int tom { get; set; }
        public int cua { get; set; }
        public int ca { get; set; }

        public byte[] toByteArray()
        {
            List<byte> listByte = new List<byte>();

            listByte.AddRange(BitConverter.GetBytes(huou));
            listByte.AddRange(BitConverter.GetBytes(bau));
            listByte.AddRange(BitConverter.GetBytes(ga));
            listByte.AddRange(BitConverter.GetBytes(tom));
            listByte.AddRange(BitConverter.GetBytes(cua));
            listByte.AddRange(BitConverter.GetBytes(ca));

            return listByte.ToArray();
        }

        public TienCuoc(byte[] data)
        {
            this.huou = BitConverter.ToInt32(data,0);
            this.bau = BitConverter.ToInt32(data, 4);
            this.ga = BitConverter.ToInt32(data, 8);
            this.tom = BitConverter.ToInt32(data, 12);
            this.cua = BitConverter.ToInt32(data, 16);
            this.ca = BitConverter.ToInt32(data, 20);


        }
    }
}
