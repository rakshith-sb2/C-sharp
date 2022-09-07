using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal class MethodOverload
    {
        public int add(int n1,int n2)
        {
            return n1 + n2;
        }

        public float add(float n1, float n2)
        {
            return n1 + n2;
        }

        public int add(int n1, int n2,int n3)
        {
            return n1 + n2 +n3;
        }


    }
    internal class MethodOverloadTest
    {
        public static void testOverLoad()
        {
            MethodOverload methodOverload = new MethodOverload();
            int intsum = methodOverload.add(100, 200);
            Console.WriteLine("add : int param " + intsum);
            float floatsum = methodOverload.add(100F, 200F);
            Console.WriteLine("add : float param " + floatsum);
        }
    }
}
