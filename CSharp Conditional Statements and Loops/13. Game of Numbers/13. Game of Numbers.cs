using System;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            var lastN = 0;
            var lastM = 0;

            int lastCombination = 0;
            int totalCombinations = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if ((i + j) == magicNumber)
                    {
                        lastCombination = i + j;
                        lastN = i;
                        lastM = j;
                        
                    }
                    totalCombinations++;
                }
            }

            if (lastCombination != 0)
            {
                Console.WriteLine($"Number found! {lastN} + {lastM} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{totalCombinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}