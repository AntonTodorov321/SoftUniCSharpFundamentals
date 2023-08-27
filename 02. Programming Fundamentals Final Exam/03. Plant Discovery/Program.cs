using System;
using System.Collections.Generic;

namespace _03._Plant_Discovery
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfInput = int.Parse(Console.ReadLine());

			Dictionary<string, KeyValuePair<double, double>> plants = new Dictionary<string, KeyValuePair<double, double>>();

			Dictionary<string, int> counterOfRating = new Dictionary<string, int>();

			List<string> plantsNames = new List<string>();
			string[] separator = { ": ", " - " };

			for (int i = 0; i < numOfInput; i++)
			{
				string[] tokens = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
				string plantName = tokens[0];
				int rarity = int.Parse(tokens[1]);

				if (!plants.ContainsKey(plantName))
				{
					plants[plantName] = new KeyValuePair<double, double>(rarity, 0);
					plantsNames.Add(plantName);
					counterOfRating.Add(plantName, 0);
				}
				else
				{
					plants[plantName] = new KeyValuePair<double, double>(rarity, 0);
				}
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd == "Exhibition")
				{
					break;
				}

				string[] tokens = cmd.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				string action = tokens[0];
				string plantName = tokens[1];

				if (plants.ContainsKey(plantName))
				{
					KeyValuePair<double, double> plantInfo = plants[plantName];
					double currRarity = plantInfo.Key;
					double currRating = plantInfo.Value;

					switch (action)
					{
						case "Rate":
							double rating = double.Parse(tokens[2]);
							double ratingToAdd = plantInfo.Value + rating;
							plants[plantName] = new KeyValuePair<double, double>(currRarity, ratingToAdd);
							counterOfRating[plantName]++;
							break;

						case "Update":
							double newRatity = double.Parse(tokens[2]);
							plants[plantName] = new KeyValuePair<double, double>(newRatity, currRating);
							break;

						case "Reset":
							plants[plantName] = new KeyValuePair<double, double>(currRarity, 0);
							break;
					}
				}
				else
					Console.WriteLine("error");
			}

			Console.WriteLine("Plants for the exhibition:");

			foreach (var plant in plantsNames)
			{
				double avgRating = 0;
				KeyValuePair<double, double> plantInfo = plants[plant];
				double countOfAddingRating = counterOfRating[plant];

				if (countOfAddingRating > 0 && plantInfo.Value > 0)
				{
					avgRating = plantInfo.Value / countOfAddingRating;
				}

				Console.WriteLine($"- {plant}; Rarity: {plantInfo.Key}; Rating: {avgRating:f2}");
			}
		}
	}
}
