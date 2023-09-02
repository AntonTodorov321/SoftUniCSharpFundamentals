using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Valid_Usernames
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] usernames = Console.ReadLine().Split(", ");
			List<string> validUsernames = new List<string>();


			foreach (string username in usernames)
			{
				if (username.Length >= 3 && username.Length <= 16)
				{
					bool isValid = true;
					for (int i = 0; i < username.Length; i++)
					{
						char currentChar = username[i];

						if (!(char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
						{
							isValid = false;
							break;
						}

					}
					if (isValid)
					{
						validUsernames.Add(username);
					}
				}
			}

			Console.WriteLine(string.Join(Environment.NewLine,validUsernames));
		}
	}
}
