using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    public class City
    {
        public double AverageTemperature { get; set; }
        public string Weather { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var dictOfCities = new Dictionary<string, City>();
            var pattern = new Regex(@"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|");

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                foreach (Match match in pattern.Matches(input))
                {
                    string name = match.Groups[1].Value;
                    var city = new City();

                    city.AverageTemperature = double.Parse(match.Groups[2].Value);
                    city.Weather = match.Groups[3].Value;
                    dictOfCities[name] = (city);
                }
            }

            var orderedCitiesByTemp = dictOfCities.OrderBy(c => c.Value.AverageTemperature);

            foreach (var city in orderedCitiesByTemp)
            {
                Console.WriteLine($"{city.Key} => {city.Value.AverageTemperature:f2} => {city.Value.Weather}");
            }
        }
    }
}
