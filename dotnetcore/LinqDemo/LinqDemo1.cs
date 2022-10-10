using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class LinqDemo1
    {
        public static void demo1()
        {
            string[] names = {"Bill", "Steve", "James", "Mohan" };
            //LINQ Query
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query Execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }

        public static void demo2Object()
        {
            Student[] studentArray =
            {
                new Student(){StudentID=1,StudentName="John",Age=18},
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };

            //use LINQ to find teenager students

            Student[] teenAgeStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            foreach(var teens in teenAgeStudents)
            {
                Console.WriteLine("Name : " + teens.StudentName + "Age :" + teens.Age);
            }

            //Use LINQ to find first student whose name is Bill
            Student stud = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine("Bill : Name : " + stud.StudentName + "Age :" + stud.Age);
            //Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine("Student with id 5 : Name : " + student5.StudentName + "Age :" + student5.Age);

        }

        public static void demo3List()
        {
            // string collection
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

         // LINQ Query Syntax
         var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

         // Query Execution
         foreach (var res in result)
                Console.Write(res + " ");
        }
    
    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
}
