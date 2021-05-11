using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyAnamespace;
using MyBnamespace;
namespace C09
{
    class Application
    {
        public void Run()
        {
            Main01();
            MyUtility.Pause("Do wakacji jescze troche \n");
        }
        private void Main00()
        {
            myA mA;
            mA= new myA(3, 4);
            Console.WriteLine("mA: ({0})", mA.MyString());
            Console.WriteLine("mA x0: ({0})", mA.X0);
            Console.WriteLine("mA x1: ({0})", mA.X1);
        }
        private void Main01()
        {
            myB mB;
            mB = new myB(3, 4);
            Console.WriteLine("mB: ({0})", mB.MyString());
            Console.WriteLine("mB x4: ({0})", mB.X4);
            Console.WriteLine("mB x3: ({0})", mB.X3);
            Console.WriteLine("mB x2: ({0})", mB.X2);
            Console.WriteLine("mB x1: ({0})", mB.X1);
            Console.WriteLine("mB x0: ({0})", mB.X0);
        }
    }
}




