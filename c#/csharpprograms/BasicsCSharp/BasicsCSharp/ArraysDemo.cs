using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal class ArraysDemo
    {
        public static void arrays()
        {
            string[] fruits = { "Banana","Guava","Apple","Mango"};
            Console.WriteLine("looping");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine("Update");
            fruits[0] = "Jack Fruit";

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Array.Sort(fruits);
            Console.WriteLine("After sort");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("runs array of int");
            int[] runs = new int[5];
            runs[0] = 28;
            runs[1] = 28;
            runs[2] = 64;
            runs[3] = 18;
            runs[4] = 10;
            foreach(int run in runs)
            {
                Console.WriteLine(run);
            }
            int max = runs.Max();
            Console.WriteLine("maximum - " + max);
            
            int min = runs.Min();
            Console.WriteLine("mininum - " + min);
            int total = runs.Sum();
            Console.WriteLine("total - " + total);

            Array.Sort(runs);
            Console.WriteLine("After sort");

            foreach (int run in runs)
            {
                Console.WriteLine(run);
            }

            Array.Reverse(runs);
            Console.WriteLine("sorting in descending order");

            foreach (int run in runs)
            {
                Console.WriteLine(run);
            }
        }

    }
}
