using System;
using System.Text;

namespace ValoresEspeciais
{
    class Program
    {       

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

        }
    }
}
