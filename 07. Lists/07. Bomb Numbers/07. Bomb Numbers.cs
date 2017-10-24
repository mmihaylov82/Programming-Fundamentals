using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Bomb_Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers = RemoveBombedNumbers(numbers);
            Console.WriteLine(numbers.Sum());
        }

        static List<int> RemoveBombedNumbers(List<int> numbers)
        {
            int[] bombData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNumber = bombData[0];
            int bombRange = bombData[1];
            while (numbers.IndexOf(bombNumber) != -1)
            {
                int bombIndex = numbers.IndexOf(bombNumber);
                int bombRangeStart = Math.Max(bombIndex - bombRange, 0);
                int bombRangeEnd = Math.Min(bombIndex + bombRange, numbers.Count - 1);
                numbers.RemoveRange(bombRangeStart, bombRangeEnd - bombRangeStart + 1);
            }
            return numbers;
        }
    }
}