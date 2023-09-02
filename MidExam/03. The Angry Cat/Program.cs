using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> valueNum = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
			int entryPoint = int.Parse(Console.ReadLine());
			string valueItem = Console.ReadLine();
			int leftIndex = entryPoint - 1;
			int rightIndex = entryPoint + 1;
			int rightSum = 0;
			int leftSum = 0;
			int entryPointValue = valueNum[entryPoint];
			while (leftIndex >= 0 || rightIndex < valueNum.Count)
			{
				switch (valueItem)
				{
					case "cheap":
						if (leftIndex < 0)
						{
							if (valueNum[rightIndex] < entryPointValue)
							{
								rightSum += valueNum[rightIndex];
							}
							rightIndex++;
							continue;
						}
						if (rightIndex >= valueNum.Count)
						{
							if (valueNum[leftIndex] < entryPointValue)
							{
								leftSum += valueNum[rightIndex];
							}
							leftIndex--;
							continue;
						}
						if (valueNum[rightIndex] < entryPointValue)
						{
							rightSum += valueNum[rightIndex];
						}
						if (valueNum[leftIndex] < entryPointValue)
						{
							leftSum += valueNum[leftIndex];
						}
						rightIndex++;
						leftIndex--;
						break;
					case "expensive":
						if (leftIndex < 0)
						{
							if (valueNum[rightIndex] >= entryPointValue)
							{
								rightSum += valueNum[rightIndex];
							}
							rightIndex++;
							continue;
						}
						if (rightIndex >= valueNum.Count)
						{
							if (valueNum[leftIndex] >= entryPointValue)
							{
								leftSum += valueNum[leftIndex];
							}
							leftIndex--;
							continue;
						}
						if (valueNum[rightIndex] >= entryPointValue)
						{
							rightSum += valueNum[rightIndex];
						}
						if (valueNum[leftIndex] >= entryPointValue)
						{
							leftSum += valueNum[leftIndex];
						}
						rightIndex++;
						leftIndex--;
						break;
				}
			}
			if (rightSum>leftSum)
			{
				Console.WriteLine($"Right - {rightSum}");
			}
			else
			{
				Console.WriteLine($"Left - {leftSum}");
			}
		}
	}
}
