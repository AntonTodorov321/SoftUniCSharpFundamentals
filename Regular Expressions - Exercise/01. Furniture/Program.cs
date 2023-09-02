using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @">>(?<furniture>[A-z]+)<<(?<price>\d+[.\d]*)!(?<quantity>\d+)";
			double totoalSum = 0;
			List<string> furnitureList = new List<string>();
			while (true)
			{
				string input = Console.ReadLine();
				if (input== "Purchase")
				{
					break;
				}

				Regex regex = new Regex(pattern);
				Match match = regex.Match(input);

				if (match.Success)
				{
					string furniture = match.Groups["furniture"].Value;
					double price = double.Parse(match.Groups["price"].Value);
					int quantity = int.Parse(match.Groups["quantity"].Value);
					furnitureList.Add(furniture);
					totoalSum += price * quantity;
				}
			}

			Console.WriteLine("Bought furniture:");
			furnitureList.ForEach(Console.WriteLine);
			Console.WriteLine($"Total money spend: {totoalSum:f2}");
		}
	}
}
