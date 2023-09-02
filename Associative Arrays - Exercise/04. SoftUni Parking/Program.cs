using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfCars = int.Parse(Console.ReadLine());
			Dictionary<string, string> cars = new Dictionary<string, string>();

			for (int i = 0; i < countOfCars; i++)
			{

				string[] carsInfo = Console.ReadLine().Split();
				string carsOwner = carsInfo[1];

				switch (carsInfo[0])
				{
					case "register":
						string plateNum = carsInfo[2];
						if (cars.ContainsKey(carsOwner))
						{
							Console.WriteLine($"ERROR: already registered with plate number {cars[carsOwner]}");
						}
						else
						{
							cars[carsOwner] = plateNum;
							Console.WriteLine($"{carsOwner} registered {plateNum} successfully");
						}
						break;

					case "unregister":
						if (!cars.ContainsKey(carsOwner))
						{
							Console.WriteLine($"ERROR: user {carsOwner} not found");
						}
						else
						{
							cars.Remove(carsOwner);
							Console.WriteLine($"{carsOwner} unregistered successfully");
						}
						break;
				}
			}

			foreach (var car in cars)
			{
				Console.WriteLine($"{car.Key} => {car.Value}");
			}
		}
	}
}
