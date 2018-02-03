using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (IsPalindrome(i) && ContainsEvenDigit(i) && (SumOfDigits(i) % 7 == 0))
                {
                    Console.WriteLine(i);
                }
            }

        }
        static bool IsPalindrome(int number)
        {
            
            string numToString = number.ToString();
            bool result = true;
            if (numToString.Length == 1)
            {
                return true;
            }
            for (int i = 0; i < (numToString.Length + 1) / 2; i++)
            {
                if (numToString[i] != numToString[numToString.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
            do
            {
                sum += num % 10;
                num = num / 10;
            } while (num > 0);
            return sum;
        }
        static bool ContainsEvenDigit (int num)
        {
            bool result = false;
            do
            {
                int currentDigit = num % 10;
                num = num / 10;
                if (currentDigit % 2 == 0)
                {
                    result = true;
                    break;
                }
            } while (num > 0);

            return result;
        }

    }
}
