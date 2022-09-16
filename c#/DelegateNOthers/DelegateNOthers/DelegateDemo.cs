using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNOthers
{
    public delegate int Calculate(int n1,int n2); 
    internal class Calculator
    {
        public static int Add(int n1,int n2)
        {
            return n1 + n2;
        }

        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
    }
    
    internal class DelegateDemo
    {
        public static void DemoDelegate()
        {
            int result = 0;
            result = Calculator.Add(10, 20);
            Console.WriteLine("Regular method call : result of addition is "+result);

            Calculate calc = new Calculate(Calculator.Add);
            result = calc.Invoke(10, 20);
            Console.WriteLine("Delegate method call : result of addition is " + result);
            calc = Calculator.Subtract;
            result = calc(100, 50);
            Console.WriteLine("Delegate method call : result of subtraction is " + result);


        }
    }
}
