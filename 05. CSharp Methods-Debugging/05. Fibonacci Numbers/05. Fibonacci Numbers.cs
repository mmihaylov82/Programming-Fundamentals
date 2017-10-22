using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            int[] fibonacciNumbers = new int[n + 1];
            fibonacciNumbers[0] = 1;
            if (n >= 1)
            {
                fibonacciNumbers[1] = 1;
            }
            for (int i = 2; i <= n; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }
            return fibonacciNumbers[n];

        }
    }
}