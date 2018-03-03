using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var averageLapsPerRunners = int.Parse(Console.ReadLine());
            var trackLength = long.Parse(Console.ReadLine());
            var capacity = long.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var maximumRunners = capacity * marathonDays;
            runners = Math.Min(maximumRunners, runners);

            var totalMeters = runners * averageLapsPerRunners * trackLength;
            var totalKm = totalMeters / 1000.0;

            var money = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
