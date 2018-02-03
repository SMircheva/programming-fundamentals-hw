using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void GreetByName (string firstName)
        {
            Console.WriteLine("Hello, " + firstName + "!");
        }

        static void Main(string[] args)
        {
            GreetByName(Console.ReadLine());
        }
    }
}
