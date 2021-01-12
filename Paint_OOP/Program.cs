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
                    Console.WriteLine("\t\t\t\t-------Menu-------");
                    Console.WriteLine("\t\t\t\t1. Add a point");
                    Console.WriteLine("\t\t\t\t2. Add a line");
                    Console.WriteLine("\t\t\t\t3. Add a triagle");
                    Console.WriteLine("\t\t\t\t4. Add a rectangle");
                    Console.WriteLine("\t\t\t\t5. Add a circle");
                    Console.WriteLine("\t\t\t\t6. Add a egde");
                    Console.WriteLine("\t\t\t\t7. Add a complex");
                    Console.WriteLine("\t\t\t\t8. ");
                    Console.WriteLine("\t\t\t\t9. Exit");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("\t\t\t\tEnter your choise: ");
                choise = Convert.ToChar(Console.Read());
                switch (choise)
                {
                    case '1':
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
                    case '2':
                        Console.WriteLine("Class line");
                        break;
                    case '3':
                        Triagle triagle = new Triagle();
                        triagle.Input();
                        Console.WriteLine("Display: \n\n");
                        triagle.Output();
                        triagle.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy = Convert.ToDouble(Console.ReadLine());
                        triagle.Move(dx, dy);
                        break;
                    case '4':
                        int choice;
                        Console.WriteLine("1. Sqare");
                        Console.WriteLine("2. Parallelogram");
                        Console.WriteLine("3. Rhombus");
                        Console.WriteLine("4. Rectangle");
;                        Console.WriteLine("5. Exit!");
                        Console.Write("Enter your choice: ");
                        string next;
                        next = Console.ReadLine();
                        choice = Convert.ToInt32(Console.ReadLine());                      
                            if (choice == 1)
                            {
                                Rectangle sqare = new Sqare();
                                sqare.Input();
                                sqare.Output();
                            }
                            else if (choice == 2)
                            {
                                Rectangle Para1 = new Parallelogram();
                                Para1.Input();
                                Console.WriteLine("Display: \n\n");
                                Para1.Output();
                                Para1.Draw();
                                Console.Write("Enter the distance dx you want to move: ");
                                double dx1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter the distance dy you want to move: ");
                                double dy1 = Convert.ToDouble(Console.ReadLine());
                                Para1.Move(dx1, dy1);
                                Para1.Turn();
                            }
                            else if(choice ==3 )
                            {
                                Rectangle rhom = new Rhombus();
                                rhom.Input();
                                rhom.Output();
                            }

                            else if (choice == 4)
                                break;
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
                        Console.WriteLine("");
                        Edge edge = new Edge();
                        edge.Input();
                        edge.Output();
                        edge.Draw();
                        Console.Write("Enter the distance dx you want to move: ");
                        double dx4 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the distance dy you want to move: ");
                        double dy4 = Convert.ToDouble(Console.ReadLine());
                        edge.Move(dx4, dy4);
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
