using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SentenceByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new char[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex(@"\b" + word + @"\b");

            foreach (var sentence in sentences)
            {
                if (pattern.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
