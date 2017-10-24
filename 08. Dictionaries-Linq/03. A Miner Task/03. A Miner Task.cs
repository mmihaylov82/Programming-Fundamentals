using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            var resources = new Dictionary<string, int>();
            var input = Console.ReadLine();
            var quantity = 0;
            var resource = "";
            var counter = 1;

            while (input != "stop")
            {
                
                if (counter % 2 == 1)
                {
                    resource = input;
                    if (!resources.ContainsKey(input))
                    {
                        resources.Add(input, 0);
                    }
                }
                else
                {
                    quantity = int.Parse(input);
                    resources[resource] += quantity;
                }
                counter++;
                input = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}