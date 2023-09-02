using System;

namespace _03._Extract_File
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] filePath = Console.ReadLine().Split(new char[] { '\\', '.'});

			Console.WriteLine($"File name: {filePath[3]}");
			Console.WriteLine($"File extension: {filePath[4]}");
		}
	}
}
