using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string pattern = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
			MatchCollection matches = Regex.Matches(text, pattern);
			List<string> words = new List<string>();

			if (matches.Count == 0)
				Console.WriteLine("No word pairs found!");
			else
				Console.WriteLine($"{matches.Count} word pairs found!");

				foreach (Match match in matches)
				{
					string firstWord = match.Groups["first"].Value;
					char[] second = match.Groups["second"].Value.ToCharArray();
					char[] reverseWord = second.Reverse().ToArray();
					string secondWord = string.Join("", reverseWord);

					if (firstWord == secondWord)
					{
						words.Add($"{firstWord} <=> {string.Join("", second)}");
					}
				}
			


			if (words.Count == 0)
			{
				Console.WriteLine($"No mirror words!");
			}
			else
			{
				Console.WriteLine($"The mirror words are:");
				Console.WriteLine(string.Join(", ", words));
			}

		}
	}
}
