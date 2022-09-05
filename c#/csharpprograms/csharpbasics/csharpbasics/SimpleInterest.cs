using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class SimpleInterest
    {
        public void calculateInterest()
        {
            int p = 1000;
            float r = 4.0f;
            int t = 2;
            float si = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is " + si);
        }
    }
}
