using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string calcType = Console.ReadLine();
            double output = 0.0;
            switch (calcType)
            {
                case "face":
                    output = CalculateFace(a);
                    break;
                case "space":
                    output = CalculateSpace(a);
                    break;
                case "volume":
                    output = CalculateVolume(a);
                    break;
                case "area":
                    output = CalculateArea(a);
                    break;
            }
            Console.WriteLine($"{output:f2}");
        }
        
        static double CalculateFace(double a)
        {
            return (Math.Sqrt(2 * a * a));
        }
        static double CalculateSpace (double a)
        {
            return (Math.Sqrt(3 * a * a));
        }
        static double CalculateVolume (double a)
        {
            return (a * a * a);
        }
        static double CalculateArea (double a)
        {
            return (6 * a * a);
        }
    }
}
