using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] counters = new int[1001];

            foreach (var item in input)
            {
                counters[item]++;
            }
            for (int i = 0; i < counters.Length; i++)
            {
                if(counters[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counters[i]}");
                }
            }
        }
    }
}
