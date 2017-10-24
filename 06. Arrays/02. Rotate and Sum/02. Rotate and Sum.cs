using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialString = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            
            int[] sumString = new int[initialString.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElement = initialString[initialString.Length - 1];
                for (int j = initialString.Length - 1; j > 0; j--)
                {
                    initialString[j] = initialString[j - 1];
                }
                initialString[0] = lastElement;
                for (int n = 0; n < initialString.Length; n++)
                {
                    sumString[n] += initialString[n];
                }
            }
            Console.WriteLine(String.Join(" ", sumString));
        }
    }
}