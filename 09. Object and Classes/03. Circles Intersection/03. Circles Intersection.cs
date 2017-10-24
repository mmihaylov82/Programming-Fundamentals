using System;
using System.Linq;

namespace _03.Circles_Intersection
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle(Console.ReadLine());
            Circle circle2 = ReadCircle(Console.ReadLine());
            int deltaX = circle1.Center.X - circle2.Center.X;
            int deltaY = circle1.Center.Y - circle2.Center.Y;
            double distanceBetweenCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distanceBetweenCenters > circle1.Radius + circle2.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }

        static Circle ReadCircle(string input)
        {
            int[] inputArgs = input.Split(' ').Select(int.Parse).ToArray();
            Circle circle = new Circle();
            circle.Center = new Point { X = inputArgs[0], Y = inputArgs[1] };
            circle.Radius = inputArgs[2];
            return circle;
        }
    }
}