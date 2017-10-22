using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputArgs = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (inputArgs[0] == "A")
                {
                    if (phonebook.ContainsKey(inputArgs[1]))
                    {
                        phonebook[inputArgs[1]] = inputArgs[2];
                    }
                    else
                    {
                        phonebook.Add(inputArgs[1], inputArgs[2]);
                    }
                }
                else if (inputArgs[0] == "S")
                {
                    string name = inputArgs[1];
                    bool itemFound = phonebook.ContainsKey(name);

                    if (itemFound)
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (inputArgs[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}