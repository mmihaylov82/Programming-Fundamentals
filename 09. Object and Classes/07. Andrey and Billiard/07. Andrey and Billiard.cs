using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShoppingList { get; set; }
        public double Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> menu = new Dictionary<string, double>();

            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split('-');
                menu[inputArgs[0]] = double.Parse(inputArgs[1]);
            }

            double totalBill = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of clients")
                {
                    break;
                }
                string[] customerArgs = input.Split(new char[] { '-', ',' }).ToArray();
                string name = customerArgs[0];
                string item = customerArgs[1];
                int quantity = int.Parse(customerArgs[2]);
                
                if (!menu.ContainsKey(item))
                {
                    continue;
                }
                else
                {
                    Customer customer = new Customer();
                    customer.ShoppingList = new Dictionary<string, double>();
                    customer.Name = name;
                    customer.ShoppingList.Add(item, quantity);

                    if (customers.Any(c => c.Name == name))
                    {
                        Customer existingCustomer = customers.First(c => c.Name == name);
                        if (existingCustomer.ShoppingList.ContainsKey(item))
                        {
                            existingCustomer.ShoppingList[item] += quantity;
                        }
                        else
                        {
                            existingCustomer.ShoppingList[item] = quantity;
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }

                    totalBill += quantity * menu[item];
                }
            }

            foreach (var client in customers.OrderBy(x => x.Name))
            {
                double clientBill = 0;
                Console.WriteLine(client.Name);

                foreach (var pair in client.ShoppingList)
                {
                    Console.WriteLine($"-- {pair.Key} - {pair.Value}");
                    clientBill += menu[pair.Key] * pair.Value;
                }
                Console.WriteLine($"Bill: {clientBill:F2}");
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}