using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] letters = new int[26];
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (int)('a'+i);
            }
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if ((int)input[i] == letters[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
