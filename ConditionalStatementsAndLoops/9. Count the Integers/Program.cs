using System;

namespace _9._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

                try
                {
                    while (true)
                    {
                        int integerNumber = int.Parse(Console.ReadLine());
                        counter++;
                    }
                }

                catch (Exception)
                {

                    Console.WriteLine(counter);
                }
            
        }
    }
}
