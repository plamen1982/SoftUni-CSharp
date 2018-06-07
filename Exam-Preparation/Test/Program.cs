using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> someString = new List<string> { "ab", "cd", "ef" };
            string someOtherString = "23";
            string someOtherString1 = "34";
            Console.WriteLine(string.Join(" ", someString));
            someString.Insert(2, someOtherString);
            someString.RemoveAt(2 + 1);
            someString.Insert(3, someOtherString1);
            Console.WriteLine(string.Join(" ", someString));

        }
    }
}
