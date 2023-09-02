using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Nether_Realms
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @",[\s]+";
			string patternForHealth = @"[^0-9\+\-\*\/\.]";
			string patternForDmg = @"-?\d+\.?\d*";
			string patternForMyltiplyOrDivide = @"[\*\/]";
			string input = Console.ReadLine();
			string[] demons = Regex.Split(input, pattern).OrderBy(x => x).ToArray();

			for (int i = 0; i < demons.Length; i++)
			{
				string demon = demons[i];
				double health = 0;
				double dmg = 0;
				MatchCollection matchHealth = Regex.Matches(demon, patternForHealth);
				MatchCollection matchDmg = Regex.Matches(demon, patternForDmg);
				MatchCollection matchOperation = Regex.Matches(demon, patternForMyltiplyOrDivide);

				foreach (Match match in matchHealth)
				{
					char currHealth = char.Parse(match.ToString());
					health += currHealth;
				}

				foreach (Match match in matchDmg)
				{
					double currDmg = double.Parse(match.ToString());
					dmg += currDmg;
				}

				foreach (Match match in matchOperation)
				{

					char currChar = char.Parse(match.ToString());

					if (currChar == '*')
						dmg *= 2;
					else
						dmg /= 2;
				}
				Console.WriteLine($"{demon} - {health} health, {dmg:f2} damage");
			}
		}
	}
}

