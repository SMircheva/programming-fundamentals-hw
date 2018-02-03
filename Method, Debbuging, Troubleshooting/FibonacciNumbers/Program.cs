using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(Fib(n));
            }
        }

        static ulong Fib(int n)
        {
            ulong fibNum = 1;
            ulong previousNum = 1;
            ulong currentNum = 1;
            for (int i = 1; i < n; i++)
            {
                fibNum = previousNum + currentNum;
                previousNum = currentNum;
                currentNum = fibNum;
            }
            return fibNum;
        }

    }
}
