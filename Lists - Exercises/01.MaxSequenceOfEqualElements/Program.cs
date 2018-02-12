using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int bestTop = 1;
            int bestStart = input[0];
            int currentTop = 1;
            int currentStart = input[0];

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])                
                {
                    currentTop++;
                }
                else
                {
                    if (currentTop > bestTop)
                    {
                        bestTop = currentTop;
                        bestStart = currentStart;
                    }
                    currentStart = input[i];
                    currentTop = 1;
                }
            }

            if (currentTop > bestTop)
            {
                bestTop = currentTop;
                bestStart = currentStart;
            }

            for (int i = 0; i < bestTop; i++)
            {
                Console.Write($"{bestStart} ");
            }
            Console.WriteLine();
        }
    }
}
