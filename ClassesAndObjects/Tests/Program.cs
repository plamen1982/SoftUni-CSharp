using System;
using System.Globalization;

namespace Tests
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime releaseDate = DateTime.ParseExact("29.07.1954", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(releaseDate.ToString("dd.MM.yyyy"));
        }
    }
}
