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
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a word to be translated");

            string input = Console.ReadLine().ToLower();
            int length = input.Length;
            string[] results = input.Split(' ');
            int res = results.Length - 1;

            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            int t = 0;
            foreach (string s in results)
            {
                
                char[] q = s.ToArray();
                int x = s.IndexOfAny(vowel);
                string p = s.Substring(0, x);
                string rem = s.Substring(x, q.Length - x);
                string[] combo = { rem + p };
                Console.WriteLine(combo[t]);
                t++;
                //Console.Write("{0}{1}ay \n", rem, p);

               /* if (s.StartsWith("a") || s.StartsWith("e") || s.StartsWith("i") || s.StartsWith("o") || s.StartsWith("u"))
                {
                    string v = s + "way";
                    if (s.StartsWith("a") || s.StartsWith("e") || s.StartsWith("i") || s.StartsWith("o") || s.StartsWith("u"))
                        {
                            Console.Write("{0}{1}ay \n", rem, p, v);
                        }
                }
                else
                {
                    Console.Write("{0}{1}ay \n", rem, p);
                }*/                
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
