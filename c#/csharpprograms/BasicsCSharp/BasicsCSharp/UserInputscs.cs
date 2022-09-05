using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal class UserInputscs
    {

        public static void eligibleToVote()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is "+name);
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            if (age >= 18)
            {
                Console.WriteLine(name + " you are eligible to vote");

            }
            else
            {
                Console.WriteLine(name + " you are not eligible to vote");

            }





        }
    }
}
