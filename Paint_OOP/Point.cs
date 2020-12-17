using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Point : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point()
        {

        }
        public Point(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public Point(string name, double x, double y, string color)
        {
            Name = name;
            X = x;
            Y = y;
            Color = color;
        }
        ~Point()
        {

        }
        public override void Input()
        {
            Console.Write("Name ");
            Name = Console.ReadLine();
            Console.Write("Enter point X: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter poiny Y: ");
            Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Color: ");
            Color = Console.ReadLine();
        }
        public override void Output()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("X: {0}", X);
            Console.WriteLine("Y: {0}", Y);
            Console.WriteLine("Color: " + Color);
        }
        public override void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public override double CalculateArea()
        {
            return 0;
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " point " + Name + " with position (" + X + "," + Y + ")");
            Console.ResetColor();
        }
    }
}