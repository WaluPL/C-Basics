using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyAnamespace;
using MyBnamespace;
namespace C08
{
    class Application
    {
        public void Run()
        {
            Main03();
            MyUtility.Pause("Per aspera ad asperorum ... \n");
        }
        private void Main00()
        {
            myA newobj = new myA(4,5,6);
            Console.WriteLine("My Crc is = {0}", newobj.CRC);
        }
        private void Main01()
        {
            myA myA01 = new myA(1, 2, 3);
            myA myA02, myA03;
            myA02 = myA01.Copy();
            myA03 = new myA(myA01);
            Console.WriteLine("myA01 is= {0}", myA01);
            Console.WriteLine("myA02 is = {0}", myA02);
            Console.WriteLine("myA03 is = {0}", myA03);
            myA02.x2 = 4;
            Console.WriteLine();
            Console.WriteLine("myA01 is= {0}", myA01);
            Console.WriteLine("myA02 is = {0}", myA02);
            Console.WriteLine("myA03 is = {0}", myA03);
        }
        private void Main02()
        {
            myB myB01 = new myB(new myA(1, 2, 3), new myA(4, 5, 6));
            Console.WriteLine("MB01: {0}", myB01);
        }
        private void Main03()
        {
            myA x1 = new myA(1, 2, 3);
            myA x0 = new myA(4, 5, 6);
            myB myB01 = new myB(x1, x0);
            myB myB02 = new myB(x1, x0);
            Console.WriteLine("MB01: {0}", myB01);
            Console.WriteLine("MB01: {0}", myB02);
            myB02.x1.x2 = 4;
            Console.WriteLine();
            Console.WriteLine("MB01: {0}", myB01);
            Console.WriteLine("MB01: {0}", myB02);
        }
    }
}




