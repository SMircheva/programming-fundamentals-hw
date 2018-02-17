using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            numbers = numbers
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
