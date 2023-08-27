using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] commands = Console.ReadLine().Split();
			while (commands[0] != "end")
			{
				switch (commands[0])
				{
					case "swap":
						SwapIndex(int.Parse(commands[1]), int.Parse(commands[2]), numbers);
						break;
					case "multiply":
						Miltiply(int.Parse(commands[1]), int.Parse(commands[2]), numbers);
						break;
					case "decrease":
						for (int i = 0; i < numbers.Count; i++)
						{
							numbers[i]--;
						}
						break;
				}
				commands = Console.ReadLine().Split();

			}
			Console.WriteLine(string.Join(", ", numbers));
		}

		private static void Miltiply(int firstIndex, int secondIndex, List<int> numbers) =>
			numbers[firstIndex] *= numbers[secondIndex];

		static void SwapIndex(int firstIndex, int secondIndex, List<int> numbers)
		{
			int swap = numbers[firstIndex];
			numbers[firstIndex] = numbers[secondIndex];
			numbers[secondIndex] = swap;
		}
	}
}
