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
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            Console.WriteLine(MultiplyNumbers(num1, num2).ToString().TrimStart('0'));
        }

        static StringBuilder MultiplyNumbers(string num1, int secondNum)
        {
            StringBuilder result = new StringBuilder();
            int transfer = 0;
            
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int firstNum = int.Parse(num1[i].ToString());
                int tempResult = firstNum * secondNum;
                if (transfer > 0)
                {
                    tempResult += transfer;
                }
                if (tempResult < 10)
                {
                    result.Insert(0, tempResult.ToString());
                    transfer = 0;
                }
                else
                {
                    transfer = tempResult / 10;
                    tempResult %= 10;
                    result.Insert(0, tempResult.ToString());
                }
            }
            if (transfer > 0)
            {
                result.Insert(0, transfer);
            }

            return result;
        }
    }
}
