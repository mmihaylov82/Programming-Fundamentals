using System;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            //220ml Nuka-Cola:
            //660kcal, 154g sugars

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(double)volume*energy/100}kcal, {(double)volume*sugar/100}g sugars ");
        }
    }
}