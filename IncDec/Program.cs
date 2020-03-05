using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =2, b = 4;

            int c = a++ + ++a;
            
            int d = c + --b + a;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);

        }
    }
}
