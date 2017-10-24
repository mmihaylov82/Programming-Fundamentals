using System;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i < n; i++)
            {
                if (CheckIfSymmetric(i) && CheckIfSumsOfDigitsDivisibleBy7(i) && CheckIfAtLeastOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckIfAtLeastOneEvenDigit(int numberToCheck)
        {
            while (numberToCheck > 0)
            {
                if (numberToCheck % 2 == 0)
                {
                    return true;
                }
                numberToCheck /= 10;
            }
            return false;
        }

        static bool CheckIfSumsOfDigitsDivisibleBy7(int n)
        {
            int sumOfDigits = 0;
            while (n > 0)
            {
                sumOfDigits += n % 10;
                n /= 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIfSymmetric(int n)
        {
            string numberToCheck = n.ToString();
            for (int i = 0; i < numberToCheck.Length / 2; i++)
                if (numberToCheck[i] != numberToCheck[numberToCheck.Length - 1 - i])
                {
                    return false;
                }
            return true;
        }
    }
}