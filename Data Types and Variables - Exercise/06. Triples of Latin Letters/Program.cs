using System;

namespace _06._Triples_of_Latin_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			for (char i = (char)97; i < (char)(97+num); i++)
			{
				for (char ii = (char)97; ii < (char)(97 + num); ii++)
				{
					for (char iii = (char)97; iii < (char)(97 + num); iii++)
					{
						Console.WriteLine($"{i}{ii}{iii}");
					}
				}
			}
		}
	}
}
