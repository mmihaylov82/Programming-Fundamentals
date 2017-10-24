using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            Console.WriteLine((Convert.ToString(decimalNumber, 16)).ToUpper());
            Console.WriteLine(Convert.ToString(decimalNumber, 2));
        }
    }
}