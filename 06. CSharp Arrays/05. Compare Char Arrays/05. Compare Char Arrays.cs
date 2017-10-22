using System;
using System.Linq;


namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstString = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondString = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array1 = firstString;
            char[] array2 = secondString;
            
            for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
            {
                if (firstString[i] < secondString[i])
                {
                    break;
                }
                else if (firstString[i] > secondString[i])
                {
                    array1 = secondString;
                    array2 = firstString;
                    break;
                }
                else
                {
                    if (firstString.Length > secondString.Length)
                    {
                        array1 = secondString;
                        array2 = firstString;
                    }
                }
            }
            Console.WriteLine(string.Join("", array1));
            Console.WriteLine(string.Join("", array2));

        }
    }
}