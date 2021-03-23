using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;

namespace C04_Main
{
    class Application
    {
        public void Run()
        {
       
            Main04();
           // MyUtility.Pause("Od jutra zabieram się do pracy ... \n");
        }
        private void Main01()
        {
            int[] myT = new int[MyUtility.myFate.Next(10, 21)];
            for(int i=0; i < myT.Length; ++i)
            {
                myT[i] = MyUtility.myFate.Next(0, 101);
            }
            for(int i=0; i< myT.Length; ++i)
            {
                Console.Write("T[{0}] = {1}", i, myT[i]);
            }
       
        }
        private void Main02()
        {
            //tablica dwuwymiarowa 1 wymiar 4 kolumny i 8 wierszów czyli rozmair 4*8
            int[,] myT = new int[4, 8];
            Console.WriteLine("Length = {0}", myT.Length);
            Console.WriteLine("Length = {0}", myT.GetLength(0));
            Console.WriteLine("Length = {0}", myT.GetLength(1));
            int[,] myT1 = new int[MyUtility.myFate.Next(5, 21), MyUtility.myFate.Next(5, 21)];
            for (int i = 0; i < myT.GetLength(0); ++i)
            {
                for (int j = 0; j < myT.GetLength(1); ++j)
                {
                    myT[i, j] = MyUtility.myFate.Next(0, 100);
                }
            }
            for (int i = 0; i < myT.GetLength(0); ++i)
            {
                for (int j = 0; j < myT.GetLength(1); ++j)
                {
                    Console.Write("[{0, 2}]", myT[i, j]);
                }
                Console.WriteLine();
            }
        }
        private void Main03()
        {
            int[,] myT1 = new int[MyUtility.myFate.Next(5, 21), MyUtility.myFate.Next(5, 21)];
            for (int i = 0; i < myT1.GetLength(0); ++i)
            {
                for (int j = 0; j < myT1.GetLength(1); ++j)
                {
                    myT1[i, j] = MyUtility.myFate.Next(0, 100);
                }
            }
            MyUtility.Print(MyUtility.Transpose(myT1));
      
        }
        private void Main04()
        {
            int[,] myT = MyUtility.RandomTab(5, 20, 0, 99);
            int[,] myTS = MyUtility.Transpose(myT);
            MyUtility.Print(myT);
            Console.WriteLine("\n");
            MyUtility.Print(myTS);

        }

    }
}
