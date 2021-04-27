using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
namespace MyAnamespace
{
    class myA
    {
        public int x2;
        public int x1;
        public int x0;
        public int cRc;

        public myA(int x2=0, int x1=0, int x0=0)
        {
            this.x2 = x2;
            this.x1 = x1;
            this.x0 = x0;
        }
        public myA Copy() { return new myA(this); }

        public myA(myA mya01)
        {
            this.x2 = mya01.x2;
            this.x1 = mya01.x1;
            this.x0 = mya01.x0;
        }
        public override string ToString()
        {
            return "(" + x2 + "," +x1 + "," +x0 + ") -->" + CRC;
        }
        private int Crc()
        {
            return 4 * (x2 % 2) +
                    2 * (x1 % 2) +
                    1 * (x0 % 2);
        }
        public void PrintAll()
        {
            Console.WriteLine("({0},{1},{2})----->{3}", x2, x1, x0, cRc);
        }
        private void SetCrc()
        {
            cRc = Crc();
        }
        public int CRC //accessors
        {
            
            get { SetCrc();  return cRc; }

        }
    }
}
