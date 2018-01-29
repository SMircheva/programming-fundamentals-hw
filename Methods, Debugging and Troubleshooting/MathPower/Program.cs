using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static double NumberOnPower(double num, int power)
        {
            if (power == 1)
            {
                return num;
            }

            double finalNum = 1;
            for (int i = 0; i < power; i++)
            {
                finalNum *= num;
            }
            return finalNum;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(NumberOnPower(a, n));
        }
    }
}
