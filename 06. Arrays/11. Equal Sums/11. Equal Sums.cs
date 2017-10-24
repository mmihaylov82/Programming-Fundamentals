using System;
using System.Linq;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool equalSums = false;
            int equalSumsElement = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (ArraySum(inputArray, 0, i - 1) == ArraySum(inputArray, i + 1, inputArray.Length - 1))
                {
                    equalSums = true;
                    equalSumsElement = i;
                }
            }
            if (equalSums)
            {
                Console.WriteLine(equalSumsElement);
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static int ArraySum(int[] inputArray, int start, int end)
        {
            int sumOfElements = 0;
            for (int i = start; i <= end; i++)
            {
                sumOfElements += inputArray[i];
            }
            return sumOfElements;
        }
    }
}