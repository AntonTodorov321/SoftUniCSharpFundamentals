	using System;
	using System.Collections.Generic;
	using System.Linq;

	namespace _02._Gauss__Trick
	{
		class Program
		{
			static void Main(string[] args)
			{
				List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
				List<int> guessList = new List<int>();
				int count = numbers.Count;
				for (int i = 0; i < count / 2; i++)
				{
					int guessNum = numbers[i] + numbers[numbers.Count - 1 - i];
					guessList.Add(guessNum);
				}
				if (numbers.Count % 2 != 0)
				{
					guessList.Add(numbers[numbers.Count / 2]);
				}
				Console.WriteLine(string.Join(" ", guessList));
			}
		}
	}
