using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			int sum=0;
			while (numbers.Count>0)
			{
				int index = int.Parse(Console.ReadLine());
				int currentValue = 0;
				if (index<0)
				{
					numbers[0] = numbers[numbers.Count - 1];
					currentValue = numbers[0];
				}
				else if (index>numbers.Count-1)
				{
					numbers[numbers.Count - 1] = numbers[0];
					currentValue = numbers[numbers.Count - 1];
				}
				else
				{
				currentValue = numbers[index];
				numbers.RemoveAt(index);
				}
				sum += currentValue;
				for (int i = 0; i <numbers.Count; i++)
				{
					if (numbers[i]<=currentValue)
					{
						numbers[i] += currentValue;
					}
					else
					{
						numbers[i] -= currentValue;
					}
				}
			}
			Console.WriteLine(sum);
		}
	}
}
