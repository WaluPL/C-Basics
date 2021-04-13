using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp01Namespace
{
    class Tmp01
    {
        public void Print01()
        {
            Console.WriteLine("Method: Print01()");
        }
        public void Print02()
        {
            Console.WriteLine("Method: --------------->Print02()");
        }
        public static void Print03()
        {
            Console.WriteLine("Static Method: Print01()");
        }
        public static void Print04()
        {
            Console.WriteLine("Static Method ------------> Print01()");
        }
        public delegate int OneInt(int x);
        public static int DubI(int x) { return x * 2; }
        public static int IncI(int x) { return x + 1; }
        public static int DecI(int x) { return x - 1; }
        public static OneInt DubInt= new OneInt(DubI);
        public static OneInt IncInt= new OneInt(IncI);
        public static OneInt DecInt= new OneInt(DecI);
        public static int ChangeInt(OneInt MyC, int x) { return MyC(x); } 

    }
}
