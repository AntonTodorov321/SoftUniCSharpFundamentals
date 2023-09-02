using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			double rightTime = 0;
			double leftTime = 0;
			int finishLine = (numbers.Count-1) / 2;
			for (int i = 0; i < finishLine; i++)
			{
				if (numbers[i]==0)
				{
					leftTime *= 0.8;
				}
				leftTime += numbers[i];
			}
			for (int i = numbers.Count-1; i > finishLine; i--)
			{
				if (numbers[i] == 0)
				{
					rightTime *= 0.8;
				}
				rightTime += numbers[i];
			}
			if (leftTime>rightTime)
			{
				Console.WriteLine($"The winner is right with total time: {Math.Round(rightTime)}");
			}
			else
			{
				Console.WriteLine($"The winner is left with total time: {Math.Round(leftTime)}");
			}
		}
	}
}
