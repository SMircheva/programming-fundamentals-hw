using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            bool noSames = false;
            do
            {
                int startCount = input.Count;

                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        input[i - 1] *= 2;
                        input.RemoveAt(i);
                    }
                    
                }
                if (startCount == input.Count)
                {
                    noSames = true;
                }
            }
            while (!noSames);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
