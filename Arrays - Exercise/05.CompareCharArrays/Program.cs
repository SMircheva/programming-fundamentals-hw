using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] word2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool isFirst = false;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i] < word2[i])
                {
                    isFirst = true;
                    break;
                }
                else if (word1[i] > word2[i])
                {
                    break;
                }

                if (i == Math.Min(word1.Length, word2.Length) - 1)
                {
                    if(word1.Length < word2.Length)
                    {
                        isFirst = true;
                    }
                }
            }

            if (isFirst)
            {
                Console.WriteLine(string.Join("", word1));
                Console.WriteLine(string.Join("", word2));

            }
            else
            {
                Console.WriteLine(string.Join("", word2));
                Console.WriteLine(string.Join("", word1));

            }

        }
    }
}
