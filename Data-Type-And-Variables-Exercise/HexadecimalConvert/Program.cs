using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            var hexNumber = Console.ReadLine();
            var newHexNumber = hexNumber.Substring(2);
            var baseTenNumber = Convert.ToInt32(newHexNumber, 16);
            Console.WriteLine(baseTenNumber);
        }
    }
}
