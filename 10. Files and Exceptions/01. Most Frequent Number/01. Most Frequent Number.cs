using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

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
                        if (sequenceCounter > longestSequence)
                        {
                            mostFrequentPosition = i;
                            longestSequence = sequenceCounter;
                        }
                    }
                }
            }
            File.WriteAllText("output.txt", elements[mostFrequentPosition] + Environment.NewLine);
        }
    }
}
