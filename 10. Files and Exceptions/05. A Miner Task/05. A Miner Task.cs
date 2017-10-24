namespace _05.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            var resources = new Dictionary<string, int>();
            var inputArray = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            var quantity = 0;
            var resource = "";
            var counter = 1;
            string input = inputArray[counter-1];

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
                input = inputArray[counter - 1];
            }
            foreach (var item in resources)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}" + Environment.NewLine);
            }
        }
    }
}
