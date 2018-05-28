using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long timeInSecondsFilter = long.Parse(Console.ReadLine());
            long goodToUploadPercentage = long.Parse(Console.ReadLine());
            long timeToUpload = long.Parse(Console.ReadLine());

            long goodPicturesToUpload = (long)Math.Ceiling(numberOfPictures * goodToUploadPercentage / 100.0);

            long totalSeconds = numberOfPictures * timeInSecondsFilter + goodPicturesToUpload *  timeToUpload;
            //Console.WriteLine(totalSeconds);

            long remainSeconds;
            long remainSecondsAfterDays;
            long remainSecondsAfterHours;
            long days = 0;
            long hours = 0;
            long minutes = 0;

            remainSecondsAfterDays = totalSeconds % 86400;
            days = (totalSeconds - remainSecondsAfterDays) / 86400;
            remainSecondsAfterHours = (totalSeconds - 86400 * days) % 3600;
            hours = (totalSeconds - 86400 * days) / 3600;
            remainSeconds = (totalSeconds - (days * 86400) - (hours * 3600)) % 60;
            minutes = (totalSeconds - (days * 86400) - (hours * 3600)) / 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{remainSeconds:D2}");
        }
    }
}
