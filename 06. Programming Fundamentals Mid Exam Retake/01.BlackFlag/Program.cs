using System;

namespace _01.BlackFlag
{
	class Program
	{
		static void Main(string[] args)
		{
			int daysOfPlunder = int.Parse(Console.ReadLine());
			int dailyPlunder = int.Parse(Console.ReadLine());
			int expectedPlunder = int.Parse(Console.ReadLine());
			double collectedPlunder = 0;
			for (int i = 1; i <= daysOfPlunder; i++)
			{
				collectedPlunder += dailyPlunder;
				if (i%3==0)
				{
					collectedPlunder += dailyPlunder * 0.5;
				}
				if (i % 5 == 0)
				{
					collectedPlunder *= 0.7;
				}
			}
			if (collectedPlunder>=expectedPlunder)
			{
				Console.WriteLine($"Ahoy! {collectedPlunder:f2} plunder gained.");
			}
			else
			{
				Console.WriteLine($"Collected only {(double)(collectedPlunder/expectedPlunder*100):f2}% of the plunder.");
			}
		}
	}
}
