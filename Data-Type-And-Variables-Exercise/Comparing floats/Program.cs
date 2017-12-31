using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal eps = 0.000001M;

            decimal numberOne = decimal.Parse(Console.ReadLine());
            decimal numberTwo = decimal.Parse(Console.ReadLine());

            bool isSame = Math.Abs(numberOne - numberTwo) < eps;
            Console.WriteLine(isSame);

        }
    }
}
