using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(n);

            Console.WriteLine(CountNumberOfTrailingZeros(factorial));
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorialOfnumber = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialOfnumber *= i;
            }
            return factorialOfnumber;
        }

        static BigInteger CountNumberOfTrailingZeros(BigInteger n)
        {
            string number = n.ToString();
            BigInteger numberOfZeros = 0;
            for (int i = number.Length-1; i >= 0; i--)
            {
                if (number[i].ToString() == "0")
                {
                    numberOfZeros++;
                }
                else
                {
                    return numberOfZeros;
                }
            }
            return numberOfZeros;
        }
    }
}