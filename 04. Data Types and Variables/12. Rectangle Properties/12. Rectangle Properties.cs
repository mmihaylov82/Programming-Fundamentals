using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());

            double perimeter = 2 * rectangleWidth + 2 * rectangleHeight;
            double area = rectangleHeight * rectangleWidth;
            double diagonal = Math.Sqrt(rectangleHeight * rectangleHeight + rectangleWidth * rectangleWidth);
            
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}