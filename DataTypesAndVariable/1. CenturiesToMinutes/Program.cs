using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Century = ");
                byte century = byte.Parse(Console.ReadLine());
                ushort years = (ushort)(century * 100);
                uint days = (uint)(years * 365.2422);
                uint hours = days * 24;
                uint minutes = hours * 60;

                Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

            }
        }
    }
}
