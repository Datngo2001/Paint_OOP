using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Rectangular : Shape
    {
        protected Point[] points = new Point[4];
        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }
        protected Edge[] edges = new Edge[4];
        public Edge[] Edges
        {
            get { return edges; }
            set { edges = value; }
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangular()
        {

        }
        public Rectangular(string name, double width, double height)
        {
            try
            {
                Points[0] = new Point(name[0].ToString(), 0, 0);
                Width = width;
                Height = height;
                CalculateArea();
                createOtherPoint();
                createEdge();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public Rectangular(string name, string color, double width, double height)
        {
            try
            {
                Points[0] = new Point(name[0].ToString(), 0, 0);
                Width = width;
                Height = height;
                Color = color;
                CalculateArea();
                createOtherPoint();
                createEdge();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        protected virtual void createOtherPoint()
        {
            Points[1] = new Point(Name[1].ToString(), 0, Width);
            Points[2] = new Point(Name[2].ToString(), Height, Width);
            Points[3] = new Point(Name[3].ToString(), Height, 0);
        }
        protected virtual void createEdge()
        {
            Edges[0] = new Edge(Points[0], Points[1]);
            Edges[1] = new Edge(Points[1], Points[2]);
            Edges[2] = new Edge(Points[2], Points[3]);
            Edges[3] = new Edge(Points[3], Points[0]);
        }
        public override void Input()
        {
            try
            {
                Console.Write("Enter the Name: ");
                Name = Console.ReadLine();
                Console.Write("Color: ");
                Color = Console.ReadLine();
                Console.Write("Enter the Width: ");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Height: ");
                Height = Convert.ToDouble(Console.ReadLine());
                Points[0] = new Point(Name[0].ToString(), 0, 0);
                CalculateArea();
                createOtherPoint();
                createEdge();
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
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Width: " + Width);
                Console.WriteLine("Height: " + Height);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Area: " + Area);
                Console.WriteLine("The four point: ");
                for (int i = 0; i < Points.Length; i++)
                {
                    Points[i].Output();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override double CalculateArea()
        {
            try
            {
                Area = Width * Height;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Area;
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " rectangular " + Name + " with Height is " + Height + " Width is " + Width);
            Console.ResetColor();
        }
        public override void Move(double dx, double dy)
        {
            try
            {
                for (int i = 0; i < Points.Length; i++)
                {
                    Points[i].Move(dx, dy);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
