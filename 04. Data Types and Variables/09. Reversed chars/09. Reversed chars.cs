using System;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = Convert.ToChar(Console.ReadLine());
            char secondLetter = Convert.ToChar(Console.ReadLine());
            char thirdLetter = Convert.ToChar(Console.ReadLine());
            char oldThirdLetter = thirdLetter;
            thirdLetter = firstLetter;
            firstLetter = oldThirdLetter;
            Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
        }
    }
}