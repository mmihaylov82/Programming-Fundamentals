using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main() // 83/100 in Judge
        {
            string[] keyString = Console.ReadLine().Split(
                new char[] { '|', '<', '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);

            // RegEx pattern @"([a-zA-Z]+)[<|].*[|<]([a-zA-Z]+)"
            // string firstPattern = @"([a-zA-Z]+)(?:[< | \| | \\])(?:.+)(?:[< | \| | \\])([a-zA-Z]+)"

            string startKey = keyString[0];
            string endKey = keyString[keyString.Length - 1];
            
            string inputString = Console.ReadLine();
            string pattern = $"{startKey}(.*?){endKey}";
            Regex regex = new Regex(pattern);

            var stringMatches = regex.Matches(inputString);

            List<string> Results = new List<string>();

            foreach (Match match in stringMatches)
            {
                if (match.Groups[1].Value == "")
                {
                    continue;
                }
                Results.Add(match.Groups[1].Value);
            }

            if (Results.Count == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(string.Join("", Results));
            }
        }
    }
}
