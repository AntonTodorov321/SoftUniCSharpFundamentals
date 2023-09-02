using System;
using System.Collections.Generic;
using System.Text;

namespace _03._TakeSkip_Rope
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<int> numList = new List<int>();
			string text = string.Empty;
			List<int> takeList = new List<int>();
			List<int> skipList = new List<int>();
			string result = string.Empty;

			for (int i = 0; i < input.Length; i++)
			{
				char currChar = char.Parse(input[i].ToString());

				if (char.IsDigit(currChar))
					numList.Add(int.Parse(currChar.ToString()));
				else
					text += currChar;
			}

			for (int i = 0; i < numList.Count; i++)
			{
				if (i % 2 == 0)
					takeList.Add(numList[i]);
				else
					skipList.Add(numList[i]);
			}

			for (int i = 0; i < takeList.Count; i++)
			{
				int numOfCharToTake = int.Parse(takeList[i].ToString());
				int numOfCharToSkip = int.Parse(skipList[i].ToString());
				string substringToTake = string.Empty;

				if (numOfCharToTake > text.Length)
					substringToTake = text;
				else
					substringToTake = text.Substring(0, numOfCharToTake);

				result += substringToTake;

				if (numOfCharToTake >= text.Length)
					break;

					text = text.Remove(0, numOfCharToTake);
				string substringToSkip = text.Substring(0, numOfCharToSkip);
				text = text.Remove(0, numOfCharToSkip);
			}
			Console.WriteLine(result);
		}
	}
}
