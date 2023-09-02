using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] word = Console.ReadLine().ToCharArray();
			Dictionary<char, int> chars = new Dictionary<char, int>();

			for (int i = 0; i < word.Length; i++)
			{
				char currLetter = word[i];
				if (currLetter == ' ')
				{
					continue;
				}
				if (!chars.ContainsKey(currLetter))
				{
					chars[currLetter] = 0;
				}
				chars[currLetter]++;
			}

			foreach (var letter in chars)
			{
				Console.WriteLine($"{letter.Key} -> {letter.Value}");
			}
		}
	}
}
