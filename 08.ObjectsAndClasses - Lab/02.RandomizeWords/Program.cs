using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var rdn = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = rdn.Next(0, words.Length);
                var ramdomWord = words[randomIndex];

                words[i] = ramdomWord;
                words[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
