using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static double FahrenheitToCelcius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }

        static void Main(string[] args)
        {
            var degrees = FahrenheitToCelcius(double.Parse(Console.ReadLine()));
            Console.WriteLine($"{degrees:F2}");

        }
    }
}
