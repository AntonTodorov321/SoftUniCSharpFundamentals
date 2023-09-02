using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"%(?<name>[A-Z][a-z]+)%[^%$.|]*<(?<product>[\w]+)>[^%$.|]*\|(?<quantity>[\d]+)\|[^%$.|]*?(?<price>[\d]+.?[\d]+)\$";
			double totoalPrice = 0;

			while (true)
			{
				string input = Console.ReadLine();
				if (input=="end of shift")
				{
					break;
				}

				Match match = Regex.Match(input, pattern);
				if (match.Success)
				{
					string name = match.Groups["name"].Value;
					string product = match.Groups["product"].Value;
					int quantyty = int.Parse(match.Groups["quantity"].Value);
					double price = double.Parse(match.Groups["price"].Value);
					double currPrice = quantyty * price;
					totoalPrice += currPrice;
					Console.WriteLine($"{name}: {product} - {currPrice:f2}");
				}
			}

			Console.WriteLine($"Total income: {totoalPrice:f2}");
		}
	}
}
