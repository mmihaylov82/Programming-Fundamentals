using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string desiredParameter = Console.ReadLine();

            if (desiredParameter == "face")
            {
                Console.WriteLine($"{CalculateFaceDiagonal(cubeSide):f2}");
            }
            else if (desiredParameter == "space")
            {
                Console.WriteLine($"{CalculateSpaceDiagonal(cubeSide):f2}");
            }
            else if (desiredParameter == "volume")
            {
                Console.WriteLine($"{CalculateVolume(cubeSide):f2}");
            }
            else if (desiredParameter == "area")
            {
                Console.WriteLine($"{CalculateArea(cubeSide):f2}");
            }
        }

        static double CalculateFaceDiagonal(double cubeSide)
        {
            return Math.Sqrt(2 * cubeSide * cubeSide);
        }

        static double CalculateSpaceDiagonal(double cubeSide)
        {
            return Math.Sqrt(3 * cubeSide * cubeSide);
        }

        static double CalculateVolume(double cubeSide)
        {
            return cubeSide * cubeSide * cubeSide;
        }

        static double CalculateArea(double cubeSide)
        {
            return 6 * cubeSide * cubeSide;
        }
    }
}