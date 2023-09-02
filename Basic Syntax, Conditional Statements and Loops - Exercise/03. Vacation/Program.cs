using System;

namespace _03._Vacation
{
	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string daysOfWeek = Console.ReadLine();
			double totoalSum = 0;
			if (groupType == "Students")
			{
				switch (daysOfWeek)
				{
					case "Friday":
						totoalSum = peopleCount * 8.45;
						break;
					case "Saturday":
						totoalSum = peopleCount * 9.8;
						break;
					case "Sunday":
						totoalSum = peopleCount * 10.46;
						break;

					default:
						break;
				}
			}
			else if (groupType == "Business")

			{
				switch (daysOfWeek)
				{
					case "Friday":
						totoalSum = peopleCount * 10.9;
						break;
					case "Saturday":
						totoalSum = peopleCount * 15.6;
						break;
					case "Sunday":
						totoalSum = peopleCount * 16;
						break;

				}
			}
			else
			{
				switch (daysOfWeek)
				{
					case "Friday":
						totoalSum = peopleCount * 15;
						break;
					case "Saturday":
						totoalSum = peopleCount * 20;
						break;
					case "Sunday":
						totoalSum = peopleCount * 22.5;
						break;
				}
			}
			if (groupType== "Business" && peopleCount>=100)
			{
				totoalSum -= totoalSum / peopleCount * 10;
			}
			if (groupType== "Regular" && (peopleCount>=10 && peopleCount<=20))
			{
				totoalSum *= 0.95;
			}
			Console.WriteLine($"Total price: {totoalSum:f2}");

		}
	}
}
