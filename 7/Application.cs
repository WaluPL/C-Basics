using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyAnamespace;

namespace C07
{
    class Application
    {

        public void Run()
        {
            Main01();
            MyUtility.Pause("Per aspera ad asperorum ... \n");
        }
        private void Main00()
        {
            MyA myA;
            myA = new MyA(1, 2, 3); //utworzenie obiektu
            myA.Print();
            myA.PrintAll();
            Console.WriteLine("myA.x2 = {0}", myA.X2); //using getter
            myA.X2 = 1;
            myA.X1 = 2;
            myA.X0 = 3;
            myA.PrintAll();
        }
        
        private void Main01()
        {
            MyA myA0 = new MyA(MyUtility.Read("x2 ?="), MyUtility.Read("x1 ?="), MyUtility.Read("x0 ?="));
            Console.WriteLine("myA0 : {0})", myA0.ToString());
             MyA myA1;
             myA1 = myA0.Copy(); //Copy object
             myA1.X2 = MyUtility.Read("x2 ?=");
             Console.WriteLine("myA0 : {0})", myA0);
             Console.WriteLine("myA1 : {0})", myA1);
        }
    }
}



