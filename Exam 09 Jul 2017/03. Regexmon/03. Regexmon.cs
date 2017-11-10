using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojoPattern = @"([a-zA-Z]+)\-([a-zA-Z]+)";
            string didiPattern = @"[^a-zA-Z\-\n]+";

            string input = Console.ReadLine();

            //Regex bojoRegex = new Regex(bojoPattern);
            //Regex didiRegex = new Regex(didiPattern);

            while (true)
            {
                Match didiMatch = Regex.Match(input, didiPattern);

                if (!didiMatch.Success)
                {
                    break;
                }

                int didiStartIndex = didiMatch.Index;
                input = input.Substring(didiStartIndex + didiMatch.Length);

                Console.WriteLine(didiMatch.Value.ToString());

                Match bojoMatch = Regex.Match(input, bojoPattern);

                if (!bojoMatch.Success)
                {
                    break;
                }

                int bojoStartIndex = bojoMatch.Index;
                input = input.Substring(bojoStartIndex + bojoMatch.Length);

                Console.WriteLine(bojoMatch.Value.ToString());
            }
        }
    }
}
