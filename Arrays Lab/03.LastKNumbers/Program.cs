using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;
            Console.Write(seq[0] + " ");

            for (long i = 1; i < seq.Length; i++)
            {
                long start = 0;
                if (k < i)
                {
                    start = i - k;
                }
                
                for (long j = start; j < i; j++)
                {
                    seq[i] += seq[j];
                }
                Console.Write(seq[i] + " ");
            }

           

        }
    }
}
