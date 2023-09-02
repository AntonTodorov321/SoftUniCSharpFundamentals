using System;
using System.Collections.Generic;

namespace _03._Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] productInfo = Console.ReadLine().Split();
			Dictionary<string, double> productsPrice = new Dictionary<string, double>();
			Dictionary<string, double> productsQuantity = new Dictionary<string, double>();

			while (productInfo[0] != "buy")
			{
				string productName = productInfo[0];
				double price = double.Parse(productInfo[1]);
				double quantity = double.Parse(productInfo[2]);

				if (!productsPrice.ContainsKey(productName))
				{
					productsPrice[productName] = price;
					productsQuantity[productName] = quantity;
				}
				else
				{
					productsPrice[productName] = price;
					productsQuantity[productName] += quantity;
				}

				productInfo = Console.ReadLine().Split();
			}

			foreach (var price in productsPrice)
			{
				foreach (var quantity in productsQuantity)
				{
					if (price.Key == quantity.Key)
					{
						Console.WriteLine($"{price.Key} -> {price.Value * quantity.Value:f2}");
					}
				}
			}
		}
	}
}
