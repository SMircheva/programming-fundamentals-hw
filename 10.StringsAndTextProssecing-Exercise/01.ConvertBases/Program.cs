using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.ConvertBases
{
    class Program
    {
        public static object BigInteger { get; private set; }

        static void Main(string[] args)
        {
            string[] input = new string[2];

            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input[1]);

        }
    }
}
