using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;

namespace C03_ID04P04_01_Console
{
    class Application
    {
        public void Run()
        {
            Main05();
            MyUtility.Pause("Życie jest ciężkie, a potem się umiera ...");
        }
        private void Main01()
        {
            for (int i = 0; i < 20; ++i)
            {
                Console.WriteLine("{0,2}", MyUtility.myFate.Next(0, 100));
                //zakres [0, 100)
            }
        }
        private void Main02()
        {
            int[] myT;
            myT = new int[20];
            for (int i = 0; i < myT.Length; ++i)
            {
                myT[i] = i * 3;
            }
            for (int i = 0; i < myT.Length; ++i)
            {
                Console.WriteLine("{0,2}", myT[i]);
            }
        }
        private void Main03()
        {
            int[] myT1 = new int[MyUtility.myFate.Next(10, 21)];
            for (int i = 0; i < myT1.Length; ++i) myT1[i] = MyUtility.myFate.Next(0, 101);
            Console.Write("myT1:\t");
            for (int i = 0; i < myT1.Length; ++i) Console.Write("[{0,3}]", myT1[i]);
            Console.WriteLine();
        }
        private void Main04()
        {
            int[] myT1 = new int[MyUtility.myFate.Next(4, 9)];
            int[] myT2 = new int[myT1.Length*2];
            for (int i = 0, j = myT1.Length; i < myT1.Length; ++i, ++j)
            {
                myT1[i] = myT2[i] = MyUtility.myFate.Next(0, 101);
                myT2[j] = 2 * myT2[i];
            }

            Console.Write("myT1:\t");
            for (int i = 0; i < myT1.Length; ++i) Console.Write("[{0,3}]", myT1[i]);
            Console.WriteLine();
            Console.Write("myT2:\t");
            for (int i = 0; i < myT2.Length; ++i) Console.Write("[{0,3}]", myT2[i]);
            Console.WriteLine();
        }
        private void Main05()
        {
            int[] myT1 = new int[MyUtility.myFate.Next(4, 9)];
            int[] myT2 = new int[MyUtility.myFate.Next(4, 9)];
            int[] myT3 = new int[MyUtility.Max(myT1.Length, myT2.Length)];

            for (int i = 0; i < myT1.Length; ++i) myT1[i] = MyUtility.myFate.Next(0, 101);
            for (int i = 0; i < myT2.Length; ++i) myT2[i] = MyUtility.myFate.Next(0, 101);
            for (int i = 0; i < myT1.Length; ++i) myT3[i] += myT1[i];
            for (int i = 0; i < myT2.Length; ++i) myT3[i] += myT2[i];

            Console.Write("myT1:\t");
            for (int i = 0; i < myT1.Length; ++i) Console.Write("[{0,3}]", myT1[i]);
            Console.WriteLine();
            Console.Write("myT2:\t");
            for (int i = 0; i < myT2.Length; ++i) Console.Write("[{0,3}]", myT2[i]);
            Console.WriteLine();
            Console.Write("myT3:\t");
            for (int i = 0; i < myT3.Length; ++i) Console.Write("[{0,3}]", myT3[i]);
            Console.WriteLine();

        }
    }
}
/*
 Tworzymy tablice myT1 i myT2 o losowych rozmiarach z zakresu [4, 8]
 wypełnione danymi losowymi z zakresu [0, 100]
 Tworzymytablicę myT3 o rozmiarze większej z dwóch poprzednich tablic
 Tablica myT3 jest wypełniona sumami odpowiednich komórek myT1 i myT2

 wyświetlamy tablice

myT1: [  2,  3,  11, 13, 1,  5]
myT2: [  4, 11,   2]
myT3: [  6,  14, 13, 13, 1,  5]

     
 4, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2
     
     */


