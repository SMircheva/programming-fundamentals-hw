using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            Console.WriteLine(SumBigNumbers(num1, num2).ToString().TrimStart('0'));
        }

        static StringBuilder SumBigNumbers(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();
            bool transfer = false;

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num2.Length > num1.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int firstNum = int.Parse(num1[i].ToString());
                int secondNum = int.Parse(num2[i].ToString());
                int tempResult = firstNum + secondNum;
                if (transfer)
                {
                    tempResult++;
                }
                if (tempResult < 10)
                {
                    result.Insert(0, tempResult.ToString());
                    transfer = false;
                }
                else
                {
                    tempResult -= 10;
                    transfer = true;
                    result.Insert(0, tempResult.ToString());
                }
            }
            if (transfer)
            {
                result.Insert(0, '1');
            }

            return result;
        }
    }
}
