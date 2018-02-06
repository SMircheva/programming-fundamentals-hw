using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[initial.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                initial = Rotate(initial);
                for (int j = 0; j < initial.Length; j++)
                {
                    sum[j] += initial[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

        }

        static int[] Rotate(int[] initial)
        {
            int[] rotated = new int[initial.Length];
            int last = initial[initial.Length - 1];
            for (int i = 1; i < initial.Length; i++)
            {
                rotated[i] = initial[i - 1];
            }
            rotated[0] = last;
            return rotated;
        }

        
       
    }
}
