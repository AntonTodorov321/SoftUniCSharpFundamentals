using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int bombNumber = commands[0];
			int power = commands[1];
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i]==bombNumber)
				{
					int bombNumberIndex = i;
					int startIndex = Math.Max(0, bombNumberIndex - power);
					int endIndex = Math.Min(numbers.Count - 1, bombNumberIndex + power);
					RemoveBombNum(startIndex, endIndex, numbers);
				}
			}
			int sum = numbers.Sum();
			Console.WriteLine(sum);
		}

		 static void RemoveBombNum(int stratIndex, int endIndex, List<int> numbers)
		{
			for (int i = stratIndex; i <= endIndex; i++)
			{
				numbers[i] = 0;
			}
		}
	}
}
