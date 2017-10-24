﻿using System;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random index = new Random();

            for (int i = 0; i < n; i++)
            {
                var phraseIndex = index.Next(0, phrases.Length);
                var eventIndex = index.Next(0, events.Length);
                var authorIndex = index.Next(0, authors.Length);
                var cityIndex = index.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} – {cities[cityIndex]}");
            }
            
        }
    }
}