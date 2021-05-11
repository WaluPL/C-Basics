using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilityNamespace
{
    class MyUtility
    {
        public static void Pause(string myStr = null)
        {
            Console.Write(myStr);
            Console.ReadKey();
        }
        public static int Read(string myStr = "x? = ")
        {
            Console.Write(myStr);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void Read(out int x, string strX, out int y, string strY)
        {
            x = Read(strX);
            y = Read(strY);
        }
        public static int Max(int x0, int x1)
        {
            if (x0 > x1) return x0;
            return x1;
        }
        public static int Min(int x0, int x1)
        {
            if (x0 < x1) return x0;
            return x1;
        }
        public static int Max(int x0, int x1, int x2)
        {
            return Max(Max(x0, x1), x2);
        }
        public static int Max(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
        {
            return Max(Max(x0, x1, x2), Max(x3, x4, x5), Max(x6, x7));
        }
        public static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        public static int[,] Transpose(int[,] myT)
        {
            int[,] myTT = new int[myT.GetLength(1),
                                   myT.GetLength(0)];
            for(int i=0; i< myT.GetLength(0);++i)
            {
                for (int j = 0; j < myT.GetLength(1); ++j)
                {
                    myTT[j, i] = myT[i, j];
                }
            }
            return myTT;
        }
        public static void PrintTab(int[,] myT)
        {
            for (int i = 0; i < myT.GetLength(1); ++i)
            {
                for (int j = 0; j < myT.GetLength(0); ++j)
                {
                    Console.Write("[{0,2}]", myT[j, i]);
                }
                Console.WriteLine();
            }
        }
        public static int[,] RandomTab(int mins, int maxs, int a, int b)
        {
            int[,] myT = new int[MyUtility.myFate.Next(mins, maxs+1),
                                 MyUtility.myFate.Next(mins, maxs+1)];
            for (int i = 0; i < myT.GetLength(0); ++i)
            {
                for (int j = 0; j < myT.GetLength(1); ++j)
                {
                    myT[i, j] = MyUtility.myFate.Next(a, b+1);
                }
            }
            return myT;
        }
        public static void PrintTab(int[][] myT)
        {
            for (int i = 0; i < myT.Length; ++i)
            {
                for (int j = 0; j < myT[i].Length; ++j)
                {
                    Console.Write("[{0,2}]", myT[i][j]);
                }
                Console.WriteLine();
            }
        }
        public static int[][] RandomTab(int min0, int max0, int min1, int max1, int a, int b)
        {
            int[][] myT = new int[myFate.Next(min0+1, max0+1)][];
            for (int i = 0; i < myT.Length; ++i)
            {
                myT[i] = new int[myFate.Next(min1 + 1, max1 + 1)];
            }
            for (int i = 0; i < myT.Length; ++i)
            {
                for (int j = 0; j < myT[i].Length; ++j)
                {
                    myT[i][j] = myFate.Next(a + 1, b + 1);
                }
            }
            return myT;
        }
        public static int[][] CopyTab(int[][] myT)
        {
            int[][] myT2 = new int[myT.Length][];
            for (int i = 0; i < myT.Length; ++i)
            {
                myT2[i] = new int[myT[i].Length];
            }
            for (int i = 0; i < myT.Length; ++i)
            {
                for (int j = 0; j < myT[i].Length; ++j)
                {
                    myT2[i][j] = myT[i][j];
                }
            }
            return myT2;
        }

        public static void SortRawTab(int[][] myT)
        {
            for (int i = 0; i < myT.Length - 1; ++i)
            {
                bool swap = false;
                for (int j = 0; j < myT.Length - 1 - i; ++j)
                {
                    if (myT[j].Length > myT[j + 1].Length)
                    {
                        swap = true;
                        int[] tmp;
                        tmp = myT[j];
                        myT[j] = myT[j + 1];
                        myT[j + 1] = tmp;
                    }
                }
                if (!swap) i = myT.Length;                
            }
        }
        public static Random myFate = new Random();

        public delegate int Question(int x, int y);
        /* public static int MyMax(int x, int y) { if (x > y) return x; return y; } //return higher number
           public static int MyMin(int x, int y) { if (x < y) return x; return y; } //return lower number
         public static Question MyMaxi = new Question(MyMax); 
         public static Question MyMini = new Question(MyMin); functions already exist
         
        */
        public static Question myMax = new Question(Max);
        public static Question myMin = new Question(Min);
        public static int Extremum(Question MyQ, int x, int y) { return MyQ(x, y); }

    }
}
