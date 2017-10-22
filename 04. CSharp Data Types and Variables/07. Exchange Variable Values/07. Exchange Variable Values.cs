using System;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before: \r\na = {0}\r\nb = {1}", a, b);
            int oldb = b;
            b = a;
            a = oldb;
            Console.WriteLine("After: \r\na = {0}\r\nb = {1}", a, b);
        }
    }
}