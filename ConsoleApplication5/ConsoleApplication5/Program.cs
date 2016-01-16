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

        // constructor
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Complex Add(Complex c)
        {
            Complex d = new Complex(c.a + this.a, c.b + this.b);
            return d;
        } 

        public void print()
        {
            Console.WriteLine(this.a + "/" + this.b);
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        // w = c + d
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c1.b);
            return c3;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Complex d = new Complex(6, 7);
            Complex w = c + d;
            Console.WriteLine(w);

            Console.ReadKey();
        }
    }
}
