using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> dungeonRoom= Console.ReadLine().Split("|").ToList();
			int health = 100;
			int roomCounter = 0;
			int totoalBitcoin = 0;
			for (int i = 0; i < dungeonRoom.Count; i++)
			{
				roomCounter++;
				string[] currRomm = dungeonRoom[i].Split();
				int currNum = int.Parse(currRomm[1]);
				switch (currRomm[0])
				{
					case "potion":
						if (health+currNum>=100)
						{
							Console.WriteLine($"You healed for {100-health} hp.");
							health = 100;
							Console.WriteLine($"Current health: {health} hp.");
						}
						else
						{
							health += currNum;
							Console.WriteLine($"You healed for {currNum} hp.");
							Console.WriteLine($"Current health: {health} hp.");
						}
						break;
					case "chest":
						Console.WriteLine($"You found {currNum} bitcoins.");
						totoalBitcoin += currNum;
						break;
					default:
						if (health-currNum>0)
						{
							health -= currNum;
							Console.WriteLine($"You slayed {currRomm[0]}.");
						}
						else
						{
							Console.WriteLine($"You died! Killed by {currRomm[0]}.");
							Console.WriteLine($"Best room: {roomCounter}");
							return;
						}
						break;
				}
			}
			Console.WriteLine("You've made it!");
			Console.WriteLine($"Bitcoins: {totoalBitcoin}");
			Console.WriteLine($"Health: {health}");
		}
	}
}
