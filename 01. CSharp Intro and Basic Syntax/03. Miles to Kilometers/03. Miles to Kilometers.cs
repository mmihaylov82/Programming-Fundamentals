using System;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{miles*1.60934:f2}");
        }
    }
}