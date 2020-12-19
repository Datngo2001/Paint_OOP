using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Triagle : Shape
    {
        protected Point[] points = new Point[3];
        
        public Point[] Pointss
        {
            get { return points; }
            set { points = value; }
        }
        protected Edge[] edges = new Edge[3];
        public Edge[] Edges
        {
            get { return edges; }
            set { edges = value; }
        }
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }
        public Triagle()
        {

        }
        public Triagle(string name, double a, double b, double c)
        {
            try
            {
                Pointss[0] = new Point(name[0].ToString(), 0, 0);
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Triagle(string name, string color, double a, double b, double c)
        {
            try
            {
                Pointss[0] = new Point(name[0].ToString(), 0, 0);
                Color = color;
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
                CalculateArea();
                CreatePoint();
                CreateEdge();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        protected virtual void CreatePoint()
        {
            double p = (EdgeA + EdgeB + EdgeC) / 2;
            double heights = 2 * Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC))/ EdgeA;
            double width = EdgeA;
            Pointss[1] = new Point(Name[1].ToString(), 0, width);
            Pointss[2] = new Point(Name[2].ToString(), width, heights);
        }
        protected virtual void CreateEdge()
        {
            Edges[0] = new Edge(Pointss[0], Pointss[1]);
            Edges[1] = new Edge(Pointss[1], Pointss[2]);
            Edges[2] = new Edge(Pointss[2], Pointss[0]);
        }
        public override void Input()
        {
            try
            {
                Console.WriteLine("Enter name of triagle: ");
                Name = Console.ReadLine();
                do
                {
                    Console.WriteLine("Enter color: ");
                    Color = Console.ReadLine();
                    Console.WriteLine("Enter the Edge 1: ");
                    EdgeA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Edge 2: ");
                    EdgeB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Edge 3: ");
                    EdgeC = Convert.ToDouble(Console.ReadLine());
                }
                while (EdgeA + EdgeB <= EdgeC || EdgeB + EdgeC <= EdgeA || EdgeA + EdgeC <= EdgeB);
                Pointss[0] = new Point(Name[0].ToString(), 0, 0);
                CalculateArea();
                CreatePoint();
                CreateEdge();


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            
        }
        public int CheckTriangle()
        {
            if (EdgeA == EdgeB || EdgeB == EdgeC || EdgeC == EdgeA)
                if (EdgeA == EdgeB && EdgeB == EdgeC)
                    return 1;
                else if (EdgeA * EdgeA == EdgeB * EdgeB + EdgeC * EdgeC || EdgeB * EdgeB == EdgeA * EdgeA + EdgeC * EdgeC || EdgeB * EdgeB + EdgeA * EdgeA == EdgeC * EdgeC)
                    return 2;
                else return 3;
            else if (EdgeA * EdgeA == EdgeB * EdgeB + EdgeC * EdgeC || EdgeB * EdgeB == EdgeA * EdgeA + EdgeC * EdgeC || EdgeB * EdgeB + EdgeA * EdgeA == EdgeC * EdgeC)
                return 4;
            else return 5;
        }
        public void TypeofTriangle()
        {
            switch (CheckTriangle())
            {
                case 1:
                    Console.WriteLine("Tam giac deu \n");
                    break;
                case 2:
                    Console.WriteLine("Tam giac vuong can \n");
                    break;
                case 3:
                    Console.WriteLine("Tam giac can \n");
                    break;
                case 4:
                    Console.WriteLine("Tam giac vuong \n");
                    break;
                default:
                    Console.WriteLine("Tam giac thuong \n");
                    break;
            }
        }
        public override void Output()
        {
            try
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Edge 1: " + EdgeA);
                Console.WriteLine("Edge 2: " + EdgeB);
                Console.WriteLine("Edge 3: " + EdgeC);
                Console.WriteLine("Area of triangle: " + Area);
                Console.WriteLine("The three points: ");
                for(int i = 0; i < Pointss.Length; i++)
                {
                    Pointss[i].Output();
                }
                    //switch (CheckTriangle())
                    //{
                    //    case 1:
                    //        Console.WriteLine("Tam giac deu \n");
                    //        break;
                    //    case 2:
                    //        Console.WriteLine("Tam giac vuong can \n");
                    //        break;
                    //    case 3:
                    //        Console.WriteLine("Tam giac can \n");
                    //        break;
                    //    case 4:
                    //        Console.WriteLine("Tam giac vuong \n");
                    //        break;
                    //    default:
                    //        Console.WriteLine("Tam giac thuong \n");
                    //        break;                   
                    //}
                }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //public override void ChangeColor(string newColor)
        //{
        //    base.ChangeColor(newColor);
        //}
        public override double CalculateArea()
        {
            try
            {
                double p = 0.5 * (EdgeA + EdgeB + EdgeC);
                Area = 0.25 * Math.Sqrt((EdgeA + EdgeB + EdgeC) *(EdgeA + EdgeB - EdgeC) *(EdgeB + EdgeC - EdgeA) *(EdgeC - EdgeB + EdgeA));
                
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
            Console.WriteLine("Drawed a " + Color + " triangle " + Name + " with Edge 1 is " + EdgeA + " Edge 2 is " + EdgeB + " and Edge 3 is " + EdgeC);
            Console.ResetColor();
        }
        public override void Move(double dx, double dy)
        {
            try
            {
                for(int i = 0; i < Pointss.Length; i++)
                {
                    Pointss[i].Move(dx, dy);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }         
        }
    }
}
