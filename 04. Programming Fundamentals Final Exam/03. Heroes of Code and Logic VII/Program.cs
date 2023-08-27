using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfHeroes = int.Parse(Console.ReadLine());
			Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

			for (int i = 0; i < numOfHeroes; i++)
			{
				string[] heroInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string heroName = heroInfo[0];
				int heroHP = int.Parse(heroInfo[1]);
				int heroMP = int.Parse(heroInfo[2]);

				heroes.Add(heroName, new List<int>());
				heroes[heroName].Add(heroHP);
				heroes[heroName].Add(heroMP);
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd == "End")
				{
					break;
				}

				string[] tokens = cmd.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
				string action = tokens[0];
				string heroName = tokens[1];

				switch (action)
				{
					case "CastSpell":
						CastSpell(heroName, int.Parse(tokens[2]), tokens[3], heroes);
						break;
					case "TakeDamage":
						TakeDamage(heroName, int.Parse(tokens[2]), tokens[3], heroes);
						break;
					case "Recharge":
						Recharge(heroName, int.Parse(tokens[2]), heroes);
						break;
					case "Heal":
						Heal(heroName, int.Parse(tokens[2]), heroes);
						break;
				}

			}

			foreach (var hero in heroes)
			{
				Console.WriteLine($"{hero.Key}");
				Console.WriteLine($"HP: {hero.Value[0]}");
				Console.WriteLine($"MP: {hero.Value[1]}");
			}
		}

		static void CastSpell(string heroName, int MP, string spellName, Dictionary<string, List<int>> heroes)
		{
			if (heroes[heroName][1] >= MP)
			{
				heroes[heroName][1] -= MP;
				Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
			}
			else
			{
				Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
			}
		}

		static void TakeDamage(string heroName, int damage, string attacker, Dictionary<string, List<int>> heroes)
		{
			heroes[heroName][0] -= damage;
			if (heroes[heroName][0] > 0)
			{
				Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
			}
			else
			{
				Console.WriteLine($"{heroName} has been killed by {attacker}!");
				heroes.Remove(heroName);
			}
		}

		static void Recharge(string heroName, int MP, Dictionary<string, List<int>> heroes)
		{
			int originalMP = heroes[heroName][1];
			heroes[heroName][1] += MP;

			if (heroes[heroName][1] > 200)
			{
				heroes[heroName][1] = 200;
			}

			Console.WriteLine($"{heroName} recharged for {heroes[heroName][1] - originalMP} MP!");
		}

		static void Heal(string heroName, int HP, Dictionary<string, List<int>> heroes)
		{
			int originalHP = heroes[heroName][0];
			heroes[heroName][0] += HP;

			if (heroes[heroName][0] > 100)
			{
				heroes[heroName][0] = 100;
			}

			Console.WriteLine($"{heroName} healed for {heroes[heroName][0] - originalHP} HP!");
		}
	}
}
