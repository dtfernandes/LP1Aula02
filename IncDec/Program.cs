using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =2, b = 4;

            int c = a++ + ++a;

            int x = 2;

            x = 2;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("x: " + x);

        }
    }
}
