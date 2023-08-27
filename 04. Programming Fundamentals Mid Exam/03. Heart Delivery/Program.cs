using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();
			string[] commands = Console.ReadLine().Split();
			int cupidIndex = 0;
			int cupidLoveCounter = 0;
			while (commands[0]!= "Love!")
			{
				int jump = int.Parse(commands[1]);
				cupidIndex += jump;
				if (cupidIndex>=neighborhood.Count)
				{
					cupidIndex = 0;
				}
				if (neighborhood[cupidIndex]==0)
				{
					Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
					commands = Console.ReadLine().Split();
					continue;
				}
				neighborhood[cupidIndex] -= 2;
				if (neighborhood[cupidIndex] ==0)
				{
					Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
					cupidLoveCounter++;
				}
				commands = Console.ReadLine().Split();
			}
			Console.WriteLine($"Cupid's last position was {cupidIndex}.");
			if (neighborhood.Sum()==0)
			{
				Console.WriteLine("Mission was successful.");
			}
			else
			{
				Console.WriteLine($"Cupid has failed {neighborhood.Count-cupidLoveCounter} places.");
			}
		}
	}
}
