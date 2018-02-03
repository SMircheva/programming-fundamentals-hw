using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double output = CalculateArea(type);
            Console.WriteLine($"{output:f2}");
        }

        static double CalculateArea(string type)
        {
            if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                return (a * b / 2);
            }
            else if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                return (a * a);
            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                return (a * b);
            }
            else if (type == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                return (Math.PI * a * a);
            }
            else
            {
                return 0;
            }
        }
    }
}
