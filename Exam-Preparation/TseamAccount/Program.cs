using System;
using System.Collections.Generic;
using System.Text;

namespace TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // You may receive the following commands:
            //•	Install { game}
            //•	Uninstall { game}
            //•	Update { game}
            //•	Expansion { game}-{ expansion}

            string line = string.Empty;
            int count = 0;
            List<string> result = new List<string>();

            while ((line = Console.ReadLine()) != "Play!")
            {
                count++;
                string[] tokens = line.Split();
                //The first line is the account
                if (count == 1)
                {
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        result.Add(tokens[i]);
                    }
                }

                else
                {
                    //If you receive Install command, you should add the game at last position in the account, but only if it isn`t installed already.
                    string command = tokens[0];
                    string game = tokens[1];
                    if (command == "Install")
                    {
                        result.Add(game);
                    }

                    //If you receive Uninstall command, delete the game if it exists.
                    else if (command == "Uninstall")
                    {
                        if (result.Contains(game))
                        {
                            int startIndex = result.IndexOf(game);
                            result.RemoveAt(startIndex);
                        }
                    }

                    //If you receive Update command, you should update the game if it exists and place it on last position.
                    else if (command == "Update")
                    {
                        if (result.Contains(game))
                        {
                            int startIndex = result.IndexOf(game);
                            result.RemoveAt(startIndex);
                            result.Add(game);
                        }
                    }
                    //If you receive Expansion command, you should check if the game exists and insert after it the expansion in the following format: "{game}:{expansion}";
                    else if (command == "Expansion")
                    {
                        string[] gameAndExpansion = game.Split("-".ToCharArray());
                        string gameBeforeExpansion = gameAndExpansion[0];
                        string expansion = gameAndExpansion[1];
                        if (result.Contains(gameBeforeExpansion))
                        {
                            int startIndex = result.IndexOf(gameBeforeExpansion);
                            string newFormatGame = gameBeforeExpansion + ":" + expansion;
                            result.Insert(startIndex + 1, newFormatGame);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
