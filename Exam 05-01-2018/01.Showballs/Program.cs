using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Showballs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger bestSnow = 0;
            BigInteger bestTime = 0;
            BigInteger bestQuality = 0;
            BigInteger bestValue = 0;

            for (int i = 0; i < n; i++)
            {
                BigInteger currentSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger currentTime = BigInteger.Parse(Console.ReadLine());
                int currentQuality = int.Parse(Console.ReadLine());
                BigInteger currentValue = BigInteger.Pow(currentSnow / currentTime, currentQuality);

                if (currentValue > bestValue)
                {
                    bestValue = currentValue;
                    bestSnow = currentSnow;
                    bestTime = currentTime;
                    bestQuality = currentQuality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
