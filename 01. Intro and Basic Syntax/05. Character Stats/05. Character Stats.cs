using System;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int MaxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int MaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|',health)}{new string('.',MaxHealth-health)}|");
            Console.WriteLine($"Energy: |{new string('|', energy)}{new string('.', MaxEnergy - energy)}|");
        }
    }
}