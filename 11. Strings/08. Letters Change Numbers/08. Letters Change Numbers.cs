using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                totalSum += CalculateSumOfChars(input[i]);
            }

            Console.WriteLine($"{totalSum:f2}");
        }

        static decimal CalculateSumOfChars(string currentString)
        {
            decimal sum = 0;
            char firstLetter = currentString.First();
            char lastLetter = currentString.Last();
            currentString = currentString.Substring(1, currentString.Length - 2);
            decimal number = decimal.Parse(currentString);
            
            if (firstLetter >= 'A' && firstLetter <= 'Z')
            {
                sum += number / (firstLetter - 64);
            }
            else if (firstLetter >= 'a' && firstLetter <= 'z')
            {
                sum += number * (firstLetter - 96);
            }

            if (lastLetter >= 'A' && lastLetter <= 'Z')
            {
                sum -= lastLetter - 64;
            }
            else if (lastLetter >= 'a' && lastLetter <= 'z')
            {
                sum += lastLetter - 96;
            }
            return sum;
        }
    }
}
