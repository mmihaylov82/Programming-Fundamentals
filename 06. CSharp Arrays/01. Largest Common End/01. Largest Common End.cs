using System;
using System.Linq;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split(' ').ToArray();
            string[] secondString = Console.ReadLine().Split(' ').ToArray();
            
            int ShortestLength = firstString.Length;
            int RightCount = 0;
            int LeftCount = 0;

            if (firstString.Length >= secondString.Length)
            {
                ShortestLength = secondString.Length;
            }
            
            for (int i = 0; i < ShortestLength; i++)
            {
                if (firstString[i] == secondString[i])
                {
                    RightCount++;
                }
                else
                {
                    break;
                }
            }

            for (int i = ShortestLength; i > 0; i--)
            {
                if (firstString[firstString.Length-1-LeftCount] == secondString[secondString.Length-1-LeftCount])
                {
                    LeftCount++;
                }
                else
                {
                    break;
                }
            }

            if (RightCount > LeftCount)
            {
                Console.WriteLine(RightCount);
            }
            else
            {
                Console.WriteLine(LeftCount);
            }
        }
    }
}