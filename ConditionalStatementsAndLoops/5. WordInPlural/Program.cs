using System;

namespace _5._WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string verb = Console.ReadLine();
            verb = verb.ToLower();
            int indexToRemove = verb.Length;

            if (verb.EndsWith("y"))
            {
                verb = verb.Remove(indexToRemove - 1);
                verb += "ies";
            }

            else if (verb.EndsWith("o") || verb.EndsWith("s") || verb.EndsWith("x") || verb.EndsWith("z") || verb.EndsWith("ch") || verb.EndsWith("sh"))

            {
                verb += "es";

            }

            else

            {
                verb += "s";
            }

            Console.WriteLine(verb);
        }
    }
}
