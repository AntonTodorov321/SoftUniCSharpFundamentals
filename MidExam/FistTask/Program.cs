using System;
using System.Collections.Generic;

namespace FistTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int daysOfAdventures = int.Parse(Console.ReadLine());
			int numOfPlayers = int.Parse(Console.ReadLine());
			double groupEnergy = double.Parse(Console.ReadLine());
			double waterPerDay = double.Parse(Console.ReadLine());
			double foodPerDay = double.Parse(Console.ReadLine());
			double totoalWater = waterPerDay * numOfPlayers * daysOfAdventures;
			double totoalFood = foodPerDay * numOfPlayers * daysOfAdventures;
			for (int i = 1; i <= daysOfAdventures; i++)
			{
				double cuurLostEnergy = double.Parse(Console.ReadLine());
				groupEnergy -= cuurLostEnergy;
				if (groupEnergy<=0)
				{
					Console.WriteLine($"You will run out of energy. You will be left with {totoalFood:f2} food and {totoalWater:f2} water.");
					return;
				}
				if (i%2==0)
				{
					groupEnergy += groupEnergy * 0.05;
					totoalWater -= totoalWater * 0.3;
				}
				if (i%3==0)
				{
					totoalFood -= totoalFood / numOfPlayers;
					groupEnergy += groupEnergy * 0.1;
				}
			}
			Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
		}
	}
}
