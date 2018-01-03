using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static int SumOfEvenDigits(int num)
        {
            int finalSum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2== 0)
                {
                    finalSum += currentNum;
                }
                num /= 10;
            }
            return finalSum;
        }

        static int SumOfOddDigits(int num)
        {
            int finalSum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2 != 0)
                {
                    finalSum += currentNum;
                }
                num /= 10;
            }
            return finalSum;
        }

        static int MultiplySumsOfEvenAndOddDigits (int num)
        {
            int sumEvens = SumOfEvenDigits(num);
            int sumOdds = SumOfOddDigits(num);
            return sumEvens * sumOdds;
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplySumsOfEvenAndOddDigits(input));
        }
    }
}
