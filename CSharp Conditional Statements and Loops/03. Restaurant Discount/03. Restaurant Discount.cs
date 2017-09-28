using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double discount = 0.0;
            int packagePrice = 0;
            string hallName = "";
            int hallPrice = 0;

            if (package == "Normal")
            {
                discount = 0.95;
                packagePrice = 500;
            }
            else if (package == "Gold")
            {
                discount = 0.9;
                packagePrice = 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.85;
                packagePrice = 1000;
            }

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                double pricePerPerson = (packagePrice + hallPrice) * discount / groupSize;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            
        }
    }
}