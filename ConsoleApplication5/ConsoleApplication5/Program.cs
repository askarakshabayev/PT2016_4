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
            // 4 5
            // string.Split()

            string s = "hello world 1 2 3";
            string[] token = s.Split();
            // token[0] = hello
            // token[1] = world

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(token[i]);
            }
            Console.ReadKey();
        }
    }
}
