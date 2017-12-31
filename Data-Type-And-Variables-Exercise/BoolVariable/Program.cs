using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = bool.Parse(Console.ReadLine());

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
