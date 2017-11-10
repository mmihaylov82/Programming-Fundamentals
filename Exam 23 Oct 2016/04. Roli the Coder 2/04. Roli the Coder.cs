using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_the_Coder_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> eventsParticipants = new Dictionary<string, List<string>>();
            Dictionary<string, string> eventsIDs = new Dictionary<string, string>();

            

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var inputArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!inputArgs[1].StartsWith("#"))
                {
                    continue;
                }

                string id = inputArgs[0];
                string eventName = inputArgs[1].Substring(1, inputArgs[1].Length - 1);

                if (!eventsIDs.ContainsKey(id))
                {
                    eventsIDs.Add(id, eventName);
                    eventsParticipants[eventName] = new List<string>();
                    for (int i = 2; i < inputArgs.Length; i++)
                    {
                        if (!inputArgs[i].Contains('@'))
                        {
                            continue;
                        }
                        if (!eventsParticipants[eventName].Contains(inputArgs[i]))
                        {
                            eventsParticipants[eventName].Add(inputArgs[i]);
                        }
                    }
                }
                else
                {
                    if (eventsIDs[id] == eventName)
                    {
                        for (int i = 2; i < inputArgs.Length; i++)
                        {
                            if (!inputArgs[i].Contains('@'))
                            {
                                continue;
                            }
                            if (!eventsParticipants[eventName].Contains(inputArgs[i]))
                            {
                                eventsParticipants[eventName].Add(inputArgs[i]);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var pair in eventsParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value.Count}");

                foreach (var item in pair.Value.OrderBy(x => x))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
