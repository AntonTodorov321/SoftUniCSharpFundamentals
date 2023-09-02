using System;

namespace _02._Center_Point
{
	class Program
	{
		static void Main(string[] args)
		{
			double originalFirstX = double.Parse(Console.ReadLine());
			double originalFirstY = double.Parse(Console.ReadLine());
			double originalSecondX = double.Parse(Console.ReadLine());
			double originalSecondY = double.Parse(Console.ReadLine());

			double firstX = Math.Abs(originalFirstX);
			double firstY = Math.Abs(originalFirstY);
			double secondX = Math.Abs(originalSecondX);
			double secondY = Math.Abs(originalSecondY);

			double sum1 = firstX + firstY;
			double sum2 = secondX + secondY;

			if (sum1<=sum2)
			{
				Console.WriteLine($"({originalFirstX}, {originalFirstY})");
			}
			else
			{
				Console.WriteLine($"({originalSecondX}, {originalSecondY})");
			}
		}
	}
}
