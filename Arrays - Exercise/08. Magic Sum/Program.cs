using System;
using System.Linq;

namespace _08._Magic_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int magicNum = int.Parse(Console.ReadLine());
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i; j < numbers.Length-1; j++)
				{
					if (numbers[i]+numbers[j+1]==magicNum)
					{
						Console.Write($"{numbers[i]} {numbers[j+1]}");
						Console.WriteLine();
					}
				}
			}
		}
	}
}
