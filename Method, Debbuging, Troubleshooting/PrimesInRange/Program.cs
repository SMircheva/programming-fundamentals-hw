using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());
            bool isEmpty = true;
            for (ulong i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    if (isEmpty)
                    {
                        Console.Write(i);
                        isEmpty = false;
                    }
                    else
                    {
                        Console.Write(", " + i);
                    }
                }
            }
            if (isEmpty)
            {
                Console.Write("(empty list)");
            }
            Console.WriteLine();
        }

        static bool IsPrime(ulong n)
        {
            bool result = true;

            if (n <= 1)
            {
                return false;
            }
            for (ulong i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
