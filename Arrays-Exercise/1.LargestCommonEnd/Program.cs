using System;

namespace _1.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArrayOfWords = Console.ReadLine().Split(" ");
            string[] secondArrayOfWords = Console.ReadLine().Split(" ");
            int minLength = Math.Min(firstArrayOfWords.Length, secondArrayOfWords.Length);
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < minLength; i++)
            {

                if (firstArrayOfWords[i] == secondArrayOfWords[i])
                {
                    count++;
                }
            }
            for (int j = 0; j < minLength; j++)
            {
                if (firstArrayOfWords[firstArrayOfWords.Length - 1 - j] == secondArrayOfWords[secondArrayOfWords.Length - 1 - j])
                {
                    count1++;
                }
            }
            int maxCount = Math.Max(count, count1);
            Console.WriteLine(maxCount);
        }
    }
}
