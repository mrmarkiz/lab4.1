using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Task3
    {
        public static void Run()
        {
            Console.Write("Enter bounds: ");
            int a, b;
            try
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length < 2)
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
            int result = GuessNum.Game.Play(a, b);
            Console.WriteLine($"So your number is {result}");
        }
    }
    namespace GuessNum
    {
        class Game
        {
            public static int Play(int a, int b)
            {
                string answer;
                int dif = (a + b) / 2;
                int current_num = dif;
                do
                {
                    Console.WriteLine($"Is this your number {current_num}?");
                    answer = Console.ReadLine();
                    if(answer =="no")
                    {
                        Console.WriteLine("Your number is bigger or smaller?");
                        answer = Console.ReadLine();
                        if (answer == "bigger")
                        {
                            dif = Convert.ToInt32((Math.Ceiling(dif / 2.0)));
                            current_num += dif;
                        }
                        else if (answer == "smaller")
                        {
                            dif = Convert.ToInt32((Math.Ceiling(dif / 2.0)));
                            current_num -= dif;
                        }
                    }

                } while (answer != "yes");
                return current_num;
            }
        }
    }
}
