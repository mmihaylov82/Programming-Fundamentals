using System;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int drinkQuantity = int.Parse(Console.ReadLine());

            string perfectDrink = "";
            double price = 0.0;
            double totalPrice = 0.0;

            switch (profession)
            {
                case "Athlete":
                    perfectDrink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    perfectDrink = "Coffee";
                    break;
                case "SoftUni Student":
                    perfectDrink = "Beer";
                    break;
                default:
                    perfectDrink = "Tea";
                    break;
            }

            switch (perfectDrink)
            {
                case "Water": price = 0.7; break;
                case "Coffee": price = 1.0; break;
                case "Beer": price = 1.7; break;
                default:
                    price = 1.2;
                    break;
            }

            totalPrice = price * drinkQuantity;

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}