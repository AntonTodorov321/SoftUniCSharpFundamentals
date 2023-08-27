using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] commands = Console.ReadLine().Split();
			while (commands[0] != "End")
			{
				switch (commands[0])
				{
					case "Shoot":
						if (ValidationIndex(int.Parse(commands[1]), numbers))
						{
							Shoot(int.Parse(commands[1]), int.Parse(commands[2]), numbers);
						}
						break;
					case "Add":
						if (ValidationIndex(int.Parse(commands[1]), numbers))
						{
							Add(int.Parse(commands[1]), int.Parse(commands[2]), numbers);
						}
						else
						{
							Console.WriteLine("Invalid placement!");
						}
						break;
					case "Strike":
						int index = int.Parse(commands[1]);
						int radius = int.Parse(commands[2]);
						if (index-radius>=0 && index+radius<=numbers.Count-1)
						{
							Strike(index, radius, numbers);
						}
						else
						{
							Console.WriteLine("Strike missed!");
						}
						break;
				}
				commands = Console.ReadLine().Split();
			}
			Console.WriteLine(string.Join("|",numbers));
		}

		static void Strike(int index, int radius, List<int> numbers)
		{
			int startIndex = index - radius;
			int endIndex = index + radius;
			for (int i = startIndex; i <= endIndex; i++)
			{
				numbers.RemoveAt(startIndex) ;
			}
		}

		static void Add(int index, int number, List<int> numbers)=>numbers.Insert(index, number);

		static void Shoot(int index, int power, List<int> numbers)
		{
			numbers[index] -= power;
			if (numbers[index]<=0)
			{
				numbers.RemoveAt(index);
			}
		}

		static bool ValidationIndex(int index, List<int> numbers) => index >= 0 && index <= numbers.Count - 1;
	}
}
