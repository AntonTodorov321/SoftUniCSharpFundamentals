using System;

namespace _05._Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			string order = Console.ReadLine();
			int countOfOrder = int.Parse(Console.ReadLine());
			totoalSum(order, countOfOrder);

		}

		private static void totoalSum(string order, int countOfOrder)
		{
			if (order == "coffee")
			{
				Console.WriteLine($"{(countOfOrder * 1.5):f2}");
			}
			else if (order == "water")
			{
				Console.WriteLine($"{(countOfOrder * 1):f2}");
			}
			else if (order == "coke")
			{
				Console.WriteLine($"{(countOfOrder * 1.4):f2}");
			}
			else 
			{
				Console.WriteLine($"{(countOfOrder * 2):f2}");
			}
		}
	}
}
