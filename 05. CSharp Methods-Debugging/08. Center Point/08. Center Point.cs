using System;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string closestToCenter = "(" + x1 + ", " + y1 + ")";
            if (GetDistanceToCenter(x1,y1) > GetDistanceToCenter(x2,y2))
            {
                closestToCenter = "(" + x2 + ", " + y2 + ")";
            }
            Console.WriteLine(closestToCenter);
        }

        static double GetDistanceToCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}