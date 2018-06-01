using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@([a-zA-Z]+)[^@\-!>:]*:([0-9.]+)[^@\-!>:]*!(A|D)![^@\-!>:]*->([0-9.]+)";
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int key = CountStar(input);
                string decryptedMessage = Dectypt(input, key);
                
                if (!Regex.IsMatch(decryptedMessage, pattern))
                {
                    continue;
                }
                
                Match match = Regex.Match(decryptedMessage, pattern);
                

                if (match.Groups[3].ToString() == "A")
                {
                    attacked.Add(match.Groups[1].ToString());
                }
                else // check if the other one is indeed A?
                {
                    destroyed.Add(match.Groups[1].ToString());
                }
                
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var planet in attacked.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var planet in destroyed.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static int CountStar (string input)
        {
            int counter = 0;
            input = input.ToLower();
            foreach (var c in input)
            {
                if (c == 's' || c == 't' || c == 'a' || c == 'r')
                {
                    counter++;
                }
            }

            return counter;
        }

        static string Dectypt (string input, int key)
        {
            StringBuilder decryptedMessage = new StringBuilder();

            foreach (var letter in input)
            {
                char letterToAdd = (char)(letter - key);
                decryptedMessage.Append(letterToAdd);
            }

            return decryptedMessage.ToString();
        }
    }
}
