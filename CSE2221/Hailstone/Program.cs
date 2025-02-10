using System;

namespace Hailstone
{
    class Program
    {
        private Program() { }
        static void Main(string[] args)
        {
            Console.WriteLine("\nHailstone Sequence\nNumber: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int count = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                Console.Write($"{n} ");
                count++;
            }

            Console.WriteLine($"\nNumber of steps: {count}");
        }
    }
}