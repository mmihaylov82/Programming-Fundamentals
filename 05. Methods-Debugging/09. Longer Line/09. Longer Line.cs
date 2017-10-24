using System;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1Length = GetLengthOfLine(x1, y1, x2, y2);
            double line2Length = GetLengthOfLine(x3, y3, x4, y4);

            if (line2Length > line1Length)
            {
                if (GetLengthOfLine(x3,y3,0,0) <= GetLengthOfLine(x4,y4,0,0))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            else
            {
                if (GetLengthOfLine(x1, y1, 0, 0) <= GetLengthOfLine(x2, y2, 0, 0))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
        }

        static double GetLengthOfLine(double x1, double y1, double x2, double y2)
        {
            var xLength = Math.Abs(x1 - x2);
            var yLength = Math.Abs(y1 - y2);
            return Math.Sqrt(xLength * xLength + yLength * yLength);
        }
        

    }
}