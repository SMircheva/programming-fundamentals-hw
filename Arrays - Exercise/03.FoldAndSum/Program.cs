using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int quarter = input.Length / 4;
            int[] topLine = new int[quarter * 2];
            int[] bottomLine = new int[quarter * 2];
            int[] sum = new int[quarter * 2];

            for (int i = 0; i < quarter; i++)
            {
                topLine[i] = input[quarter - i - 1];
            }
            for (int i = 0; i < quarter; i++)
            {
                topLine[topLine.Length - i - 1] = input[input.Length - quarter + i];
            }

            for (int i = quarter; i < 3 * quarter; i++)
            {
                bottomLine[i - quarter] = input[i];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = topLine[i] + bottomLine[i];
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
