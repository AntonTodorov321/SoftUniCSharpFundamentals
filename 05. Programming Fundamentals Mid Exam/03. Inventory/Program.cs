using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> journy = Console.ReadLine().Split(", ").ToList();
			string[] commands = Console.ReadLine().Split(" - ");
			while (commands[0] != "Craft!")
			{
				string currItem = commands[1];
				switch (commands[0])
				{
					case "Collect":
						if (!ChekingItem(currItem, journy))
						{
							journy.Add(currItem);
						}
						break;
					case "Drop":
						if (ChekingItem(currItem, journy))
						{
							journy.Remove(currItem);
						}
						break;
					case "Combine Items":
						string[] combineItems = commands[1].Split(":");
						string oldItem = combineItems[0];
						string newItem = combineItems[1];
						int index = 0;
						if (ChekingItem(oldItem, journy))
						{
							for (int i = 0; i < journy.Count; i++)
							{
								if (journy[i]==oldItem)
								{
									index = i;
									break;
								}
							}
							journy.Insert(index+1, newItem);
						}
						break;
					case "Renew":
						string renewItem = commands[1];
						if (ChekingItem(currItem, journy))
						{
							journy.Remove(renewItem);
							journy.Add(renewItem);
						}
						break;
				}
				commands = Console.ReadLine().Split(" - ");
			}
			Console.WriteLine(string.Join(", ",journy));
			
		}

		static bool ChekingItem(string currItem, List<string> journy)
		{
			for (int i = 0; i < journy.Count; i++)
			{
				if (journy[i] == currItem)
				{
					return true;
				}
			}
			return false;
		}
	}
}
