using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhotos = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long timeForFiltering = numberOfPhotos * (long)filterTime;

            long totalTimeForFilter = numberOfPhotos * (long)filterTime;
            long goodPictures = (long)Math.Ceiling(numberOfPhotos * filterFactor / 100.0);
            long timeForUpload = goodPictures * (long)uploadTime;
            
            Console.WriteLine(TimeSpan.FromSeconds(totalTimeForFilter + timeForUpload)
                    .ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
        
    }
}