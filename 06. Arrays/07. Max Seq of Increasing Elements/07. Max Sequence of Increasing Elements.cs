using System;
using System.Linq;

namespace _07.Max_Seq_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxStart = 0;
            int maxLength = 1;
            int currentStart = 0;
            int currentLength = 1;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[i-1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
            }

            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                Console.Write($"{elements[i]} ");
            }
            Console.WriteLine();
        }
    }
}