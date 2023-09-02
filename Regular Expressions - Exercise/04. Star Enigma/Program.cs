using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfLines = int.Parse(Console.ReadLine());
			List<string> attackedPlanet = new List<string>();
			List<string> destroyedPlanet = new List<string>();

			for (int i = 0; i < countOfLines; i++)
			{
				string encryptedMessege = Console.ReadLine();
				string patternForCount = @"[star]";
				MatchCollection matches = Regex.Matches(encryptedMessege.ToLower(), patternForCount);
				int countOfCharToRemove = matches.Count;
				string dectyptedMessege = string.Empty;

				for (int j = 0; j < encryptedMessege.Length; j++)
				{
					dectyptedMessege += (char)(encryptedMessege[j] - countOfCharToRemove);
				}

				string pattern = @"@(?<name>[A-Za-z]+)[^@\-:!>]*:(?<population>[\d]+)[^@\-:!>]*!(?<type>[AD])![^@\-:!>]*->(?<soldier>[\d]+)";

				Match match = Regex.Match(dectyptedMessege, pattern);

				if (match.Success)
				{
				char type = char.Parse(match.Groups["type"].Value);
				string planetName = match.Groups["name"].Value;
				if (type == 'A')
					attackedPlanet.Add(planetName);
				else
					destroyedPlanet.Add(planetName);
				}
			}

			Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
			attackedPlanet.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
			Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
			destroyedPlanet.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
		}
	}
}
