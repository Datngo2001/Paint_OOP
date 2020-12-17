using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Edge : Shape
    {
        protected List<Point> points = new List<Point>();
        public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }
        public double Length { get; set; }
        public Edge()
        {

        }
        public Edge(string name, string color,string namePoint1, double x1, double y1, string namePoint2, double x2, double y2)
        {
            try
            {
                Name = name;
                Color = color;
                Points.Add(new Point(namePoint1, x1, y1));
                Points.Add(new Point(namePoint2, x2, y2));
                CalculateLenght();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Edge(string name, double x1, double y1, double x2, double y2)
        {
            try
            {
                Name = name;
                Points.Add(new Point("A", x1, y1));
                Points.Add(new Point("B", x2, y2));
                CalculateLenght();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ~Edge()
        {

        }
        public override void Input()
        {
            try
            {
                Console.Write("Name: ");
                Name = Console.ReadLine();
                Console.Write("Color: ");
                Color = Console.ReadLine();
                Console.WriteLine("Point 1: ");
                Point point1 = new Point();
                point1.Input();
                Console.WriteLine("Point 2: ");
                Point point2 = new Point();
                point1.Input();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Output()
        {
            try
            {
                Console.Write("Name: " + Name);
                Console.Write("Color: " + Color);
                Console.WriteLine("Point 1: ");
                Points[0].Output();
                Console.WriteLine("Point 2: ");
                Points[1].Output();
                Console.WriteLine("Length: {0}", Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Move(double dx, double dy)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i].Move(dx, dy);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " edge " + Name + " with leight is " + Length);
            Console.WriteLine("and the points it go though is ");
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i].Output();
            }
            Console.ResetColor();
        }
        public void CalculateLenght()
        {
            Length = Math.Sqrt(Math.Pow(Points[0].X - Points[1].X, 2) + Math.Pow(Points[0].Y - Points[1].Y, 2));
        }
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
