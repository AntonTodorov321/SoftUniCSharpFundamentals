using System;

namespace _01._Counter_Strike
{
	class Program
	{
		static void Main(string[] args)
		{
			int energy = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			int countWinBattels = 0;
			while (command != "End of battle")
			{
				int distanse = int.Parse(command);
				if (energy - distanse >= 0)
				{
					countWinBattels++;
					energy -= distanse;
				}
				else
				{
					Console.WriteLine($"Not enough energy! Game ends with {countWinBattels} won battles and {energy} energy");
					return;
				}
				if (countWinBattels % 3 == 0)
				{
					energy += countWinBattels;
				}
				command = Console.ReadLine();
			}
			Console.WriteLine($"Won battles: {countWinBattels}. Energy left: {energy}");
		}
	}
}
