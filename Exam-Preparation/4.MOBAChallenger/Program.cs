using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive several input lines in one of the following formats: - TEST - OK
            //"{player} -> {position} -> {skill}"
            //"{player} vs {player}"
            string line = string.Empty;
            Dictionary<string, Dictionary<string, long>> playersPool = new Dictionary<string, Dictionary<string, long>>();

            while ((line = Console.ReadLine()) != "Season end")
            {
                string[] tokens = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 5)
                {
                    //The player and position are strings, the given skill will be an integer number. You need to keep track of every player. - TEST - OK

                    string playerName = tokens[0];
                    string position = tokens[2];
                    int skill = int.Parse(tokens[4]);

                    //When you receive a player and his position and skill, add him to the player pool, if he isn`t present,
                    if (playersPool.ContainsKey(playerName) == false)
                    {
                        playersPool[playerName] = new Dictionary<string, long>();
                        playersPool[playerName].Add(position, skill);
                    }
                    //else add his position and skill or update his skill, only if the current position skill is lower than the new value.
                    else
                    {
                        if (playersPool[playerName].ContainsKey(position) == false)
                        {
                            playersPool[playerName].Add(position, skill);
                        }
                        else
                        {
                            playersPool[playerName][position] = Math.Max(playersPool[playerName][position], skill);
                        }
                    }
                }
                //If you receive "{player} vs {player}" and both players exist in the tier, they duel with the following rules:

                if (tokens.Length == 3)
                {
                    string playerOneName = tokens[0]; //faker tank 150
                    string playerTwoName = tokens[2];//bush tank 200
                    //Compare their positions, if they got at least one in common, the player with better total skill points wins and the other is 
                    //demoted from the tier -> remove him.
                    //If they have same total skill points, the duel is tie and they both continue in the Season
                    //If they don`t have positions in common, the duel isn`t happening and both continue in the Season.
                    string playerToRemove = string.Empty;
                    if (playersPool.ContainsKey(playerOneName) && playersPool.ContainsKey(playerTwoName))
                    {
                        foreach (var skillsOne in playersPool[playerOneName])
                        {
                            if (playersPool[playerTwoName].ContainsKey(skillsOne.Key))
                            {
                                foreach (var skillsTwo in playersPool[playerTwoName])
                                {
                                    if (skillsOne.Key == skillsTwo.Key)
                                    {
                                        if (skillsOne.Value > skillsTwo.Value)
                                        {
                                            playerToRemove = playerTwoName;
                                        }
                                        else if (skillsOne.Value < skillsTwo.Value)
                                        {
                                            playerToRemove = playerOneName;
                                        }
                                    }
                                }
                            }
                        }
                        playersPool.Remove(playerToRemove);
                    }
                }
            }
            //You should end your program when you receive the command "Season end". At that point you should print the players, ordered by total 
            //skill in desecending order, then ordered by player name in ascending order. 

            foreach (var player in playersPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                //Foreach player print their position and skill, ordered 
                //desecending by skill, then ordered by position name in ascending order.
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var item in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }

            }
        }
    }
}
