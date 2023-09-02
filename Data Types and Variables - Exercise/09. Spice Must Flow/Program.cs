using System;

namespace _09._Spice_Must_Flow
{
	class Program
	{
		static void Main(string[] args)
		{
			const int MIN_YEILD = 100;
			const int SPICE_FOR_MINERS = 26;
			int totoalSpice = int.Parse(Console.ReadLine());
			int counterDays = 0;
			int totoalSpiceSum = 0;
			while (totoalSpice>=MIN_YEILD)
			{
				counterDays++;
				totoalSpiceSum += totoalSpice-SPICE_FOR_MINERS;
				totoalSpice -= 10;
				if (totoalSpice<MIN_YEILD)
				{
					totoalSpiceSum -= SPICE_FOR_MINERS;
				}

			}
			Console.WriteLine(counterDays);
			Console.WriteLine(totoalSpiceSum);

		}
	}
}
