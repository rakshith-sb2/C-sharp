using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal static class Operators
    {
        public static void arithmeticOperator()
        {
            Console.WriteLine("Arithmetic Operators");
            int n1 = 100;
            int n2 = 33;
            int result = n1 + n2;
            Console.WriteLine("n1 + n2 " + result);
            result = n1 % n2;
            Console.WriteLine("n1 % n2 " + result);
        }
    }

    public class Test
    {
        public static void greet()
        {
            Console.WriteLine("Greet");
        }
        public void info()
        {
            Console.WriteLine("info method");
            }

    }
}
