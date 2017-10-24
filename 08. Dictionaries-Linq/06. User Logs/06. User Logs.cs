using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            
            while (input != "end")
            {
                var inputStringArr = input.Split(' ').ToArray();
                var ipAddress = inputStringArr[0].Substring(3);
                var user = inputStringArr[2].Substring(5);

                //int counter = 1;

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                    userLogs[user].Add(ipAddress, 1);
                    
                }
                else
                {
                    if (!userLogs[user].ContainsKey(ipAddress))
                    {
                        userLogs[user].Add(ipAddress, 1);
                    }
                    else
                    {
                        userLogs[user][ipAddress]++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var item in user.Value)
                {
                    if (item.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{item.Key} => {item.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key} => {item.Value}.");
                    }
                }
            }
        }
    }
}