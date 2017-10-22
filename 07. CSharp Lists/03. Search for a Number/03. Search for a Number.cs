using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var controlNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> newList = new List<int>();
            var isPresent = false;

            for (int i = 0; i < controlNumbers[0]; i++)
            {
                newList.Add(numbers[i]);
            }
            newList.Reverse();
            int n = newList.Count;
            for (int i = n - 1; i >= n - controlNumbers[1]; i--)
            {
                newList.RemoveAt(i);
            }
            foreach (var num in newList)
            {
                if (num == controlNumbers[2])
                {
                    isPresent = true;
                }
            }
            if (isPresent)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}