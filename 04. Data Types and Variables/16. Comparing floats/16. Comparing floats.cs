using System;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001d;
   
            if (Math.Abs(firstNumber-secondNumber) >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}