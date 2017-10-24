using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> primesInRange = FindPrimesInRange(startNumber, endNumber);
            Console.WriteLine(string.Join(", ", primesInRange));
        }

        static List<int> FindPrimesInRange(int startNumber, int endNumber)
        {
            List<int> primes = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        static bool IsPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}