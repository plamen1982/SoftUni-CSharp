using System;
using System.Linq;

namespace _3.SumMinMxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().ToLower().Split(new char[]
            { ". , : ; ( ) [ ] ".ToCharArray() }, 
            StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Where(el => el.Length < 5)
                .Distinct()
                .ToArray();


        }
    }
}
