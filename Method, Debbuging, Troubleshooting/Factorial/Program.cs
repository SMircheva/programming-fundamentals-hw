using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        static BigInteger Factorial (int input)
        {
            BigInteger output = 1;
            for (int i = 2; i <= input; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
