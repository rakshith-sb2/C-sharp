using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemoNew
{
    class DemoLinq
    {

        public static void Demo1()
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }
    }
}
