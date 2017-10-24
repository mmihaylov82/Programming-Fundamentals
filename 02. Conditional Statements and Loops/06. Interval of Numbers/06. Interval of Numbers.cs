using System;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            var smallerNumber = number1;
            var largerNumber = number2;

            if (number1 > number2)
            {
                smallerNumber = number2;
                largerNumber = number1;
            }
            for (int i = smallerNumber; i <= largerNumber; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}