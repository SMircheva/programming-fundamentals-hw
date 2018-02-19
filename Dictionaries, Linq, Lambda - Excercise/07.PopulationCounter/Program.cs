using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|').ToArray();
            string city = input[0];
            string country;
            long population = 0;
            while (city != "report")
            {
                country = input[1];
                population = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    countries.Add(country, currentCity);
                }
                else
                {
                    if(!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
                city = input[0];
            }

            foreach (var pair in countries.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}
