using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstNum = byte.Parse(Console.ReadLine());
            byte secondNum = byte.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
