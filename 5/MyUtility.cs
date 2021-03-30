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
        public static Random myFate = new Random();
        public static int[,] Transpose(int[,] tablica)
        {
            int w = tablica.GetLength(0);
            int h = tablica.GetLength(1);
            int[,] transposed = new int[h, w];
            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    transposed[j, i] = tablica[i, j];
                }
            }
            return transposed;
        }
        public static void Print(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); ++i)
            {
                for (int j = 0; j < tablica.GetLength(1); ++j)
                {
                    Console.Write("[{0,2}]", tablica[i, j]);
                }
                Console.WriteLine();
            }

        }

        public static int[,] RandomTab(int min, int max, int losmin, int losmax)
        {
            int[,] myT1 = new int[MyUtility.myFate.Next(min, max + 1), MyUtility.myFate.Next(min, max + 1)];
            for (int i = 0; i < myT1.GetLength(0); ++i)
            {
                for (int j = 0; j < myT1.GetLength(1); ++j)
                {
                    myT1[i, j] = MyUtility.myFate.Next(losmin, losmax + 1);
                }

            }
            return myT1;
        }
        public static void printTab(int[][] myT)
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

        public static int[][] RandomTab2d(int min0, int max0, int min1, int max1, int a, int b)
        {
            int[][] myT = new int[MyUtility.myFate.Next(min0, max0 + 1)][];
            for (int i = 0; i < myT.Length; ++i)
            {
                myT[i] = new int[MyUtility.myFate.Next(min1, max1 + 1)];
            }
            for (int i = 0; i < myT.Length; ++i)
            {
                for (int j = 0; j < myT[i].Length; ++j)
                {
                    myT[i][j] = MyUtility.myFate.Next(a, b + 1);
                }
            }
            return myT;
        }
        public static int[][] CopyTab(int[][]myT)
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
    }
}