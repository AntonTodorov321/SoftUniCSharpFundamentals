using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] command = Console.ReadLine().Split();
			while (command[0] != "End")
			{
				string action = command[0];
				if (action == "Add")
				{
					int numToAdd = int.Parse(command[1]);
					numbers.Add(numToAdd);
				}
				else if (action == "Insert")
				{
					int numToInsetr = int.Parse(command[1]);
					int indexToInsetr = int.Parse(command[2]);
					if (IsIndexInList(numbers, indexToInsetr))
					{
						numbers.Insert(indexToInsetr, numToInsetr);
					}
					else
					{
						Console.WriteLine("Invalid index");
					}
				}
				else if (action == "Remove")
				{
					int indexToRemove = int.Parse(command[1]);
					if (IsIndexInList(numbers, indexToRemove))
					{
						numbers.RemoveAt(indexToRemove);
					}
					else
					{
						Console.WriteLine("Invalid index");
					}
				}
				else if (command[1]=="left")
				{
					int count = int.Parse(command[2]);
					for (int i = 0; i < count; i++)
					{
						numbers.Add(numbers[0]);
						numbers.RemoveAt(0);
					}
				}
				else
				{
					int count = int.Parse(command[2]);
					for (int i = 0; i < count; i++)
					{
						numbers.Insert(0, numbers[numbers.Count - 1]);
						numbers.RemoveAt(numbers.Count - 1);
					}
				}
				command = Console.ReadLine().Split();
			}
			Console.WriteLine(string.Join(" ",numbers));
		}
		static bool IsIndexInList(List<int> numbers, int indexToInsert) => indexToInsert >= 0 && indexToInsert < numbers.Count;
	}

}

