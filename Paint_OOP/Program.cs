using System;

namespace Paint_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("-------Menu-------");
                    Console.WriteLine("1. Add a point");
                    Console.WriteLine("2. Add a line");
                    Console.WriteLine("3. Add a triagle");
                    Console.WriteLine("4. Add a rectangle");
                    Console.WriteLine("5. Add a circle");
                    Console.WriteLine("6. Add a angle");
                    Console.WriteLine("7. Add a egde");
                    Console.WriteLine("8. Exit");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Enter your choise: ");
                choise = Convert.ToString(Console.ReadLine());
                switch (choise)
                {
                    case "1":
                        Point point = new Point();
                        point.Input();
                        point.Output();
                        point.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx3 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy3 = Convert.ToDouble(Console.ReadLine());
                        point.Move(dx3, dy3);
                        break;
                    case "2":
                        Console.WriteLine("Class line");
                        // Line line = new Line();
                        // line.input();
                        // abcxyz();
                        break;
                    case "3":
                        Triagle triagle = new Triagle();
                        triagle.Input();
                        Console.WriteLine("Display: \n\n");
                        triagle.Output();
                        triagle.TypeofTriangle();
                        triagle.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy = Convert.ToDouble(Console.ReadLine());
                        triagle.Move(dx, dy);

                        break;
                    case "4":
                        Rectangle rectangule = new Rectangle();
                        //>>>>>>> 5943ce1b50aaae85ebf274dfc0cf1411fd821228
                        rectangule.Input();
                        Console.WriteLine("Display: \n\n");
                        rectangule.Output();
                        rectangule.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy1 = Convert.ToDouble(Console.ReadLine());
                        rectangule.Move(dx1, dy1);
                        break;
                    case "5":
                        Circle circle = new Circle();
                        circle.Input();
                        circle.Output();
                        circle.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy2 = Convert.ToDouble(Console.ReadLine());
                        circle.Move(dx2, dy2);
                        break;
                    case "6":
                        Console.WriteLine("");
                        Edge edge = new Edge();
                        edge.Input();
                        edge.CalculateLenght();
                        edge.Output();
                        edge.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx4 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy4 = Convert.ToDouble(Console.ReadLine());
                        edge.Move(dx4, dy4);
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid choise.");
                        break;
                }                
            }
            while (choise != "8");
        }
    }
}
