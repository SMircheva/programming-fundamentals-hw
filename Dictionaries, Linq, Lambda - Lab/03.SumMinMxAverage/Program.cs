using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = new List<int>();

            for (int i = 0; i < n; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {input.Sum()}");
            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Max = {input.Max()}");
            Console.WriteLine($"Average = {input.Average()}");

        }
    }
}
