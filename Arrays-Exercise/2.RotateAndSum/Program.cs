using System;
using System.Linq;

namespace _2.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO enter numbers of rotatations and arrays
            //one arrya for the sum

            int[] arrayOfInt = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int kTimes = int.Parse(Console.ReadLine());
        }
    }
}
