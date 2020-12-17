using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Edge : Point
    {
        public double Length { get; set; }
        public Edge()
        {

        }
        public Edge(string name, double x, double y, double length) : base(name, x, y)
        {
            try
            {
                Length = length;
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
            base.Input();
            try
            {
                Console.WriteLine("Enter the length: ");
                Length = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Output()
        {
            base.Output();
            try
            {
                Console.WriteLine("Length: {0}", Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Move(double dx, double dy)
        {
            base.Move(dx, dy);
        }
        public override void Draw()
        {
            base.Draw();
        }
        public static List<Point> Listpoint { get; set; }

    }
}
