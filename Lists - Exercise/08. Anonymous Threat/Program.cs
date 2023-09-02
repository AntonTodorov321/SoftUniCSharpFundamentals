using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> myList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
			string[] commands = Console.ReadLine().Split();
			while (commands[0] != "3:1")
			{
				int startIndex = int.Parse(commands[1]);
				int endIndex = int.Parse(commands[2]);
				if (startIndex < 0 || startIndex > myList.Count - 1)
				{
					startIndex = 0;
				}
				if (endIndex < 0 || endIndex > myList.Count - 1)
				{
					endIndex = myList.Count - 1;
				}
				if (commands[0] == "merge")
				{
					string concatedWord = "";
					for (int i = startIndex; i <= endIndex; i++)
					{
						concatedWord += myList[i];
					}
					myList.RemoveRange(startIndex, endIndex - startIndex + 1);
					myList.Insert(startIndex, concatedWord);
				}
				else
				{
					List<string> devidedWord = new List<string>();
					int partition = int.Parse(commands[2]);
					string word = myList[startIndex];
					myList.RemoveAt(startIndex);
					int parts = word.Length / partition;
					for (int i = 0; i < partition; i++)
					{
						if (i == partition - 1)
						{
							devidedWord.Add(word.Substring(i * parts));
						}
						else
						{
							devidedWord.Add(word.Substring(i * parts, parts));
						}
					}
					myList.InsertRange(startIndex, devidedWord);
				}
				commands = Console.ReadLine().Split();
			}
			Console.WriteLine(String.Join(" ", myList));
		}
	}
}
