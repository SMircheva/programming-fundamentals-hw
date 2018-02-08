using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if(input.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                int index = 0;
                bool hasSum = false;
                int leftSum = 0;
                int rightSum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += input[j];
                    }
                    for (int k = i + 1; k < input.Length; k++)
                    {
                        rightSum += input[k];
                    }
                    if (rightSum == leftSum)
                    {
                        index = i;
                        hasSum = true;
                    }
                    else
                    {
                        rightSum = 0;
                        leftSum = 0;
                    }
                    if (hasSum)
                    {
                        break;
                    }
                }

                if (hasSum)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
