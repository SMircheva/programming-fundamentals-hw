using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefSpecialNumbers
{
    class RefSpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int speci = 0;
            
            for (int i = 1; i <= number; i++)
            {
                var sum = 0;
                var currentNum = i;
                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }
                bool isSpeacial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpeacial}");
                
            }

        }
    }
}
