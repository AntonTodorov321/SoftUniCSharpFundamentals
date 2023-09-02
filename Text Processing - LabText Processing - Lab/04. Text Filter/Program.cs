using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] bannedWords = Console.ReadLine().Split(", ");
			string text = Console.ReadLine();

			foreach (var word in bannedWords)
			{
				string replaseWithAsterics = new string('*', word.Length);
				text=text.Replace(word,replaseWithAsterics);
			}

			Console.WriteLine(text);
		}
	}
}
