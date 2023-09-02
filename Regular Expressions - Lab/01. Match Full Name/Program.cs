using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
	class Program
	{
		public static object Rexeg { get; private set; }

		static void Main(string[] args)
		{
			string names = Console.ReadLine();
			string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
			MatchCollection matches = Regex.Matches(names, pattern);

			Console.WriteLine(string.Join(" ",matches));
		}
	}
}
