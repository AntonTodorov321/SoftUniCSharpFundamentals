using System;
using System.Text;

namespace _01._Reverse_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string word = Console.ReadLine();
				StringBuilder reverseWord = new StringBuilder();
				if (word=="end")
				{
					break;
				}

				for (int i = word.Length-1; i >= 0; i--)
				{
					reverseWord.Append(word[i]);
				}
				Console.WriteLine($"{word} = {reverseWord}");
			}
		}
	}
}
