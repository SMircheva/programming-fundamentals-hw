using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointData = Console.ReadLine()
                .Split(' ');
            var firstPoint = new Point
            {
                X = int.Parse(firstPointData[0]),
                Y = int.Parse(firstPointData[1])
            };
            var secondPointData = Console.ReadLine()
                .Split(' ');
            var secondPoint = new Point
            {
                X = int.Parse(secondPointData[0]),
                Y = int.Parse(secondPointData[1])
            };

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        static double Distance(Point first, Point second)
        {
            var xDiff = first.X - second.X;
            var xPow = xDiff * xDiff;
            var yDiff = first.Y - second.Y;
            var yPow = yDiff * yDiff;

            return Math.Sqrt(xPow + yPow);
        }
        
    }

}
