using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;

namespace C05
{
    class Application
    {
        public void Run()
        {
            Main05();
            MyUtility.Pause("Od jutra zabieram się do pracy ... \n");
        }
        private void Main01()
        {
            int[][] myT;
            myT = new int[5][];
            for (int i = 0; i < myT.Length; ++i)
            {
                myT[i] = new int[3];
            }
            for(int i = 0; i < myT.Length; ++i)
            {
                for(int j = 0; j < myT[i].Length; ++j)
                {
                    myT[i][j] = MyUtility.myFate.Next(0, 100);
                }
            }

            MyUtility.printTab(myT);
           
        }
        private void Main04()
        {
            int[][] myT = new int[MyUtility.myFate.Next(5, 9)][];
            for (int i = 0; i < myT.Length; ++i)
            {
                myT[i]= new int[2 * i + 2];
            }
            for (int i = 0; i < myT.Length; ++i)
            {
                for (int j = 0; j < myT[i].Length; ++j)
                {
                    myT[i][j] = MyUtility.myFate.Next(0, 100);
                }
            }
            MyUtility.printTab(myT);
        }
        private void Main05()
        {
            int min0 = 5, max0 = 5, min1 = 7, max1 = 11 , a = 0, b = 99;
            int[][] myT = MyUtility.RandomTab2d(min0, max0, min1, max1, a, b);
            Console.WriteLine("--------------------------myT-----------------------------");
            MyUtility.printTab(myT);
            int[][] myT2;
            myT2 = myT;
            myT2[0][0] = -9;
            Console.WriteLine("--------------------------myT=myT2-----------------------------");
            MyUtility.printTab(myT);
            Console.WriteLine("--------------------------myT2=myT-----------------------------");
            MyUtility.printTab(myT2);
            //myT2 is reference the same as myT1 so we do a method witch copies tab
            myT2 = MyUtility.CopyTab(myT);
            Console.WriteLine("--------------------------myT-----------------------------");
            MyUtility.printTab(myT);
            Console.WriteLine("--------------------------myT2-----------------------------");
            MyUtility.printTab(myT2);
        }
    }
}
