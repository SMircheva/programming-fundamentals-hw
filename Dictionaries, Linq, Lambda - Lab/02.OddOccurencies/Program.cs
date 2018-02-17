using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var wordToLower = word.ToLower();
                if (wordCount.ContainsKey(wordToLower))
                {
                    wordCount[wordToLower]++;
                } else
                {
                    wordCount[wordToLower] = 1;
                }
            }

            var output = new List<string>();
            foreach (var count in wordCount)
            {
                if (count.Value % 2 != 0)
                {
                    output.Add(count.Key);
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
