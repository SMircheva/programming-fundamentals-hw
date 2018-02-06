using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(' ').ToArray();
            string[] inputTwo = Console.ReadLine().Split(' ').ToArray();
            int counterForward = 0;
            int counterBackwards = 0;
            int minLenght = Math.Min(inputOne.Length, inputTwo.Length);

            for (int i = 0; i < minLenght; i++)
            {
                if (inputOne[i] == inputTwo[i])
                {
                    counterForward++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < minLenght; i++)
            {
                if (inputOne[inputOne.Length - i - 1] == inputTwo[inputTwo.Length - i - 1])
                {
                    counterBackwards++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(counterForward, counterBackwards));

        }
    }
}
