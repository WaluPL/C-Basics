using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using Tmp01Namespace;

namespace C05
{
    class Application
    {
        
        public void Run()
        {
            Main05();
            MyUtility.Pause("Per aspera ad asperorum ... \n");
        }
        private void Main00()
        {
            Tmp01 tM = new Tmp01();
            tM.Print01(); //wywołanie metody nie statycznej wywołane na obiekcie
            tM.Print02(); 
            new Tmp01().Print01(); //w locie
            new Tmp01().Print02();

            Tmp01.Print03(); // na klasie bo statyczne
            Tmp01.Print04();
        }
        delegate void TestDel01(); //funkcja do wywoływania innych funkcji
        private void Main02()
        {
            Tmp01 tM = new Tmp01();
            TestDel01 myDel = new TestDel01(tM.Print01);// bez nawiasow
            myDel();
            Console.WriteLine("-----------------------------");
            myDel += Tmp01.Print03;
            myDel += tM.Print01;
            myDel += tM.Print02;
            Console.WriteLine("-----------------------------");
            myDel += tM.Print01;
            myDel();
        }
        private void Main03()
        {
            int x = MyUtility.Read();
            Console.WriteLine("{0} * 2  = {1}", x, Tmp01.ChangeInt(Tmp01.DubInt, x));
            Console.WriteLine("{0} + 1  = {1}", x, Tmp01.ChangeInt(Tmp01.IncInt, x));
            Console.WriteLine("{0} - 1  = {1}", x, Tmp01.ChangeInt(Tmp01.DecInt, x));
        }
        private void Main04()
        {
            int x = MyUtility.Read("x? = ");
            int y = MyUtility.Read("y? = ");
            Console.WriteLine("Max({0}, {1}) = {2}", x, y, MyUtility.Extremum(new MyUtility.Question(MyUtility.Max), x, y));
            Console.WriteLine("Min({0}, {1}) = {2}", x, y, MyUtility.Extremum(new MyUtility.Question(MyUtility.Min), x, y));
        }
        private void Main05()
        {
            int x = MyUtility.Read("x? = ");
            int y = MyUtility.Read("y? = ");
            Console.WriteLine("Max({0}, {1}) = {2}", x, y, MyUtility.Extremum(MyUtility.Max, x, y));
            Console.WriteLine("Min({0}, {1}) = {2}", x, y, MyUtility.Extremum(MyUtility.Min, x, y));
        }

    }
}




