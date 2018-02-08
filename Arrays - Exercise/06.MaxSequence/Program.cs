using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var bestStart = input[0];
            var bestLenght = 1;
            var currentStart = input[0];
            var currentLenght = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestStart = currentStart;
                    }
                } else
                {
                    currentStart = input[i];
                    currentLenght = 1;
                }
            }

            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();

        }
    }
}
