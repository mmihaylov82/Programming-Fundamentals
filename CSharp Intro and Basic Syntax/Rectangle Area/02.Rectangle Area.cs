using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var area = width * height;
            Console.WriteLine($"{area:f2}");
        }
    }
}