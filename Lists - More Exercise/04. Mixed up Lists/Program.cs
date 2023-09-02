using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> fisrtList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> mixedList = new List<int>();
			List<int> shortesList = new List<int>();
			List<int> longestList = new List<int>();
			List<int> resultList = new List<int>();
			int startRage = 0;
			int endRage = 0;

			if (fisrtList.Count > secondList.Count)
			{
				longestList = fisrtList;
				shortesList = secondList;
			}
			else
			{
				longestList = secondList;
				shortesList = fisrtList;
			}


			for (int i = 0; i < shortesList.Count; i++)
			{
				mixedList.Add(fisrtList[0]);
				mixedList.Add(secondList[secondList.Count - 1]);
				fisrtList.RemoveAt(0);
				secondList.RemoveAt(secondList.Count - 1);
				i--;
			}

			if (fisrtList.Count == 0)
			{
				startRage = Math.Min(secondList[0], secondList[1]);
				endRage = Math.Max(secondList[0], secondList[1]);
			}
			else
			{
				startRage = Math.Min(fisrtList[0], fisrtList[1]);
				endRage = Math.Max(fisrtList[0], fisrtList[1]);
			}

			foreach (var num in mixedList)
			{
				if (num > startRage && num < endRage)
					resultList.Add(num);
			}

			Console.WriteLine(string.Join(" ", resultList.OrderBy(s=>s)));
		}
	}
}
