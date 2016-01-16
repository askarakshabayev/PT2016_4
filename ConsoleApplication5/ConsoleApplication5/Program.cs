using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{   //    5/6, 6/7
    class Complex
    {
        public int a, b;

        public Complex Add(Complex c)
        {
            Complex d = new Complex();
            d.a = c.a + this.a;
            d.b = c.b + this.b;
            return d;
        } 

        public void print()
        {
            Console.WriteLine(this.a + "/" + this.b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.a = 5;
            c.b = 6;
            c.print();

            Complex d = new Complex();
            d.a = 6;
            d.b = 7;
            d.print();


            Complex w = c.Add(d); // Complex Add(Complex c)
            w.print();
            Console.ReadKey();
        }
    }
}
