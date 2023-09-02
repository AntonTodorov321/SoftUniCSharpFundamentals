using System;
using System.Text;

namespace _02._Repeat_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			StringBuilder resultWords = new StringBuilder();

			foreach (var word in words)
			{
				for (int i = 0; i < word.Length; i++)
				{
					resultWords.Append(word);
				}
			}

			Console.WriteLine(resultWords);
		}
	}
}
