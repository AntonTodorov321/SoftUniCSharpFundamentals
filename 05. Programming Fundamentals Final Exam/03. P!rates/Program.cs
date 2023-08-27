using System;
using System.Collections.Generic;

namespace _03._P_rates
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "Sail")
				{
					break;
				}

				string[] townInfo = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
				string town = townInfo[0];
				int population = int.Parse(townInfo[1]);
				int gold = int.Parse(townInfo[2]);

				if (!towns.ContainsKey(town))
				{
					towns.Add(town, new List<int>());
					towns[town].Add(population);
					towns[town].Add(gold);

				}
				else
				{
					towns[town][0] += population;
					towns[town][1] += gold;
				}
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd == "End")
				{
					break;
				}

				string[] tokens = cmd.Split("=>", StringSplitOptions.RemoveEmptyEntries);
				string action = tokens[0];
				string town = tokens[1];

				switch (action)
				{
					case "Plunder":
						int people = int.Parse(tokens[2]);
						int goldToPlunder = int.Parse(tokens[3]);
						Plunder(town, people, goldToPlunder, towns);
						break;

					case "Prosper":
						int gold = int.Parse(tokens[2]);
						if (gold < 0)
						{
							Console.WriteLine("Gold added cannot be a negative number!");
							continue;
						}
						Prosper(town, gold, towns);
						break;
				}
			}

			if (towns.Count > 0)
			{
				Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

				foreach (var town in towns)
				{
					int population = town.Value[0];
					int gold = town.Value[1];

					Console.WriteLine($"{town.Key} -> Population: {population} citizens, Gold: {gold} kg");
				}
			}
			else
				Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
		}

		static void Plunder(string town, int people, int gold, Dictionary<string, List<int>> towns)
		{
			Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
			towns[town][0] -= people;
			towns[town][1] -= gold;

			if (towns[town][0] == 0 || towns[town][1] == 0)
			{
				Console.WriteLine($"{town} has been wiped off the map!");
				towns.Remove(town);
			}
		}

		static void Prosper(string town, int gold, Dictionary<string, List<int>> towns)
		{
			towns[town][1] += gold;
			Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {towns[town][1]} gold.");
		}
	}
}
