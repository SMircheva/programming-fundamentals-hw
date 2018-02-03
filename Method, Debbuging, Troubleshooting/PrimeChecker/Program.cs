using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());            
            Console.WriteLine(IsPrime(input));

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
