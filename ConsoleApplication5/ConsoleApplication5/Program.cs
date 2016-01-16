using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[,] b = new int[3, 4];

            int[,,] c = new int[2, 3, 4];

            int[] a1 = { 1, 2, 3, 4, 5 };

            foreach(int x in a1)
            {
                Console.WriteLine(x);
            }

            for (int i = 0; i < 4; i++)
            {
                int x = a1[i];
                Console.WriteLine(x);
            }

            // 1 2 3 
            // 4 5 6
            //int[,] b1 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //int[][] ab = new int[4][];

            //for (int i = 0; i < 4; i++)
            //{
            //    ab[i] = new int[i + 1];
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        ab[i][j] = i + j;
            //    }
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(ab[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}




            Console.ReadKey();
        }
    }
}
