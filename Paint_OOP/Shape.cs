using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Shape
    {
        public string Name { get; set; }
        public Point point1 = new Point();
        public Point point2 = new Point();
        public Shape()
        {

        }
        public Shape(double x1, double x2, double y1, double y2)
        {
            point1.X = x1;
            point2.X = x2;
            point1.Y = y1;
            point2.Y = y2;
        }
        ~Shape()
        {

        }
        public virtual void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter point 1: ");
            point1.Input();
            Console.WriteLine("Enter point 2: ");
            point2.Input();
        }
        public virtual void Output()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Point 1: ");
            point1.Output();
            Console.WriteLine("Point 2: ");
            point2.Output();
        }
    }
}
