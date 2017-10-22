using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var command = Console.ReadLine();

            while (command != "print")
            {
                var commandArray = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string operand = commandArray[0];

                if (operand == "add")
                {
                    numbers.Insert(int.Parse(commandArray[1]), int.Parse(commandArray[2]));
                }
                else if (operand == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandArray[1]), commandArray.Skip(2).Select(int.Parse).ToArray());
                }
                else if (operand == "contains")
                {
                    int number = int.Parse(commandArray[1]);
                    Console.WriteLine(numbers.IndexOf(number));
                }
                else if (operand == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArray[1]));
                }
                else if (operand == "shift")
                {
                    int number = int.Parse(commandArray[1]);
                    number = number % numbers.Count;
                    var shiftedElements = numbers.Take(number).ToList();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(shiftedElements);
                }
                else if (operand == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}