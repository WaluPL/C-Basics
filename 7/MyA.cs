using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnamespace
{
    class MyA
    {
        private int x2;
        private int x1;
        private int x0;
        private int cRc;
        public MyA(int x2, int x1, int x0) //konstruktor klasy MyA
        {
            this.x2 = x2; // reference to class object where we are
            this.x1 = x1;
            this.x0 = x0;
            SetCrc();
        }
        public MyA Copy() { return new MyA(X2, x1, x0); }
        public override string ToString()
        {
            return "(" + X2 + "," + X1 + "," + X0 + ") -->" + CRC;
        }
        public void Print()
        {
            Console.WriteLine("({0},{1},{2})", x2, x1, x0);
        }
        public void PrintAll()
        {
            Console.WriteLine("({0},{1},{2})----->{3}", x2, x1, x0, cRc);
        }
        public int X2 //accessors getter and setter for x2
        {
            get { return x2; }
            set { x2 = value;
                SetCrc();
            } //set value and reload function
        }
        public int X1 //accessors getter and setter for x1
        {
            get { return x1; }
            set { x1 = value;
                SetCrc();
            } //set value and reload function
        }
        public int X0 //accessors getter and setter
        {
            get { return x0; }
            set {  x0 = value;
                SetCrc();
            } //set value and reload function
        }
        public int CRC //accessors getter and setter
        {
            get { return cRc; }

        }
        private int CrC()
        {
            return  4 * (x2 % 2) +
                    2 * (x1 % 2) +
                    1 * (x0 % 2);
        }
        private void SetCrc()
        {
            cRc = CrC();
        }
    }
}
