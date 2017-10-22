using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(number));
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
    }
}