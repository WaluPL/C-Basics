using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;


namespace C02_ID04P04_01_Console
{
    class Application
    {
        public void Run()
        {
            Main07();
            MyUtility.Pause("Horrible dreams ...\n");
        }
        private void Main01()
        {
            Console.WriteLine("No good deed will go unpunished ...");
            Console.ReadKey();
        }
        private void Main02()
        {
            MyUtilityNamespace.MyUtility.Pause("Good night and good dreams ...\n");
        }
        private void Main03()
        {
            MyUtility.Pause("Horrible dreams ...\n");
        }
        private void Main04()
        {
            int x = MyUtility.Read();
            Console.WriteLine("x = {0}",x);
        }
        private void Main05()
        {
            int x0, x1, x2, x3, x4, x5, x6, x7;
            x0 = MyUtility.Read("x0? = ");
            x1 = MyUtility.Read("x1? = ");
            x2 = MyUtility.Read("x2? = ");
            x3 = MyUtility.Read("x3? = ");
            x4 = MyUtility.Read("x4? = ");
            x5 = MyUtility.Read("x5? = ");
            x6 = MyUtility.Read("x6? = ");
            x7 = MyUtility.Read("x7? = ");

            Console.WriteLine("Max({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8} ",
                    x0, x1, x2, x3, x4, x5, x6, x7,
                    MyUtility.Max(x0, x1, x2, x3, x4, x5, x6, x7));
        }
        private void Main06()
        {
            int x = MyUtility.Read();
            int y = MyUtility.Read("y? = ");

            Console.WriteLine("x = {0}, y = {1}", x, y);
            MyUtility.Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }

        private void Main07()
        {
            int x, y;

            MyUtility.Read(out x, "x? = ", out y, "y? = " );
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}
//3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2