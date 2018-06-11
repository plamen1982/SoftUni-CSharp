using System;
using System.Collections.Generic;

namespace _4.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> persons = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (isFromUsOrUk(email))
                {
                    continue;
                }
                else
                {
                    persons[name] = email;
                }

            }

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }

        static bool isFromUsOrUk(string email)
        {
            string usOrUk = string.Empty;

            for (int i = email.Length - 2; i <= email.Length - 1; i++)
            {
                usOrUk += string.Empty + email[i];
            }
            if (usOrUk.ToLower().Equals("us") || usOrUk.ToLower().Equals("us"))
            {
                return true;
            }

            return false;
        }
    }
}
