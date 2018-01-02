using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfInt
{
    class Program
    {
        static void CheckSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            CheckSign(n);
        }
    }
}
