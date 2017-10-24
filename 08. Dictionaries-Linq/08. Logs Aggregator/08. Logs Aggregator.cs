using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> userLogs = 
                new SortedDictionary<string, SortedDictionary<string, int>>();

            while (numberOfInputs > 0)
            {
                string input = Console.ReadLine();
                var inputLine = input.Split(' ').ToArray();
                var ip = inputLine[0];
                var userName = inputLine[1];
                int duration = int.Parse(inputLine[2]);

                if (!userLogs.ContainsKey(userName))
                {
                    userLogs.Add(userName, new SortedDictionary<string, int>());
                    userLogs[userName].Add(ip, duration);
                }
                else
                {
                    if (!userLogs[userName].ContainsKey(ip))
                    {
                        userLogs[userName].Add(ip, duration);
                    }
                    else
                    {
                        userLogs[userName][ip] += duration;
                    }
                }

                numberOfInputs--;
            }

            foreach (var user in userLogs)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");

                foreach (var ip in user.Value)
                {
                    if (ip.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{ip.Key}, ");
                    }
                    else
                    {
                        Console.Write($"{ip.Key}]");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}