using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] ".ToCharArray
                (),StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> allUpper = new List<string>();
            List<string> allLower = new List<string>();
            List<string> mixed = new List<string>();

            foreach (var word in input)
            {
                if (IsUpperWord(word))
                {
                    allUpper.Add(word);
                }
                else if (IsLowerWord(word))
                {
                    allLower.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", allLower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", allUpper));

        }

        static bool IsUpperWord (string word)
        {
            foreach (var symbol in word)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return false;
                }
                          
            }
            return true;
        }

        static bool IsLowerWord(string word)
        {
            foreach (var symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }

            }
            return true;
        }
    }
}
