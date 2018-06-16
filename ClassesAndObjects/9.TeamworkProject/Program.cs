using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.TeamworkProject
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
                string[] inputTeams = Console.ReadLine().Split('-');
                string owner = inputTeams[0];
                string teamName = inputTeams[1];


                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team { teamName} was already created!");
                    continue;
                }
                //
                if (teams.Any(t => t.Owner == owner))
                {
                    Console.WriteLine($"{owner} cannot create another team!");
                    continue;
                }

                teams.Add(new Team(owner, teamName));
                Console.WriteLine($"Team {teamName} has been created by {owner}!");
            }
            //
            string line;
            while ((line = Console.ReadLine()) != "end of assignment")
            {
                string[] inputMembers = line.Split(new[] { '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);
                string member = inputMembers[0];
                string teamName = inputMembers[1];

                var currentTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(team => team.Owner == member || team.TeamMembers.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                currentTeam.TeamMembers.Add(member);

            }

            foreach (var team in teams
                    .Where(t => t.TeamMembers.Count != 0)
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

            foreach (var team in teams.Where(t => t
                        .TeamMembers.Count == 0)
                        .OrderBy(x => x))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
