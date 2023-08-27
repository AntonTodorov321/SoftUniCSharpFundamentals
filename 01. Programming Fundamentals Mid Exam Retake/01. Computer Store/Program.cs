using System;

namespace _01._Computer_Store
{
	class Program
	{
		static void Main(string[] args)
		{
			double priceWithoutTaxes = 0;
			double priceTaxes = 0;
			double totalPrice = 0;
			string command = Console.ReadLine();
			bool isHaveCommad = false;
			while (command != "special" && command != "regular")
			{
				isHaveCommad = true;
				double curPrice = double.Parse(command);
				if (curPrice < 0)
				{
					Console.WriteLine("Invalid price!");
					command = Console.ReadLine();
					continue;
				}
				 else if (curPrice == 0)
				{
					Console.WriteLine("Invalid order!");
				}
				priceWithoutTaxes += curPrice;
				priceTaxes += curPrice * 0.2;
				command = Console.ReadLine();
			}
			totalPrice = priceTaxes + priceWithoutTaxes;
			if (command == "special")
			{
				totalPrice *= 0.9;
			}
			if (isHaveCommad)
			{
			Console.WriteLine("Congratulations you've just bought a new computer!");
			Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
			Console.WriteLine($"Taxes: {priceTaxes:f2}$");
			Console.WriteLine("-----------");
			Console.WriteLine($"Total price: {totalPrice:f2}$");
			}
			else
			{
				Console.WriteLine("Invalid order!");
			}
		}
	}
}
