using System;

namespace _01._Randomize_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] someText = Console.ReadLine().Split();
			Random random = new Random();
			for (int i = 0; i < someText.Length; i++)
			{
				int newIndex = random.Next(0,someText.Length);
				Console.WriteLine(someText[newIndex]);
				
			}
		}
	}
}
