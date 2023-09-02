using System;

namespace _07._Water_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			const int TOTOAL_LITERS = 255;
			int totoalLitersLeft = TOTOAL_LITERS;
			int countOfPourLiters = int.Parse(Console.ReadLine());
			for (int i = 0; i < countOfPourLiters; i++)
			{
				int pourLiters = int.Parse(Console.ReadLine());
				if (totoalLitersLeft-pourLiters<0)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					totoalLitersLeft -= pourLiters;
				}
			}
			Console.WriteLine(TOTOAL_LITERS-totoalLitersLeft);
		}
	}
}
