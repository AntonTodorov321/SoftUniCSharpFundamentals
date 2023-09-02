using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string text = Console.ReadLine();
			string concatedWord = null;
			for (int i = 0; i < numbers.Count; i++)
			{
				int index = i;
				int currnum = numbers[i];
				while (currnum > 0)
				{
					index += currnum % 10;
					currnum /= 10;
				}
				if (index > text.Length)
				{
					index %= text.Length;
				}
				concatedWord += text[index];
			}
			Console.WriteLine(concatedWord);
		}
	}
}
