using System;
using System.Collections.Generic;

namespace _03._House_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			int target = int.Parse(Console.ReadLine());
			List<string> guests = new List<string>();
			for (int i = 0; i < target; i++)
			{
				string[] command = Console.ReadLine().Split();
				string name = command[0];
				if (command[2]=="going!" && !guests.Contains(name))
				{
					guests.Add(name);
				}
				else if (command[2]== "going!" && guests.Contains(name))
				{
					Console.WriteLine($"{name} is already in the list!");
				}
				else if (command[2]=="not" && guests.Contains(name))
				{
					guests.Remove(name);
				}
				else
				{
					Console.WriteLine($"{name} is not in the list!");
				}
			}
			foreach (string name in guests)
			{
				Console.WriteLine(name);
			}
		}
	}
}
