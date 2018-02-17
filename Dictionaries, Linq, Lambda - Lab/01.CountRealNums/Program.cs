using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;
                } else
                {
                    numbersCount[number] = 1;
                }
            }

            foreach (var kvp in numbersCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
