using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            //doesn't pass tests yet

            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            float metersPerSecond = meters / totalSeconds;

            float kilometers = meters / 1000;
            float totalHours = totalSeconds / (60 * 60);
            float kmPerHr = kilometers / totalHours;

            float totalMiles = (float)(kilometers / 1.609);
            float milesPerHr = (float)(totalMiles / totalHours);

            Console.WriteLine($"{Math.Round(metersPerSecond, 6)}");
            Console.WriteLine($"{Math.Round(kmPerHr, 6)}");
            Console.WriteLine($"{Math.Round(milesPerHr, 6)}");



        }
    }
}
