﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries =
                new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            
            while (input != "report")
            {
                string[] parameters = input.Split('|');

                string city = parameters[0];
                string country = parameters[1];
                long pop = long.Parse(parameters[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, pop);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, pop);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}