using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfTeams = int.Parse(Console.ReadLine());
			List<Team> teamList = new List<Team>();

			for (int i = 0; i < numOfTeams; i++)
			{
				string[] teamInfo = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
				Team team = new Team()
				{
					Members = new List<string>(),
					TeamName = teamInfo[1],
					Creator = teamInfo[0]
				};

				if (teamList.Any(x=>x.Creator==teamInfo[0]))
				{
					Console.WriteLine($"{teamInfo[0]} cannot create another team!");
					continue;
				}

				if (teamList.Any(x=>x.TeamName==teamInfo[1]))
				{
					Console.WriteLine($"Team {teamInfo[1]} was already created!");
					continue;
				}


				Console.WriteLine($"Team {teamInfo[1]} has been created by {teamInfo[0]}!");
				teamList.Add(team);
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd== "end of assignment")
				{
					break;
				}

				string[] tokens = cmd.Split("->", StringSplitOptions.RemoveEmptyEntries);
				string currMamber = tokens[0];
				string currTeamName = tokens[1];

				if (!teamList.Any(x=>x.TeamName==currTeamName))	
				{
					Console.WriteLine($"Team {currTeamName} does not exist!");
					continue;
				}

				if (teamList.Any(x=>x.Creator==currMamber) || teamList.Any(x=>x.Members.Contains(currMamber)))
				{
					Console.WriteLine($"Member {currMamber} cannot join team {currTeamName}!");
					continue;
				}

				Team team = teamList.Find(x=>x.TeamName==currTeamName);
				team.Members.Add(currMamber);
			}

			foreach (var team in teamList.Where(x=>x.Members.Count>0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
			{
				Console.WriteLine($"{team.TeamName}");
				Console.WriteLine($"- {team.Creator}");

				foreach (var member in team.Members.OrderBy(x => x))
				{
					Console.WriteLine($"-- {member}");
				}
			}

			Console.WriteLine($"Teams to disband:");

			foreach (var team in teamList.Where(x=>x.Members.Count==0).OrderBy(x => x.TeamName))
			{
				Console.WriteLine(team.TeamName);
			}
		}
	}

	class Team
	{
		public List<string> Members { get; set; }
		public string TeamName { get; set; }
		public string Creator { get; set; }
	}
}
