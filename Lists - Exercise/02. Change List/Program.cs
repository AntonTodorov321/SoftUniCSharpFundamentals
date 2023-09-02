using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] command = Console.ReadLine().Split();
			while (command[0]!="end")
			{
				if (command[0]=="Delete")
				{
					int numToRemove = int.Parse(command[1]);
					numbers.RemoveAll(el=>el==numToRemove);
				}
				else
				{
					int numToInsert = int.Parse(command[1]);
					int indexToInsert = int.Parse(command[2]);
					numbers.Insert(indexToInsert, numToInsert);
				}
				command = Console.ReadLine().Split();
			}
			Console.WriteLine(string.Join(" ",numbers));
		}
	}
}
