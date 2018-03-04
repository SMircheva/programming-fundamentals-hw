using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] currentSequence = new int[n];
            int[] bestSequence = new int[n];
            //int bestStart = 0;
            //int bestSum = 0;
            int bestDNAAindex = -1;
            int counter = 0;

            while (input != "Clone them!")
            {
                counter++;
                currentSequence = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                if(LenghtOfBestSequence(currentSequence) > LenghtOfBestSequence(bestSequence))
                {
                    bestSequence = (int[]) currentSequence.Clone();
                    bestDNAAindex = counter;
                }
                else if (indexOfBestSequence (currentSequence) < indexOfBestSequence(bestSequence))
                {
                    bestSequence = (int[])currentSequence.Clone();
                    bestDNAAindex = counter;

                }
                else if (currentSequence.Sum() > bestSequence.Sum())
                {
                    bestSequence = (int[])currentSequence.Clone();
                    bestDNAAindex = counter;

                }


                input = Console.ReadLine();                
            }

            if (bestDNAAindex == -1)
            {
                bestDNAAindex = 1;
            }
            Console.WriteLine($"Best DNA sample {bestDNAAindex} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }

        static int indexOfBestSequence(int[] sequence)
        {
            int bestSequence = 0;
            int currentSequence = 0;
            int index = -1;
            int currentIndex = 0;
            if (sequence[0] == 1)
            {
                currentSequence = 1;
            }
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] == 1)
                {
                    currentSequence++;
                    if (sequence[i-1] == 0)
                    {
                        currentIndex = i;
                    }
                }
                else
                {
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence; //int
                        index = currentIndex;
                        
                    }
                    currentSequence = 0;
                }
            }

            return index;
        }

        static int LenghtOfBestSequence (int[] sequence)
        {
            int bestSequence = 0;
            int currentSequence = 0;
            int index = -1;
            int currentIndex = 0;
            if (sequence[0] == 1)
            {
                currentSequence = 1;
            }
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] == 1)
                {
                    currentSequence++;
                    if (sequence[i - 1] == 0)
                    {
                        currentIndex = i;
                    }
                }
                else
                {
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        index = currentIndex;
                    }

                    currentSequence = 0;
                }
            }

            return bestSequence;
        }
    }
}
