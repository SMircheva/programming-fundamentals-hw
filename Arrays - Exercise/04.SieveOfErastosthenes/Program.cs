using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfErastosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            primes[0] = false;
            primes[1] = false;
            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                    for (int j = i + 1; j < primes.Length; j++)
                    {
                        if (j % i == 0)
                        {
                            primes[j] = false;
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
