using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine("Enter a word to be translated");

                string input = Console.ReadLine();
                int length = input.Length;
                string[] results = input.Split(' ');
                int res = results.Length - 1;

                char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                foreach (string s in results)
                {
                    char[] q = s.ToArray();
                    int x = s.IndexOfAny(vowel);
                    string p = s.Substring(0, x);
                    string rem = s.Substring(x, q.Length - x);
                    string combo = rem + p;
                    string[] combined = combo.Split(' ');

                    for (int n = 0; n < combined.Length; n++)
                    {
                        if (s.StartsWith("a") || s.StartsWith("e") || s.StartsWith("i") || s.StartsWith("o") || s.StartsWith("u") ||
                            s.StartsWith("A") || s.StartsWith("E") || s.StartsWith("I") || s.StartsWith("O") || s.StartsWith("U"))
                        {
                            int m = n;
                            combined[m] = combined[m].Replace(combined[m], combined[m] + "way");
                        }
                        else
                        {
                            int l = n;
                            combined[l] = combined[l].Replace(combined[l], combined[l] + "ay");
                        }
                        Console.Write(combined[n] + " ");
                    }
                }
                Console.Write("\nTranslate another line? (y/n): ");
                string rep = Console.ReadLine().ToLower();
                if (rep != "y")
                {
                    Console.Clear();
                    again = false;
                }
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
