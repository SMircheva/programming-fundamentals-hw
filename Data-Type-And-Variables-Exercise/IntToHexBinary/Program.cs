using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var hexNumber = Convert.ToString(input, 16);
            hexNumber = hexNumber.ToUpper();
            var binNumber = Convert.ToString(input, 2);
            binNumber = binNumber.ToUpper();
            Console.WriteLine(hexNumber);
            Console.WriteLine(binNumber);
            
        }
    }
}
