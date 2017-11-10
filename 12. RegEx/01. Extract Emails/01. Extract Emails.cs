using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\s[a-zA-Z0-9][\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection mathes = regex.Matches(text);

            foreach (Match emailMatch in mathes)
            {
                Console.WriteLine(emailMatch);
            }
        }
    }
}
