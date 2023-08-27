using System;
using System.Collections.Generic;

namespace _01._The_Imitation_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			string decodedWord = Console.ReadLine();
			string[] command = Console.ReadLine().Split("|");
			string resultWord = null;
			List<char> lettersInWord = new List<char>();
			for (int i = 0; i < decodedWord.Length; i++)
			{
				lettersInWord.Add(decodedWord[i]);
			}
			while (command[0] != "Decode")
			{
				switch (command[0])
				{
					case "Move":
						int numOfLetterToMove = int.Parse(command[1]);
						Move(lettersInWord, numOfLetterToMove);
						break;
					case "Insert":
						Insert(int.Parse(command[1]), command[2], lettersInWord);
						break;
					case "ChangeAll":
						ChangeAll(char.Parse(command[1]), char.Parse(command[2]), lettersInWord);
						break;
				}
				command = Console.ReadLine().Split("|");
			}
			for (int i = 0; i < lettersInWord.Count; i++)
			{
				resultWord += lettersInWord[i];
			}
			Console.WriteLine($"The decrypted message is: {resultWord}");
		}

		static void ChangeAll(char changingLetter, char replasment, List<char> lettersInWord)
		{
			for (int i = 0; i < lettersInWord.Count; i++)
			{
				if (lettersInWord[i]==changingLetter)
				{
					lettersInWord.RemoveAt(i);
					lettersInWord.Insert(i, replasment);
				}
			}
		}

		static void Insert(int index, string value, List<char> lettersInWord) => lettersInWord.InsertRange(index, value);

		static void Move(List<char> lettersInWord, int numOfLetterToMove)
		{
			for (int i = 0; i < numOfLetterToMove; i++)
			{
				lettersInWord.Add(lettersInWord[0]);
				lettersInWord.RemoveAt(0);
			}
		}
	}
}
