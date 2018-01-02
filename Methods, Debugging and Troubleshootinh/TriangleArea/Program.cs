using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static double CalcTriangleArea(double triangleBase, double triangleHeight)
        {
            return triangleBase * triangleHeight / 2;
        }

        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine(CalcTriangleArea(a, h));
        }
    }
}
