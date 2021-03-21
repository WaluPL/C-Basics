using System;
using System.Collections.Generic;
using System.Text;

namespace C01_ID04P04_01_Console
{
    class Application
    {
        public void Run()
        {
            Main07();
        }
        private void Main01()
        {
            Console.WriteLine("Konstantynopolitańczykowianeczka");
        }
        private void Main02()
        {
            Console.Write("A q q ");
            Console.WriteLine();
        }
        private void Main03()
        {
            int x;
            int y = 8;

            x = y;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString());
            Console.WriteLine("x = " + x);
            Console.WriteLine("x = {0}", x);
            Console.WriteLine($"x = {x}");
        }
        private void Main04()
        {
            int x = 6;
            int y = 12;
            Console.WriteLine("x = "+x+", y = "+ y);
            Console.WriteLine();
            Console.WriteLine($"x = {x,2}, y = {y,2}");
            Console.WriteLine($"y = {y,2}, x = {x,2}");

            Console.WriteLine("x = {0,2}, y = {1,2}", x, y);
            Console.WriteLine("y = {1,2}, x = {0,2}", x, y);

            //Console.WriteLine("y = {1,2}, x = {2,2}", x, y);
        }
        private void Main05()
        {
            string czytaj;
            Console.Write("x? = ");
            czytaj = Console.ReadLine();
            Console.WriteLine(czytaj);

            int x;
            try
            {
                x = Convert.ToInt32(czytaj);
            }
            catch
            {
                Console.WriteLine("To nie jest liczba");
                return;
            }
            ++x;
            Console.WriteLine("x = {0}",x);
        }
        private void Main06()
        {
            int x;
            Console.Write("x? = ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x = {0}",x);
        }
        private void Main07()
        {
            int x;
            Console.Write("x? = ");
            if(int.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("x? = {0}",x);
        }
    }
}
