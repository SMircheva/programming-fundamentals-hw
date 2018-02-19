using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main()
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var allPoints = new List<Point>();           

            for (int i = 0; i < numberOfPoints; i++)
            {
                var currentPoint = ReadPoint();

                allPoints.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secondMinPoint = null;


            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = i + 1; j < numberOfPoints; j++)
                {
                    var firstPoint = allPoints[i];
                    var secondPoint = allPoints[j];

                    var currentDistance = Distance(firstPoint, secondPoint);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
        }

        static Point ReadPoint()
        {
            var pointData = Console.ReadLine()
                .Split(' ');

            var point = new Point
            {
                X = int.Parse(pointData[0]),
                Y = int.Parse(pointData[1])
            };

            return point;
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
