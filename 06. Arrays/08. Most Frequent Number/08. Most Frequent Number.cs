using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int longestSequence = 1;
            int mostFrequentPosition = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                int sequenceCounter = 1;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        sequenceCounter++;
                        if (sequenceCounter > longestSequence )
                        {
                            mostFrequentPosition = i;
                            longestSequence = sequenceCounter;
                        }
                    }
                }
            }
            Console.WriteLine(elements[mostFrequentPosition]);
        }
    }
}