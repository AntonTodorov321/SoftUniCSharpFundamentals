using System;
using System.Text.RegularExpressions;

namespace Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"[A-Za-z0-9]*[\w+.-_]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";
			string input = Console.ReadLine();
			MatchCollection matches = Regex.Matches(input, pattern);
			foreach (Match match in matches)
			{
				Console.WriteLine(match);
			}
		}
	}
}
