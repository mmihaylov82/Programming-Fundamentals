using System;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerCounter = 0;

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    integerCounter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(integerCounter);
                    return;
                }
            }
            
        }
    }
}