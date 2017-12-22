using System;

namespace MilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {

            var miles = double.Parse(Console.ReadLine());

            var km = miles * 1.60934;

            Console.WriteLine($"{km:F2}");

        }
    }
}
