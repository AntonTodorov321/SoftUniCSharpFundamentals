using System;
using System.Linq;

namespace _03._Substring
{
	class Program
	{
		static void Main(string[] args)
		{
			string substringToRemove = Console.ReadLine();
			string text = Console.ReadLine();

			while (text.Contains(substringToRemove))
			{
				text = text.Replace(substringToRemove,string.Empty);
			}

			Console.WriteLine(text);
		}
	}
}
