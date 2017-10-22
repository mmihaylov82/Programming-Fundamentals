using System;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggestNumber = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
            
            Console.WriteLine(biggestNumber);
        }
        static int GetMax(int num1, int num2)
        {
            int biggerNumber = 0;
            if (num1 >= num2)
            {
                biggerNumber = num1;
            }
            else
            {
                biggerNumber = num2;
            }
            return biggerNumber;
        }
    }
}