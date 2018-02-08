using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(' ')
                .Select(long.Parse).ToArray();
            long bestPosition = 0;
            long bestLenght = 1;
            long currentPosition = 0;
            long currentLenght = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestPosition = currentPosition;
                    }
                }
                else
                {
                    currentPosition = i;
                    currentLenght = 1;
                }
            }
            

            for (long i = bestPosition; i < bestPosition + bestLenght; i++)
            {
                Console.Write((input[i]) + " ");
            }
            
            Console.WriteLine();
        }
    }
}
