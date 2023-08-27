using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> mergingList = new List<int>();
			int maxCount = Math.Max(secondList.Count, firstList.Count);
			for (int i = 0; i < maxCount; i++)
			{
				if (firstList.Count > i)
				{
					mergingList.Add(firstList[i]);
				}
				if (secondList.Count > i)
				{
					mergingList.Add(secondList[i]);
				}

			}
			Console.WriteLine(string.Join(" ", mergingList));
		}
	}
}
