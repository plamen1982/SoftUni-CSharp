using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.TeamWorKProjects
{
 class Team
    {
        public Team(string owner, string teamName)
        {
            Owner = owner;
            TeamName = teamName;
            TeamMembers = new List<string>();
        }

        public string Owner { get; set; }
        public string TeamName { get; set; }
        public List<string> TeamMembers { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //List<Team> -> Team -> owner, List(members)

            //Input in one for loop - creating team from user(ownder) and, one while loop - adding new member
            //Output ordered by count descending, then by name ascending

            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            //
            for (int i = 0; i < n; i++)
            {
                var split = Console.ReadLine().Split('-');
                string creator = split[0];
                string name = split[1];


                if (teams.Any(t => t.TeamName == name))
                {
                    Console.WriteLine($"Team { name} was already created!");
                    continue;
                }
                //
                if (teams.Any(t => t.Owner == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {name} has been created by {creator}!");
                teams.Add(new Team(creator, name));
            }
            //
            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] inputMembers = input.Split(new[] { '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);
                string user = inputMembers[0];
                string name = inputMembers[1];

                var currentTeam = teams.FirstOrDefault(t => t.TeamName == name);

                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {name} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Owner == user || t.TeamMembers.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {name}!");
                    continue;
                }

                currentTeam.TeamMembers.Add(user);

            }

            foreach (var team in teams
                    .Where(t => t.TeamMembers.Count > 0)
                    .OrderByDescending(x => x.TeamMembers.Count)
                    .ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Owner}");
                foreach (var member in team.TeamMembers.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");

            foreach (var team in teams
                        .Where(t => t.TeamMembers.Count == 0)
                        .Select(t => t.TeamName)
                        .OrderBy(x => x))
            {
                Console.WriteLine(team);
            }
        }
    }
}



