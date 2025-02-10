using System;

namespace HelloWorld
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine() ?? "Guest";
            Console.WriteLine($"Hello, {name}.");
        }
    }
}