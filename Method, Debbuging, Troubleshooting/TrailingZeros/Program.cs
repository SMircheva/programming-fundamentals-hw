using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace TrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(n);
            Console.WriteLine(CountZeros(factorial));
        }
        static BigInteger Factorial(int input)
        {
            BigInteger output = 1;
            for (int i = 2; i <= input; i++)
            {
                output *= i;
            }
            return output;
        }
        static int CountZeros(BigInteger input)
        {
            int counter = 0;
            do
            {
                BigInteger currentNum = input % 10;
                if (currentNum == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                input = input / 10;
            } while (input > 0);
            return counter;
        }
    }
}
