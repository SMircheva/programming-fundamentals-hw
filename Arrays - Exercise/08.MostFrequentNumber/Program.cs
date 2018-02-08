using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counters = new int[input.Length];
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counters[i]++;
                        if(counters[i] > counterMax)
                        {
                            counterMax = counters[i];
                            numberMax = input[i];
                        }
                    }
                }
            }

            Console.WriteLine(numberMax);
        }
    }
}
