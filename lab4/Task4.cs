using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Task4
    {
        public static void Run()
        {
            int vow_num, cons_num, max_len;
            Console.Write("Enter max length of text: ");
            try
            {
                max_len = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error collapsed: {ex.Message}");
                return;
            }

            Console.Write("Enter max number of vowel: ");
            try
            {
                vow_num = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error collapsed: {ex.Message}");
                return;
            }

            Console.Write("Enter  max number of consonant: ");
            try
            {
                cons_num = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error collapsed: {ex.Message}");
                return;
            }

            Console.WriteLine("Result:");
            Console.WriteLine(PseudoText.Generator.Generate(vow_num, cons_num, max_len));
        }
    }
    namespace PseudoText
    {
        class Generator
        {
            public static string Generate(int vowel_num, int consonant_num, int max_length)
            {
                Random rand = new Random();
                string res = "", vowels = "aeiouy", consonants = "bcdfghjklmnpqrstvwxz";
                int length = rand.Next(1,max_length + 1);

                while (res.Length < length && (vowel_num > 0 || consonant_num > 0))
                {
                    if (rand.Next(6) == 0)
                        res += ' ';
                    else if (vowel_num > 0 && rand.Next(2) == 0)
                    {
                        res += vowels[rand.Next(vowels.Length)];
                        vowel_num--;
                    }
                    else
                    {
                        res += consonants[rand.Next(consonants.Length)];
                        consonant_num--;
                    }
                }
                return res;
            }
        }
    }
}
