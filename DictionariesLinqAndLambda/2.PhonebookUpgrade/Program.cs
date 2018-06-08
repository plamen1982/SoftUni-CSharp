using System;
using System.Collections.Generic;

namespace _2.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                if (line != "ListAll")
                {
                    string[] tokens = line.Split();
                    string command = tokens[0];
                    string name = tokens[1];

                    switch (command)
                    {
                        case "A":
                            if (phonebook.ContainsKey(name))
                            {
                                phonebook[name] = tokens[2];
                            }
                            else
                            {
                                phonebook.Add(name, tokens[2]);
                            }
                            break;
                        case "S":
                            if (phonebook.ContainsKey(name))
                            {
                                Console.WriteLine($"{name} -> {phonebook[name]}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {name} does not exist.");
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    foreach (var phone in phonebook)
                    {
                        Console.WriteLine($"{phone.Key} -> {phone.Value}");
                    }
                }
            }
        }
    }
}
