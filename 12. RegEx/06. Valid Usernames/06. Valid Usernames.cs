using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(
                new char[] {' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";
            Regex regex = new Regex(pattern);
            List<string> validUsernames = new List<string>();

            foreach (var item in usernames)
            {
                if (regex.IsMatch(item))
                {
                    validUsernames.Add(item);
                }
            }

            int sumMax = 0;
            string first = String.Empty;
            string second = String.Empty;

            for (int i = 1; i < validUsernames.Count; i++)
            {
                int currentSum = validUsernames[i - 1].Length + validUsernames[i].Length;
                if (currentSum > sumMax)
                {
                    sumMax = currentSum;
                    first = validUsernames[i - 1];
                    second = validUsernames[i];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
