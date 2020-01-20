using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {
        int x;
        static int y=100;
        const float pi=3.14f;
        readonly bool b;

        public Program(int x, bool b)
        {
            this.x = x;
            this.b = b;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program(100, true);
            p1.x = 300;
            Program p2 = new Program(200, false);
            Console.WriteLine("Value of x is: "+p1.x);
            Console.WriteLine("Value of x is: " + p2.x);
            Console.WriteLine("Value of y is: " + y);
            Console.WriteLine("Value of pi is: " + pi);
            Console.WriteLine("Value of b is: " + p1.b);
            Console.WriteLine("Value of b is: " + p2.b);
        }
    }
}
