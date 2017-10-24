using System;


namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            foreach (char letter in inputString)
                Console.WriteLine(string.Join(" -> ", letter, letter - 'a'));
        }
    }
}