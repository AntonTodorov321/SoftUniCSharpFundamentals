using System;

namespace _07._Vending_Machine
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			double totoalCoins = 0;
			double productPrice = 0;
			while (command != "Start")
			{
				double coins = double.Parse(command);
				if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
				{
					totoalCoins += coins;
				}
				else
				{
					Console.WriteLine($"Cannot accept {coins}");
				}
				command = Console.ReadLine();

			}
			command = Console.ReadLine();
			while (command != "End")
			{
				if (command == "Nuts")
				{
					productPrice = 2;
				}
				else if (command == "Water")
				{
					productPrice = 0.7;
				}
				else if (command == "Crisps")
				{
					productPrice = 1.5;
				}
				else if (command == "Soda")
				{
					productPrice = 0.8;
				}
				else if (command == "Coke")
				{
					productPrice = 1;
				}
				else
				{
					Console.WriteLine("Invalid product");
					command = Console.ReadLine();
					continue;
				}
				if (totoalCoins>=productPrice)
				{
					totoalCoins -= productPrice;
					Console.WriteLine($"Purchased {command.ToLower()}");
				}
				else
				{
					Console.WriteLine("Sorry, not enough money");
				}
				command = Console.ReadLine();
			}
			Console.WriteLine($"Change: {totoalCoins:f2}");
		}
	}
}
