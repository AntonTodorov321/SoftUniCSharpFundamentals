using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> grosery = Console.ReadLine().Split("!").ToList();
			string[] command = Console.ReadLine().Split();
			while (command[0] != "Go")
			{
				switch (command[0])
				{
					case "Urgent":
						if (!ChekingItem(command[1], grosery))
						{
							grosery.Insert(0, command[1]);
						}
						break;
					case "Unnecessary":
						if (ChekingItem(command[1], grosery))
						{
							grosery.Remove(command[1]);
						}
						break;
					case "Correct":
						int currIndex = 0;
						for (int i = 0; i < grosery.Count; i++)
						{
							if (grosery[i]==command[1])
							{
								currIndex = i;
								break;
							}
						}
						if (ChekingItem(command[1], grosery))
						{
							grosery.Remove(command[1]);
							grosery.Insert(currIndex, command[2]);
						}
						break;
					case "Rearrange":
						if (ChekingItem(command[1], grosery))
						{
							string cuurIntem = command[1];
							grosery.Remove(command[1]);
							grosery.Add(cuurIntem);
						}
						break;
				}
						command = Console.ReadLine().Split();
			}
			Console.WriteLine(string.Join(", ", grosery));
		}

		static bool ChekingItem(string item, List<string> grosery)
		{
			for (int i = 0; i < grosery.Count; i++)
			{
				if (grosery[i] == item)
				{
					return true;
				}
			}
			return false;
		}
	}
}
