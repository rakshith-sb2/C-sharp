using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    
    internal class DelegateDemo
    {
        public static void Addition(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("Result of addition is "+ result);
        }

        public static void Multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            Console.WriteLine("Result of multiplication is " + result);
        }

        public static void Division(int n1, int n2)
        {
            int result = n1 / n2;
            Console.WriteLine("Result of division is " + result);
        }

        public static void show()
        {
            Console.WriteLine("show");
        }
    }
}
