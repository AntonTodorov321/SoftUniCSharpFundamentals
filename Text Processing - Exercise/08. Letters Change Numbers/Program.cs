using System;

namespace _08._Letters_Change_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
			double result = 0;

			foreach (var word in words)
			{
				char firstLetter = word[0];
				char lastLetter = word[word.Length - 1];
				double number = double.Parse(word.Substring(1, word.Length - 2));

				if (firstLetter >= 65 && firstLetter <= 90)
				{
					result += number / (firstLetter - 64);
				}
				else
				{
					result += number * (firstLetter - 96);
				}

				if (lastLetter >= 65 && lastLetter <= 90)
				{
					result -= (lastLetter - 64);
				}
				else
				{
					result += lastLetter - 96;
				}
			}
			Console.WriteLine($"{result:f2}");
		}
	}
}
