using System;

namespace _6._IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int temp;
            int diff;

            if (firstInt > secondInt) {
                temp = firstInt;
                firstInt = secondInt;
                secondInt = temp;
            }
            diff = secondInt - firstInt;
            for (int i = 0; i <= diff; i++)
            {
                Console.WriteLine(firstInt);
                firstInt++;
            }
        }
    }
}
