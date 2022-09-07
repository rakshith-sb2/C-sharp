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
            //UserInputscs.eligibleToVote();
            //ArraysDemo.arrays();
            /*
            Product product1 = new Product();
            product1.code = 1;
            product1.name = "Mobile";
            product1.desc = "10 inch 8 GB RAM 64";
            product1.supplier = "Nokia";
            product1.price = 30000;

            string info= product1.info();
            Console.WriteLine(info);

            Product product2 = new Product();
            product2.code = 2;
            product2.name = "Laptop";
            product2.desc = "15 inch 8 GB RAM 64";
            product2.supplier = "Lenovo";
            product2.price = 60000;

            string info2 = product2.info();
            Console.WriteLine(info2);
            
            Console.WriteLine("Constructure");
            Customer cust1 = new Customer(1, "ravi", "ravi@gmail.com", "9845547471", "Bengaluru");
            Console.WriteLine(cust1.info());
            cust1.country = "India";
            Console.WriteLine("Country "+cust1.country);
            Console.WriteLine("Setting zip code");
            cust1.zipcode = 560001;
            Console.WriteLine("Getting zip code");
            Console.WriteLine("Zipcode " + cust1.zipcode);
            

            Car car1 = new Car();
            car1.name = "SUV";
            car1.model = "Creta";
            car1.make = "Hundai";
            car1.price = 17000000;
            car1.ac = "Kenstar";
            car1.start();
            car1.move();
            car1.move();
            Console.WriteLine(car1.info());
            car1.stop();
            
            MethodOverloadTest.testOverLoad();
            
            MethodOverride.testMethodOverride();
            */
            InterfaceDemo.interfaceDemo();
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
