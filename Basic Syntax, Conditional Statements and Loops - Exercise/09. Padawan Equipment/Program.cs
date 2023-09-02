using System;

namespace _09._Padawan_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			int countOfStudents = int.Parse(Console.ReadLine());
			double saberPrice = double.Parse(Console.ReadLine());
			double robePrice = double.Parse(Console.ReadLine());
			double beltPrice = double.Parse(Console.ReadLine());
			double saberCount = Math.Ceiling(countOfStudents + (countOfStudents * 0.1));
			double robeCount = countOfStudents;
			double beltCount = countOfStudents - (countOfStudents / 6);
			double totoalSum = saberPrice * saberCount + robeCount * robePrice + beltCount * beltPrice;
			if (bujet>=totoalSum)
			{
				Console.WriteLine($"The money is enough - it would cost {totoalSum:f2}lv.");
			}
			else
			{
				double moneyNeeded = Math.Abs(bujet - totoalSum);
				Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
			}

		}
	}
}
