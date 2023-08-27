using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> pitareShipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
			List<int> warshipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
			int maxHealth = int.Parse(Console.ReadLine());
			string[] commands = Console.ReadLine().Split();
			while (commands[0] != "Retire")
			{
				switch (commands[0])
				{
					case "Fire":
						int Fireindex = int.Parse(commands[1]);
						int firedamage = int.Parse(commands[2]);
						if (ChekingIndex(warshipStatus, Fireindex))
						{
							warshipStatus[Fireindex] -= firedamage;
						}
						else
						{
							commands = Console.ReadLine().Split();
							continue;
						}
						if (warshipStatus[Fireindex] <= 0)
						{
							Console.WriteLine("You won! The enemy ship has sunken.");
							return;
						}
						break;
					case "Defend":
						int defendStratIndex = int.Parse(commands[1]);
						int defendEndIndex = int.Parse(commands[2]);
						int defendDmg = int.Parse(commands[3]);
						if (ChekingIndex(pitareShipStatus, defendStratIndex) && ChekingIndex(pitareShipStatus, defendEndIndex))
						{
							for (int i = defendStratIndex; i <= defendEndIndex; i++)
							{
								pitareShipStatus[i] -= defendDmg;
								if (pitareShipStatus[i] <= 0)
								{
									Console.WriteLine("You lost! The pirate ship has sunken.");
									return;
								}
							}
						}
						break;
					case "Repair":
						int repairIndex = int.Parse(commands[1]);
						int health = int.Parse(commands[2]);
						if (ChekingIndex(pitareShipStatus,repairIndex))
						{
							if (pitareShipStatus[repairIndex] + health >= maxHealth)
							{
								pitareShipStatus[repairIndex] = maxHealth;
							}
							else
							{
								pitareShipStatus[repairIndex] += health;
							}
						}
						break;
					case "Status":
						int countNeedRepair = 0;
						for (int i = 0; i < pitareShipStatus.Count; i++)
						{
							if (pitareShipStatus[i]< 20 *(maxHealth/100.0))
							{
								countNeedRepair++;
							}
						}
						Console.WriteLine($"{countNeedRepair} sections need repair.");
						break;
				}
				commands = Console.ReadLine().Split();
			}
			Console.WriteLine($"Pirate ship status: {pitareShipStatus.Sum()}");
			Console.WriteLine($"Warship status: {warshipStatus.Sum()}");
		}

		private static bool ChekingIndex(List<int> warshipStatus, int index) => index >= 0 && index < warshipStatus.Count;
	}
}
