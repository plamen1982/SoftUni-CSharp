using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanosecunds
{
    class Program
    {
        public static object BigInteger { get; private set; }

        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            int minutes = (int)(hours * 60);
            long seconds = minutes * 60;
            long millisecond = seconds * 1000;

        }
    }
}
