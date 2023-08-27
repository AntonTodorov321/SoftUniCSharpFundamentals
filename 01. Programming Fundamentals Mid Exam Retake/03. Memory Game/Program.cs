using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			 List<string> target = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
			string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
			int turns = 0;
			while (commands[0] != "end")
			{
				turns++;
				int fistIndex = int.Parse(commands[0]);
				int secondIndex = int.Parse(commands[1]);
				if (fistIndex == secondIndex || fistIndex < 0 || fistIndex >= target.Count || secondIndex < 0 || secondIndex >= target.Count)
				{
					target.Insert(target.Count /2, $"-{turns}a");
					target.Insert(target.Count /2, $"-{turns}a");
					Console.WriteLine("Invalid input! Adding additional elements to the board");
				}
				else if (target[fistIndex]==target[secondIndex])
				{
					string numToRemove = target[fistIndex];
					Console.WriteLine($"Congrats! You have found matching elements - {target[fistIndex]}!");
					target.Remove(numToRemove);
					target.Remove(numToRemove);

				}
				else if (target[fistIndex] != target[secondIndex])
				{
					Console.WriteLine("Try again!");
				}
				if (target.Count==0)
				{
					Console.WriteLine($"You have won in {turns} turns!");
					Console.WriteLine(string.Join(" ", target));
					return;
				}
				commands= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
			}
			Console.WriteLine("Sorry you lose :(");
			Console.WriteLine(string.Join(" ",target));
		}
	}
}
