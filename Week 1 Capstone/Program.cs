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
            string input= "";
            char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string[] punc = { "!", "@", "#", "$", "%", "^", "&", "*", ",", "." };
            bool again = true;
            while (again == true)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!\n");
                Console.Write("Enter a sentence to be translated: ");
                
                    input = Console.ReadLine();
                    int length = input.Length;
                    string[] results = input.Split(' ');
                    int res = results.Length - 1;

                Console.Write("\nYour translated words are: ");
                
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
                        if (s.Contains("!") || s.Contains("@") || s.Contains("#") || s.Contains("$")
                            || s.Contains("%") || s.Contains("^") || s.Contains("&") || s.Contains("*")
                            || s.Contains("+") || s.Contains(",") || s.Contains("."))
                        {
                            int k = n;
                            combined[k] = combined[k].Replace(combined[k], s);
                        }
                        else if (s.StartsWith("a") || s.StartsWith("e") || s.StartsWith("i") || s.StartsWith("o") || s.StartsWith("u") ||
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
                Console.Write("\n\nTranslate another line? (y/n): ");
                string rep = Console.ReadLine().ToLower();
                if (rep != "y")
                {                    
                    again = false;
                }
                else
                {
                    Console.Clear();
                }
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        //       NOT WORKING
        public static string [] Punc(string[] punct)
        {
            string input = "";
            char[] punc = { '!', '@', '#', '$', '%', '^', '&', '*', ',', '.' };

            for (int i = 0; i < punc.Length; i++)
            {
                input.Contains(punc[i]);                
            }
            return punct;
        //      NOT WORKING
        }
    }
}
