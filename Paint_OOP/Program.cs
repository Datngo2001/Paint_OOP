using System;

namespace Paint_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            char choise;
            do
            {
                Console.WriteLine();
                Console.WriteLine("-------Menu-------");
                Console.WriteLine("0. Add a point");
                Console.WriteLine("1. Add a line");
                Console.WriteLine("2. Add a triagle");
                Console.WriteLine("3. Add a rectangle");
                Console.WriteLine("4. Add a circle");
                Console.WriteLine("5. Add a angle");
                Console.WriteLine("6. Add a egde");
                Console.WriteLine("7. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choise: ");
                choise = Convert.ToChar(Console.ReadLine());

                switch (choise)
                {
                    case '0':
                        Point point = new Point();
                        point.Input();                        
                        point.Draw();
                        break;
                    case '1':
                        Console.WriteLine("Class line");
                        // Line line = new Line();
                        // line.input();
                        // abcxyz();
                        break;
                    case '2':
                        Console.WriteLine("");
                        break;
                    case '3':
                        Console.WriteLine("");
                        break;
                    case '4':
                        Circle circle = new Circle();
                        circle.Input();
                        circle.CalculateArea();
                        circle.Output();
                        circle.Draw();
                        break;
                    case '6':
                        Console.WriteLine("");
                        Edge edge = new Edge();
                        edge.Input();
                        edge.CalculateLenght();
                        edge.Output();
                        edge.Draw();
                        break;
                    case '7':
                        break;
                    default:
                        Console.WriteLine("Invalid choise.");
                        break;
                }                
            }
            while (choise != 7);
        }
    }
}
