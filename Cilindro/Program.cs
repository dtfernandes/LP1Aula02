using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Variables
            const float pi = (float)Math.PI;
            float radius, height = 0;
            float area, volume;

            

            //Ask For Input
            Console.WriteLine("Please introduce height and radius!");
            
            //Parse Input to float
            if(!float.TryParse(Console.ReadLine(), out radius) 
            || !float.TryParse(Console.ReadLine(), out height)){
                Console.WriteLine("Isso n e um float.");
                Environment.Exit(0);
            }

            //Volume
            volume = pi * (float)Math.Pow(radius,2) * height;

            //Area
            area = 2 * pi * radius * (radius + height);

            Console.WriteLine("Volume: " + volume + " Area: " + area);

            
        }
    }
}
