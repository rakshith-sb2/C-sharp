using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{

    internal  abstract class Shape
    {
        public abstract void draw();

        public void info()
        {
            Console.WriteLine("Iam Shape:Abstract Class");
        }

    }

    internal class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Circle is drawn");
        }

        public void OtherShape()
        {
            Console.WriteLine("I can draw other shapes using circle");
        }

    }
    internal class AbstractClassDemo
    {
        public static void testAbstractClass()
        {
           // Shape shape = new Shape();
           Shape shape = new Circle();
            shape.draw();
            shape.info();

            Circle circle = new Circle();
            circle.OtherShape();
        }
    }
}
