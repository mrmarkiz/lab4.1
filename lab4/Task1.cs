using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Task1
    {
        private static void ShowArray(int[] array)
        {
            foreach(int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        public static void Run()
        {
            Console.Write("Enter bounds: ");
            int a, b;
            try
            {
                string[] input = Console.ReadLine().Split(' ');
                if(input.Length < 2)
                {
                    throw new Exception("Uncorrect bounds");
                }
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error collapsed: {ex.Message}");
                return;
            }
            if (a > b) 
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            Console.Write("Enter what number you need(odd, even, simple): ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "odd":
                    ShowArray(Fibonacci.Odd.Generator.Get(a, b));
                    break;
                case "even":
                    ShowArray(Fibonacci.Even.Generator.Get(a, b));
                    break;
                case "simple":
                    ShowArray(Fibonacci.Simple.Generator.Get(a, b));
                    break;
            }
        }
    }

    namespace Fibonacci
    {
        namespace Even
        {
            class Generator
            {
                public static int[] Get(int a, int b)
                {
                    int[] res = new int[0];
                    int x= 0, y = 1, z = 1;
                    while (x <= b)
                    {
                        if (x >= a && x % 2 == 0)
                        {
                            res = res.Append(x).ToArray();
                        }
                        int tmp = z + y;
                        x = y;
                        y = z;
                        z = tmp;
                    }
                    return res;
                }
            }
        }
        namespace Odd
        {
            class Generator
            {
                public static int[] Get(int a, int b)
                {
                    int[] res = new int[0];
                    int x = 0, y = 1, z = 1;
                    while (x <= b)
                    {
                        if (x >= a && x % 2 == 1)
                        {
                            res = res.Append(x).ToArray();
                        }
                        int tmp = z + y;
                        x = y;
                        y = z;
                        z = tmp;
                    }
                    return res;
                }
            }
        }
        namespace Simple
        {
            class Generator
            {
                private static bool IsSimple(int a)
                {
                    int num = 0;
                    for (int i = 1; i < Math.Sqrt(a); i++)
                        if (a % i == 0)
                            num++;
                    return num <= 1;
                }
                public static int[] Get(int a, int b)
                {
                    int[] res = new int[0];
                    int x = 0, y = 1, z = 1;
                    while (x <= b)
                    {
                        if (x >= a && IsSimple(x))
                        {
                            res = res.Append(x).ToArray();
                        }
                        int tmp = z + y;
                        x = y;
                        y = z;
                        z = tmp;
                    }
                    return res;
                }
            }
        }
    }
}
