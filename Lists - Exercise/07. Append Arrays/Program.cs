using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> numbers = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
			List<int> result = new List<int>();
			for (int i = 0; i < numbers.Count; i++)
			{
				result.AddRange(numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
			}
			Console.WriteLine(string.Join(" ",result));
		}
	}
}
