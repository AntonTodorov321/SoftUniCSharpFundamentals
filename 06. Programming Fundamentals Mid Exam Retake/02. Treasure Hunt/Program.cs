using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> lootOFChests = Console.ReadLine().Split("|").ToList();
			string[] commands = Console.ReadLine().Split();
			while (commands[0] != "Yohoho!")
			{
				switch (commands[0])
				{
					case "Loot":
						List<string> itemToLoot = new List<string>();
						for (int i = 1; i < commands.Length; i++)
						{
							itemToLoot.Add(commands[i]);
						}
						for (int i = 0; i < itemToLoot.Count; i++)
						{
							if (!ChekingItem(itemToLoot[i], lootOFChests))
							{
								lootOFChests.Insert(0, itemToLoot[i]);
							}
						}
						break;
					case "Drop":
						int index = int.Parse(commands[1]);
						if (CkeningIndex(index, lootOFChests))
						{
							string itemToDrop = lootOFChests[index];
							lootOFChests.RemoveAt(index);
							lootOFChests.Add(itemToDrop);
						}
						break;
					case "Steal":
						int countSteal = int.Parse(commands[1]);
						int originalCount = lootOFChests.Count;
						List<string> stealElement = new List<string>();
						if (countSteal >= lootOFChests.Count)
						{
							Console.WriteLine(string.Join(", ", lootOFChests));
							Console.WriteLine("Failed treasure hunt.");
							return;
						}
						for (int i = originalCount-countSteal; i < originalCount ; i++)
						{
							stealElement.Add(lootOFChests[originalCount - countSteal]);
							lootOFChests.RemoveAt(originalCount - countSteal);
						}
						Console.WriteLine(string.Join(", ",stealElement));
						break;
				}
				commands = Console.ReadLine().Split();
			}
			int sumLenght = 0;
			for (int i = 0; i < lootOFChests.Count; i++)
			{
				sumLenght += lootOFChests[i].Length;
			}
			double sum = (double)sumLenght / lootOFChests.Count; 
			Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");

		}

		static bool CkeningIndex(int index, List<string> lootOFChests) => index > 0 && index < lootOFChests.Count - 1;

		static bool ChekingItem(string currItem, List<string> lootOFChests)
		{
			for (int i = 0; i < lootOFChests.Count; i++)
			{
				if (currItem == lootOFChests[i])
				{
					return true;
				}
			}
			return false;
		}
	}
}
