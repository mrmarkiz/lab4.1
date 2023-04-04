using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Task1
    {
        public static void Run()
        {
            Console.Write("Enter number: ");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                    throw new Exception("'-' symbol wasn't allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error collapsed: {ex.Message}");
                return;
            }
            Console.WriteLine($"Result number: {number}");
        }
    }
}
