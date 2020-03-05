using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Variables
            const float pi = 3.1415926f;
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
            volume = pi * radius * radius * height;

            //Area
            area = 2 * pi * radius * (radius + height);

            Console.WriteLine("Volume: " + volume + " Area: " + area);
        }
    }
}
