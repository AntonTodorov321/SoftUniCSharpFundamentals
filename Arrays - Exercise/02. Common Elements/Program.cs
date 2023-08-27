using System;

namespace _02._Common_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrOne = Console.ReadLine().Split();
			string[] arrTwo = Console.ReadLine().Split();
			foreach (string word1 in arrOne)
			{
				foreach (string word2 in arrTwo)
				{
					if (word1==word2)
					{
						Console.Write($"{word1} ");
					}
				}
			}

		}
	}
}
