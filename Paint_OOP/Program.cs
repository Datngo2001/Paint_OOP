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
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t          -------MENU-------");
                    Console.WriteLine("\t\t\t\t\t| -       1. Add a point         - |");
                    Console.WriteLine("\t\t\t\t\t| -       2. Add a line          - |");
                    Console.WriteLine("\t\t\t\t\t| -       3. Add a triagle       - |");
                    Console.WriteLine("\t\t\t\t\t| -       4. Add a rectangle     - |");
                    Console.WriteLine("\t\t\t\t\t| -       5. Add a circle        - |");
                    Console.WriteLine("\t\t\t\t\t| -       6. Add a egde          - |");
                    Console.WriteLine("\t\t\t\t\t| -       7. Add a complex       - |");
                    Console.WriteLine("\t\t\t\t\t| -       8.                     - |");
                    Console.WriteLine("\t\t\t\t\t| -       9. Exit                - |");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("\t\t\t\t\t ----------------------------------\n");
                Console.Write("\t\t\t\t\tEnter your choise: ");
                choise = Convert.ToChar(Console.Read());
                switch (choise)
                {
                    case '1':
                        Shape point = new Point();
                        point.Input();
                        Console.WriteLine("Display: ");
                        point.Output();
                        Console.Write("Enter the distance dx you want to move: ");
                        double Dx = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double Dy = Convert.ToDouble(Console.ReadLine());
                        point.Move(Dx, Dy);
                        break;
                    case '2':
                        Console.WriteLine("Class line");
                        break;
                    case '3':
                        int choice1;
                        Console.WriteLine("--------MENU---------");
                        Console.WriteLine("1. Equilateral triangle");
                        Console.WriteLine("2. Triangle ");
                        Console.WriteLine("3. Exit!\n");
                        Console.Write("Enter your choice: ");
                        string skip;
                        skip = Console.ReadLine();
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            Triagle Equi = new EquilateralTriangle();
                            Equi.Input();
                            Console.WriteLine("Display: ");
                            Equi.Output();
                        }
                        else if(choice1 == 2)
                        {
                            Triagle tri = new Triagle();
                            tri.Input();
                            Console.WriteLine("Display: ");
                            tri.Output();
                        }
                        else if(choice1 == 3)
                        {
                            break;
                        }

                        break;
                    case '4':
                        int choice;
                        Console.WriteLine("--------MENU---------");
                        Console.WriteLine("1. Sqare");
                        Console.WriteLine("2. Parallelogram");
                        Console.WriteLine("3. Rhombus");
                        Console.WriteLine("4. Rectangle");
;                       Console.WriteLine("5. Exit!");
                        Console.Write("Enter your choice: ");
                        string next;
                        next = Console.ReadLine();
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Rectangle sqare = new Sqare();
                            sqare.Input();
                            Console.WriteLine("Display: ");
                            sqare.Output();
                        }
                        else if (choice == 2)
                        {
                            Rectangle Para1 = new Parallelogram();
                            Para1.Input();
                            Console.WriteLine("Display: ");
                            Para1.Output();
                        }
                        else if (choice == 3)
                        {
                            Rectangle rhom = new Rhombus();
                            rhom.Input();
                            Console.WriteLine("Display: ");
                            rhom.Output();
                        }

                        else if (choice == 4)
                        {
                            Rectangle rec = new Rectangle();
                            rec.Input();
                            Console.WriteLine("Display: ");
                            rec.Output();
                            break;
                        }
                        else if (choice == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your choice is ERROR! please choise again");
                        }
                        
                        

                        break;
                    case '5':
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
                    case '6':
                        Edge edge = new Edge();
                        edge.Input();
                        edge.Output();
                        edge.Draw();
                        break;
                    case '7':
                        ComplexShape a = new ComplexShape();
                        a.Input();
                        a.Output();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx00 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy00 = Convert.ToDouble(Console.ReadLine());
                        a.Move(dx00, dy00);
                        break;
                    case '8':
                        break;
                    default:
                        Console.WriteLine("Invalid choise.");
                        break;
                }                
            }
            while (choise != '8');
        }
    }
}
