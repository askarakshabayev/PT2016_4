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
            string[] token = Console.ReadLine().Split();
            int a = int.Parse(token[0]);
            int b = int.Parse(token[1]);
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
