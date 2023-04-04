using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Task2
    {
        public static void Run()
        {
            Console.Write("Enter what figure to print(triangle, square, rectangular): ");
            string choice = Console.ReadLine();
            int a, b;
            switch(choice)
            {
                case "triangle":
                    Console.Write("Enter side length: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        if (a < 0)
                            throw new Exception("Length must be positive number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error collapsed: {ex.Message}");
                        return;
                    }
                    Figures.Triangle.Printer.Print(a);
                    break;

                case "square":
                    Console.Write("Enter side length: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        if (a < 0)
                            throw new Exception("Length must be positive number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error collapsed: {ex.Message}");
                        return;
                    }
                    Figures.Square.Printer.Print(a);
                    break;

                case "rectangular":
                    Console.Write("Enter sides length: ");
                    try
                    {
                        string[] input = Console.ReadLine().Split(' ');
                        if (input.Length < 2)
                            throw new Exception("Uncorrect length");
                        a = int.Parse(input[0]);
                        b = int.Parse(input[1]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error collapsed: {ex.Message}");
                        return;
                    }
                    Figures.Rectangular.Printer.Print(a, b);
                    break;
            }
        }
    }

    namespace Figures
    {
        namespace Triangle
        {
            class Printer
            {
                public static void Print(int a)
                {
                    for(int i = 0; i < a; i++)
                    {
                        for(int j=0;j<a-i;j++)
                            Console.Write(" ");
                        for (int j=0;j<=i;j++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                }
            }
        }
        namespace Square
        {
            class Printer
            {
                public static void Print(int a)
                {
                    for(int i=0; i<a; i++)
                    {
                        for(int j=0;j<a; j++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                }
            }
        }
        namespace Rectangular
        {
            class Printer
            {
                public static void Print(int a, int b)
                {
                    for(int i=0;i<a;i++)
                    {
                        for(int j=0;j<b;j++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
