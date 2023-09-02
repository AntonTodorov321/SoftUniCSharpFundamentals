using System;

namespace _03._Longer_Line
{
	class Program
	{
		static void Main(string[] args)
		{
			double originalSecondX = double.Parse(Console.ReadLine());
			double originalSecondY = double.Parse(Console.ReadLine());
			double originalFirstX = double.Parse(Console.ReadLine());
			double originalFirstY = double.Parse(Console.ReadLine());

			double originalSecondXG2 = double.Parse(Console.ReadLine());
			double originalSecondYG2 = double.Parse(Console.ReadLine());
			double originalFirstXG2 = double.Parse(Console.ReadLine());
			double originalFirstYG2 = double.Parse(Console.ReadLine());

			double firstX = Math.Abs(originalFirstX);
			double firstY = Math.Abs(originalFirstY);
			double secondX = Math.Abs(originalSecondX);
			double secondY = Math.Abs(originalSecondY);

			double firstXG2 = Math.Abs(originalFirstXG2);
			double firstYG2 = Math.Abs(originalFirstYG2);
			double secondXG2 = Math.Abs(originalSecondXG2);
			double secondYG2 = Math.Abs(originalSecondYG2);

			double sum1 = firstX + firstY + secondX + secondY;
			double sum2 = firstXG2 + secondXG2 + firstYG2 + secondYG2;

			if (sum1 > sum2)
			{
				Console.WriteLine($"({originalFirstX}, {originalFirstY})({originalSecondX}, {originalSecondY})");
			}
			else
			{
				Console.WriteLine($"({originalFirstXG2}, {originalFirstYG2})({originalSecondXG2}, {originalSecondYG2})");
			}
		}
	}
}
