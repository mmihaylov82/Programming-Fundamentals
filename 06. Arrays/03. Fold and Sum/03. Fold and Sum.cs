using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = startArr.Length / 4;
            int temp = 0;
            int[] firstLine = new int[2 * k];
            int[] secondLine = new int[2 * k];
            int[] sumOfArrays = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                temp = startArr[i];
                firstLine[k - 1 - i] = temp;
            }
            for (int i = 0; i < k; i++)
            {
                temp = startArr[startArr.Length - i - 1];
                firstLine[k + i] = temp;
            }
            for (int i = 0; i < 2 * k; i++)
            {
                temp = startArr[i + k];
                secondLine[i] = temp;
            }
            for (int i = 0; i < 2 * k; i++)
            {
                sumOfArrays[i] += firstLine[i] + secondLine[i];
            }
            Console.WriteLine(String.Join(" ", sumOfArrays));
        }
    }
}