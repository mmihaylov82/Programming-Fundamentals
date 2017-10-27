using System;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string wordOne = input[0];
            string wordTwo = input[1];
            bool isExchangeable = false;

            char[] arrayOne = wordOne.ToCharArray().Distinct().ToArray();
            char[] arrayTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length == arrayTwo.Length)
            {
                isExchangeable = true;
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
