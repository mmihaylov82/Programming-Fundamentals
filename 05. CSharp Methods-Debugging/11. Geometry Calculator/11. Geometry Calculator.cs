using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateTriangleArea(side,height):f2}");
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateSquareArea(side):f2}");
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateRectangleArea(width, height):f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateCircleArea(radius):f2}");
            }
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        static double CalculateTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }
    }
}