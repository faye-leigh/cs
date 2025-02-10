using System;

namespace MonteCarlo
{
    class Program
    {
        private Program() { }
        static void Main(string[] args)
        {
            Console.WriteLine("\nMonte Carlo Simulation\nNumber of points: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int inCircle = 0;
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = rand.NextDouble() * 2 - 1;
                double y = rand.NextDouble() * 2 - 1;

                if (x * x + y * y <= 1)
                {
                    inCircle++;
                }
            }

            double area = inCircle / (double)n * 4;
            Console.WriteLine($"Area of circle: {area}");
        }
    }
}