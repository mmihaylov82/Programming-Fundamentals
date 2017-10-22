using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float speedMSec = (float)distanceInMeters
                            / (seconds + minutes * 60f + hours * 60f * 60f);
            float speedKmH = (float)distanceInMeters / 1000f
                            / (hours + minutes / 60f + seconds / 60f / 60f);
            float speedMPH = (float)distanceInMeters / 1609f
                            / (hours + minutes / 60f + seconds / 60f / 60f);

            Console.WriteLine($"{speedMSec}");
            Console.WriteLine($"{speedKmH}");
            Console.WriteLine($"{speedMPH}");
        }
    }
}