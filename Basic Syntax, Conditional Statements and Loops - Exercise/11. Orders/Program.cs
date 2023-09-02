using System;

namespace _11._Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			int ordersCount = int.Parse(Console.ReadLine());
			double totoalSum = 0;
			for (int i = 0; i < ordersCount; i++)
			{
				double pricePerCapsule = double.Parse(Console.ReadLine());
				int daysOfMonth = int.Parse(Console.ReadLine());
				int capsuleCount = int.Parse(Console.ReadLine());
				double sumForCoffee = pricePerCapsule * daysOfMonth * capsuleCount;
				Console.WriteLine($"The price for the coffee is: ${sumForCoffee:f2}");
				totoalSum += sumForCoffee;
			}
			Console.WriteLine($"Total: ${totoalSum:f2}");
		}
	}
}
