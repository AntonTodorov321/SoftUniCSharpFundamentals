using System;

namespace _06._Calculate_Rectangle_Area
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int height = int.Parse(Console.ReadLine());
			int weight = int.Parse(Console.ReadLine());
			int sum = calculateRectangleArea(height, weight);
			Console.WriteLine(sum);
		}

		static int calculateRectangleArea(int height, int weight)=> height*weight;
	}
}
