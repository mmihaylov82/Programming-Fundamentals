using System;
using System.Linq;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int lastDigit = int.Parse(number[number.Length - 1].ToString());
            Console.WriteLine(GetNameOfDigit(lastDigit));
        }
        static string GetNameOfDigit(int a)
        {
            string zeroToNine = "zero,one,two,three,four,five,six,seven,eight,nine";
            string[] digitNames = zeroToNine.Split(',').ToArray();
            for (int i = 0; i <= digitNames.Length; i++)
            {
                if (i == a)
                {
                    return digitNames[i];
                }
            }
            return string.Empty;
        }
    }
}