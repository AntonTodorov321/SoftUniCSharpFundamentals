using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();
			int shootTargetCounter = 0;
			while (command != "End")
			{
				int index = int.Parse(command);
				if (index < 0 || index >= target.Count || target[index] == -1)
				{
					command = Console.ReadLine();
					continue;
				}
				shootTargetCounter++;
				int currValue = target[index];
				target[index] = -1;
				ReduceTargetAndIncrese(currValue, target);
				command = Console.ReadLine();
			}
			Console.Write($"Shot targets: {shootTargetCounter} -> ");
			Console.WriteLine(string.Join(" ", target));
		}

		static void ReduceTargetAndIncrese(int currValue, List<int> numbers)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == -1)
				{
					continue;
				}
				else if (numbers[i] > currValue)
				{
					numbers[i] -= currValue;
				}
				else
				{
					numbers[i] += currValue;
				}
			}
		}
	}
}
