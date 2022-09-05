using System;

namespace csharpbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            greetings();
            SimpleInterest si = new SimpleInterest();
            si.calculateInterest();
        }

        static void greetings()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name + " Welcome to C#");
            Console.WriteLine($"{name} - Welcome to C#");
        }
    }
}
