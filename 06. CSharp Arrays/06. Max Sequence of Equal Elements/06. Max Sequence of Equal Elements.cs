using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
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
                if (elements[i] == elements[currentStart])
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
        }
    }
}