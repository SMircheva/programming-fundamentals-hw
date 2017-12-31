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
            //passes the tests but I'm not sure it's the best solution

            int meters = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());


            float totalSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            float metersPerSecond = (float)(Math.Round((meters / totalSeconds), 6));

            float kilometers = (float)(meters / 1000);
            float totalHours = (float)(totalSeconds / (60 * 60));
            float kmPerHr = (float)(Math.Round(kilometers / totalHours, 5));

            float totalMiles = (float)(kilometers / 1.609);
            float milesPerHr = (float)(totalMiles / totalHours);

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kmPerHr}");
            Console.WriteLine($"{milesPerHr}");



        }
    }
}
