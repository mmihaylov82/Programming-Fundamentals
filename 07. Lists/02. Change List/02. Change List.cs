using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputElements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    inputElements.RemoveAll(i => i == number);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    inputElements.Insert(position, element);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            if (command[0] == "Odd")
            {
                foreach (var num in inputElements)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            else if (command[0] == "Even")
            {
                foreach (var num in inputElements)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}