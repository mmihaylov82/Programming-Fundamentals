using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int pairCounter = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (Math.Abs(inputArray[i] - inputArray[j]) == difference)
                    {
                        pairCounter++;
                    }
                }
            }
            Console.WriteLine(pairCounter);
        }
    }
}