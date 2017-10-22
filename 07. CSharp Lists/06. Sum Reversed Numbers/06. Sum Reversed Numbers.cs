using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sumOfElements = 0;
            int reversedElement = 0;
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                reversedElement = ReverseDigits(listOfNumbers[i].ToString());
                sumOfElements += reversedElement;
            }
            Console.WriteLine(sumOfElements);
        }

        static int ReverseDigits(string a)
        {
            string reversed = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                reversed += a[i].ToString();
            }
            return int.Parse(reversed);
        }
    }
}