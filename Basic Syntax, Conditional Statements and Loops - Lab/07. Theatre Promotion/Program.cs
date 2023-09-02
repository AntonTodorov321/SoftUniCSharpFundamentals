using System;

namespace _07._Theatre_Promotion
{
	class Program
	{
		static void Main(string[] args)
		{
			string typeOfDay = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			int ticket = 0;
			if (typeOfDay=="Weekday")
			{
				if ((age>=0 && age <=18) || (age>64 && age<=122))
				{
					ticket = 12;
				}
				else if (age >18 && age <=64)
				{
					ticket = 18;
				}
				else
				{
					Console.WriteLine("Error!");
					return;
				}
			}
			else if (typeOfDay=="Weekend")
			{
				if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
				{
					ticket = 15;
				}
				else if (age > 18 && age <= 64)
				{
					ticket = 20;
				}
				else
				{
					Console.WriteLine("Error!");
					return;
				}
			}
			else 
			{
				if (age>=0 && age<=18)
				{
					ticket = 5;
				}
				else if (age >18 && age<=64)
				{
					ticket = 12;
				}
				else if (age > 64 && age <= 122)
				{
					ticket = 10;
				}
				else
				{
					Console.WriteLine("Error!");
					return;
				}
			}
			Console.WriteLine($"{ticket}$");
		}
	}
}
