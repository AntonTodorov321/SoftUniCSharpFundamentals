using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string patter = @"(?<separator>[\/=])(?<name>[A-Z][A-Za-z]{2,})\k<separator>";
			MatchCollection matches = Regex.Matches(input, patter);
			List<string> names = new List<string>();
			int destinationPoints = 0;

			foreach (Match match in matches)
			{
				names.Add(match.Groups["name"].ToString());
				destinationPoints += int.Parse(match.Groups["name"].Length.ToString());
			}

			Console.WriteLine($"Destinations: {string.Join(", ",names)}");
			Console.WriteLine($"Travel Points: {destinationPoints}");
		}
	}
}
