using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReserse();
        }

        static void PrintReserse()
        {
            char input = (char) Console.Read();
            string reversed = "";
            string normal = "";

            while (input != '\r')
            {
                normal += input;
                reversed = input + reversed;

                input = (char)Console.Read();
            }

            Console.WriteLine(reversed);
        }

    }
}
