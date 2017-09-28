using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int numberOfCombinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += (i * j) * 3;
                    numberOfCombinations++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{numberOfCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{numberOfCombinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}