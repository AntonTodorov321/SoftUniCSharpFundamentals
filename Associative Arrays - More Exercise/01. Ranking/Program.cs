using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
	class Program
	{
		static void Main(string[] args)
		{

			Dictionary<string, string> contestPass = new Dictionary<string, string>();
			Dictionary<string, List<Contests>> contesters = new Dictionary<string, List<Contests>>();

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd == "end of contests")
				{
					break;
				}

				string[] tokens = cmd.Split(":");
				string contest = tokens[0];
				string password = tokens[1];
				contestPass[contest] = password;
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd == "end of submissions")
				{
					break;
				}

				string[] tokens = cmd.Split("=>");
				string contest = tokens[0];
				string password = tokens[1];
				string name = tokens[2];
				int points = int.Parse(tokens[3]);
				Contests contests = new Contests(contest, points);

				if (contestPass.ContainsKey(contest) && password == contestPass[contest])
				{
					if (!contesters.ContainsKey(name))
					{
						contesters[name] = new List<Contests>();
					}

					contesters[name].Add(contests);
				}


				if (contesters.ContainsKey(name))
				{
					var curName = contesters.First(x => x.Key == name);
					var curList = curName.Value;
					var isContains = curList.FirstOrDefault(x => x.Contest == contest);
					int currPoints = isContains.Points;
					string currName = curName.Key.ToString();
					string currContest = isContains.Contest.ToString();


					if (currPoints < points)
					{
						Contests newContest = new Contests(currContest, currPoints);
						contesters[name] = new List<Contests>();
						contesters[name].Add(contests);
					}
					else if (currPoints > points)
					{
						contesters[name].Remove(contests);
					}			
				}
			}

			var bestContester = contesters.OrderBy(x=>x.Value.Sum(x=>x.Points)).Take(1).ToString();
		}

	}

	class Contests
	{
		public Contests(string contest, int points)
		{
			Contest = contest;
			Points = points;
		}

		public string Contest { get; set; }
		public int Points { get; set; }
	}
}
