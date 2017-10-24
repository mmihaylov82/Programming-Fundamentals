using System;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string perfectDrink = "";

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

            Console.WriteLine(perfectDrink);
        }
    }
}