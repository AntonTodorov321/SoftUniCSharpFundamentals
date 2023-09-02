using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Space_Travel
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> travelToTitan = Console.ReadLine().Split("||").ToList();
			int totoalFuel = int.Parse(Console.ReadLine());
			int totoalAmmunition = int.Parse(Console.ReadLine());
			for (int i = 0; i < travelToTitan.Count; i++)
			{
				string[] commands = travelToTitan[i].Split();
				while (commands[0] != "Titan")
				{
					int cuurInteger = int.Parse(commands[1]);
					switch (commands[0])
					{
						case "Travel":
							if (totoalFuel - cuurInteger < 0)
							{
								Console.WriteLine("Mission failed.");
								return;
							}
							totoalFuel -= cuurInteger;
							Console.WriteLine($"The spaceship travelled {cuurInteger} light-years.");
							break;
						case "Enemy":
							if (totoalAmmunition - cuurInteger >= 0)
							{
								totoalAmmunition -= cuurInteger;
								Console.WriteLine($"An enemy with {cuurInteger} armour is defeated.");
							}
							else if (cuurInteger * 2 <= totoalFuel)
							{
								totoalFuel -= cuurInteger * 2;
								Console.WriteLine($"An enemy with {cuurInteger} armour is outmaneuvered.");
							}
							else
							{
								Console.WriteLine("Mission failed.");
								return;
							}
							break;
						case "Repair":
							totoalFuel += cuurInteger;
							totoalAmmunition += cuurInteger * 2;
							Console.WriteLine($"Ammunitions added: {cuurInteger * 2}.");
							Console.WriteLine($"Fuel added: {cuurInteger}.");
							break;
					}
					break;
				}
			}
			Console.WriteLine("You have reached Titan, all passengers are safe.");
		}
	}
}
