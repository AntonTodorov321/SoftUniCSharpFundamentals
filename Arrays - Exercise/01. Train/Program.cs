using System;

namespace _01._Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int numbersOfWagons = int.Parse(Console.ReadLine());
			int[] peoplePerWagon = new int[numbersOfWagons];
			int sum = 0;
			for (int i = 0; i < numbersOfWagons; i++)
			{
				peoplePerWagon[i] = int.Parse(Console.ReadLine());
				sum += peoplePerWagon[i];
			}
			Console.WriteLine(String.Join(" ",peoplePerWagon));
			Console.WriteLine(sum);
		}
	}
}
