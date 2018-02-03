using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (CalculateLenght(x1, y1, x2, y2) >= CalculateLenght(x3, y3, x4, y4) )
            {
                if (FindDistance(x1, y1) <= FindDistance(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (FindDistance(x3, y3) <= FindDistance(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double FindDistance(double a, double b)
        {

            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
        static double CalculateLenght(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double lenght = Math.Sqrt(a * a + b * b);
            return lenght;
        }
    }
}
