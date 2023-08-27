using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> topFiveInt = new List<int>();
			double sum = numbers.Sum()/numbers.Count;
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i]>sum)
				{
					topFiveInt.Add(numbers[i]);
				}
			}
			topFiveInt.Sort();
			topFiveInt.Reverse();
			if (topFiveInt.Count==0)
			{
				Console.WriteLine("No");
			}
			else if (topFiveInt.Count>5)
			{
				for (int i = 0; i < 5; i++)
				{
					Console.Write(topFiveInt[i]+" ");
				}
			}
			else
			{
				Console.WriteLine(string.Join(" ",topFiveInt));
			}
		}
	}
}
