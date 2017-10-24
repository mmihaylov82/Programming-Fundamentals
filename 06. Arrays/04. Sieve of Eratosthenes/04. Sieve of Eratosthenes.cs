using System;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            
            for (long i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (long i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write($"{i} ");
                    for (long j = i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}