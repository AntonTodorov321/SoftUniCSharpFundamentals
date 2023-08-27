using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] command = Console.ReadLine().Split();
			bool isListChanged = false;
			while (command[0] != "end")
			{
				switch (command[0])
				{
					case "Add":
						int numberstToAdd = int.Parse(command[1]);
						numbers.Add(numberstToAdd);
						isListChanged = true;
						break;
					case "Remove":
						int numberstToRemove = int.Parse(command[1]);
						numbers.Remove(numberstToRemove);
						isListChanged = true;
						break;
					case "RemoveAt":
						int numberstToRemoveAt = int.Parse(command[1]);
						numbers.RemoveAt(numberstToRemoveAt);
						isListChanged = true;
						break;
					case "Insert":
						int numberstToInsert = int.Parse(command[1]);
						int indexToInsert = int.Parse(command[2]);
						numbers.Insert(indexToInsert, numberstToInsert);
						isListChanged = true;
						break;
					case "Contains":
						ChekContains(numbers, int.Parse(command[1]));
						break;
					case "PrintEven":
						PrintingEvenNum(numbers);
						break;
					case "PrintOdd":
						PrintingOddNum(numbers);
						break;
					case "GetSum":
						GetSumOfLIst(numbers);
						break;
					case "Filter":
						string condition = command[1];
						int numbersForCondition = int.Parse(command[2]);
						PrintNumWithFilter(numbers, condition, numbersForCondition);
						break;
				}
				command = Console.ReadLine().Split();
			}
			if (isListChanged)
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}

		static void PrintNumWithFilter(List<int> numbers, string condition, int numbersForCondition)
		{
			switch (condition)
			{
				case ">":
					foreach (int number in numbers)
					{
						if (number > numbersForCondition)
						{
							Console.Write(number + " ");
						}
					}
					Console.WriteLine();
					break;
				case ">=":
					foreach (int number in numbers)
					{
						if (number >= numbersForCondition)
						{
							Console.Write(number + " ");
						}
					}
					Console.WriteLine();
					break;
				case "<":
					foreach (int number in numbers)
					{
						if (number < numbersForCondition)
						{
							Console.Write(number + " ");
						}
					}
					Console.WriteLine();
					break;
				case "<=":
					foreach (int number in numbers)
					{
						if (number <= numbersForCondition)
						{
							Console.Write(number + " ");
						}
					}
					Console.WriteLine();
					break;
			}
		}
		static void GetSumOfLIst(List<int> numbers)
		{
			int sum = 0;
			foreach (int number in numbers)
			{
				sum += number;
			}
			Console.WriteLine(sum);
		}
		static void ChekContains(List<int> numbers, int numberstToContains)
		{
			if (numbers.Contains(numberstToContains))
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No such number");
			}
		}
		static void PrintingEvenNum(List<int> numbers)
		{
			foreach (int number in numbers)
			{
				if (number % 2 == 0)
				{
					Console.Write(number + " ");
				}
			}
			Console.WriteLine();
		}
		static void PrintingOddNum(List<int> numbers)
		{
			foreach (int number in numbers)
			{
				if (number % 2 != 0)
				{
					Console.Write(number + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
