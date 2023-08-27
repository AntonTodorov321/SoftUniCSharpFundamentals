using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] command = Console.ReadLine().Split();
			while (command[0] != "end")
			{
				switch (command[0])
				{
					case "Add":
						int numberstToAdd = int.Parse(command[1]);
						numbers.Add(numberstToAdd);
						break;
					case "Remove":
						int numberstToRemove = int.Parse(command[1]);
						numbers.Remove(numberstToRemove);
						break;
					case "RemoveAt":
						int numberstToRemoveAt = int.Parse(command[1]);
						numbers.RemoveAt(numberstToRemoveAt);
						break;
					case "Insert":
						int numberstToInsert = int.Parse(command[1]);
						int indexToInsert = int.Parse(command[2]);
						numbers.Insert(indexToInsert,numberstToInsert);
						break;
				}
						command = Console.ReadLine().Split();
			}
			Console.WriteLine(string.Join(" ",numbers));
		}
	}
}
