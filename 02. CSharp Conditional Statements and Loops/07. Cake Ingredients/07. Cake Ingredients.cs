using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForBake = false;
            var ingredientCounter = 0;

            while (!checkForBake)
                {
                    string ingredient = Console.ReadLine();
                    if (ingredient == "Bake!")
                    {
                        checkForBake = true;
                        Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
                        return;
                    }
                    ingredientCounter++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
        }
    }
}