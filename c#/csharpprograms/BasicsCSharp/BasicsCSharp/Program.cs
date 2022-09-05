using System;

namespace BasicsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // add();
            // dataTypes();
            //implicitTypeConversion();
            //explicitTypeConversion();
            //Operators oper = new Operators();
            //Operators.arithmeticOperator();
            //Test.greet();
            //Test test = new Test();
            //test.info();
            //Loops.whileloop();
            //Loops.forloop();
            //Loops.forloopBreakNContinue();
            UserInputscs.eligibleToVote();
        }

        static void add()
        {
            int n1 = 100;
            int n2 = 200;
            int res = n1 + n2;
            Console.WriteLine(res);      
        }

        static void dataTypes()
        {
            // Single line comment
            /*
             * Multi line comments
             * 
             */
            int n1 = 10; // int datatype
            long l1 = 10L; // long datatype
            float f1 = 100.0F; // float datatype
            double d1 = 1000.0000D; // double datatype
            bool isActive = true; // boolean
            char chr = 'A'; // character
            string course = "C# programming";
            Console.WriteLine(" int n1 " +n1);
            Console.WriteLine(" long l1 " +l1);
            Console.WriteLine($" f1 - {f1} : d1 - {d1}");
        }
        /*
         * Implicit type conversion from lower size 
         * data type to higher size data type
         * 
         */
        static void implicitTypeConversion()
        {
            Console.WriteLine("Implicit type conversion");
            int n1 = 10;
            double d1 = n1;
            Console.WriteLine($" int n1 {n1} : double d1 {d1}");
            float f1 = 1000.000F;
            double d2 = f1;
            Console.WriteLine($" float f1 {f1} : double d2 {d2}");
        }

        /*
         * Explicit Casting - converting from higher to
         * lower
         * 
         */
        static void explicitTypeConversion()
        {
            Console.WriteLine("Explicit type conversion");
            long l1 = 1000000;
            int n1 = (int)l1;
            Console.WriteLine($" long l1 {l1} : int n1 {n1}");            
        }
    }
}
