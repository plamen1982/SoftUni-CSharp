using System;

namespace _2.ReverseАnArrayОfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[number];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine()); 
            }

            for (int i = arrayNumbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayNumbers[i]);
            }
        }
    }
}
