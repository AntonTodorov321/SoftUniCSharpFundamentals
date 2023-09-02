using System;
using System.Text;

namespace _04._Caesar_Cipher
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			StringBuilder enctrypyText = new StringBuilder();

			for (int i = 0; i < text.Length; i++)
			{
				int currentChar = text[i];
				currentChar += 3;

				enctrypyText.Append((char)currentChar);
			}

			Console.WriteLine(enctrypyText);
		}
	}
}
