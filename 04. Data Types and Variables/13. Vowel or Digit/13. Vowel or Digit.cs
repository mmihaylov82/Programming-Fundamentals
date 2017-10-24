using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }
            else if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }        
        }
    }
}