using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pattern = @"([A-Z]{2})([-]?[0-9]{1,3}\.[0-9]{1,2})([a-zA-Z]+)(\|)";
            List<CityWeather> forecasts = new List<CityWeather>();
            string cityAbbr = "";
            double temp = 0.0;
            string weather = "";

            while (input != "end")
            {               

                if (Regex.IsMatch(input,pattern))
                {
                    cityAbbr = Regex.Match(input, pattern).Groups[1].ToString();
                    temp = double.Parse(Regex.Match(input, pattern).Groups[2].ToString());
                    weather = Regex.Match(input, pattern).Groups[3].ToString();
                    bool cityExists = false;

                    foreach (var place in forecasts)
                    {
                        if (place.Abbr == cityAbbr)
                        {
                            place.Temperature = temp;
                            place.Weather = weather;
                            cityExists = true;
                            break;
                        }
                    }

                    if (!cityExists)
                    {
                        CityWeather currentCity = new CityWeather();
                        currentCity.Abbr = cityAbbr;
                        currentCity.Temperature = temp;
                        currentCity.Weather = weather;
                        forecasts.Add(currentCity);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var city in forecasts.OrderBy(x => x.Temperature))
            {
                Console.WriteLine($"{city.Abbr} => {city.Temperature:f2} => {city.Weather}");
            }
        }

        class CityWeather
        {
            public string Abbr { get; set; }
            public double Temperature { get; set; }
            public string Weather { get; set; }
        }
    }
}
