using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string input = Console.ReadLine();
            var counter = 1;
            var email = "";
            var name = input;

            while (input != "stop")
            {
                if (counter % 2 == 1)
                {
                    name = input;
                    if (!phonebook.ContainsKey(input))
                    {
                        phonebook.Add(input, "");
                    }
                }
                else
                {
                    email = input;
                    phonebook[name] = email;
                }
                input = Console.ReadLine();
                counter++;
            }
            var namesToRemove = phonebook.Where(f => (f.Value.EndsWith("uk") || f.Value.EndsWith("us"))).ToArray();

            foreach (var pair in namesToRemove)
            {
                phonebook.Remove(pair.Key);
            }

            foreach (var pair in phonebook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}