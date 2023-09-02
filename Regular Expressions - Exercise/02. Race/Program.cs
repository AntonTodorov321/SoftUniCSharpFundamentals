using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> participans = Console.ReadLine().Split(", ").ToList();
			Dictionary<string, int> participansAndKm = new Dictionary<string, int>();
			string patternForLetters = @"(?<name>[A-Za-z])";
			string patternForDigit = @"(?<digits>\d)";

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "end of race")
				{
					break;
				}

				MatchCollection matchesForName = Regex.Matches(input, patternForLetters);
				MatchCollection matchesForKm = Regex.Matches(input, patternForDigit);
				string currName = string.Empty;
				int currKm = 0;
				for (int i = 0; i < matchesForName.Count; i++)
				{
					currName += matchesForName[i];
				}

				for (int i = 0; i < matchesForKm.Count; i++)
				{
					currKm += int.Parse(matchesForKm[i].ToString());
				}

				if (participans.Contains(currName))
				{
					if (!participansAndKm.ContainsKey(currName))
						participansAndKm[currName] = currKm;
					else
						participansAndKm[currName] += currKm;

				}
			}

			var winners = participansAndKm.OrderByDescending(x => x.Value).Take(3);
			var firstPlayer = winners.Take(1);
			var secondPlayer = winners.Take(2).OrderBy(x => x.Value).Take(1);
			var tirdPlayer = winners.OrderBy(x => x.Value).Take(1);

			foreach (var first in firstPlayer)
			{
				Console.WriteLine($"1st place: {first.Key}");
			}
			foreach (var second in secondPlayer)
			{
				Console.WriteLine($"2nd place: {second.Key}");
			}
			foreach (var tird in tirdPlayer)
			{
				Console.WriteLine($"3rd place: {tird.Key}");
			}
		}
	}
}
