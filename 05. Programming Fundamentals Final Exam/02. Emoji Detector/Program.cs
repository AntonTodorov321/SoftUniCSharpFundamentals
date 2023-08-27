using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string patterForEmoji = @"([\*]{2}|[:]{2})(?<name>[A-Z][a-z]{2,})\1";
			string patternForDigit = @"\d";
			long coolThreshold = 1;

			MatchCollection mathesDigit = Regex.Matches(input, patternForDigit);
			MatchCollection matchesEmoji = Regex.Matches(input, patterForEmoji);

			foreach (Match match in mathesDigit)
			{
				coolThreshold *= int.Parse(match.Value);
			}

			Console.WriteLine($"Cool threshold: {coolThreshold}");
			Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");

			foreach (Match match in matchesEmoji)
			{
				string emojiName = match.Groups["name"].Value;
				int coolnessOfEmoji = emojiName.ToCharArray().Sum(c => c);

				if (coolnessOfEmoji>coolThreshold)
				{
					Console.WriteLine(match);
				}
			}
		}
	}
}
