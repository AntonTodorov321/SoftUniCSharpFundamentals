using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfCars = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();

			for (int i = 0; i < numOfCars; i++)
			{
				string[] carInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
				Car car = new Car()
				{
					Model = carInfo[0],
					Mileage = int.Parse(carInfo[1]),
					Fuel = int.Parse(carInfo[2])
				};
				cars.Add(car);
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd == "Stop")
				{
					break;
				}

				string[] carInfo = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
				string action = carInfo[0];
				string brand = carInfo[1];

				switch (action)
				{
					case "Drive":
						Drive(brand, int.Parse(carInfo[2]), int.Parse(carInfo[3]),cars);
						break;
					case "Refuel":
						Refuel(brand, int.Parse(carInfo[2]), cars);
						break;
					case "Revert":
						Revert(brand, int.Parse(carInfo[2]), cars);
						break;
				}
			}

			foreach (var car in cars)
			{
				Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
			}
		}

		 static void Drive(string brand, int kilometers, int fuel, List<Car> cars)
		{
			Car car = cars.First(x => x.Model == brand);

			if (car.Fuel< fuel)
			{
				Console.WriteLine("Not enough fuel to make that ride");
				return;
			}

			car.Fuel -= fuel;
			car.Mileage += kilometers;

			Console.WriteLine($"{brand} driven for {kilometers} kilometers. {fuel} liters of fuel consumed.");

			if (car.Mileage>100_000)
			{
				Console.WriteLine($"Time to sell the {brand}!");
				cars.Remove(car);
			}
		}

		static void Refuel(string brand, int fuel, List<Car> cars)
		{
			Car car = cars.First(c => c.Model == brand);
			int originalFuel = car.Fuel;

			car.Fuel += fuel;
			if (car.Fuel>75)
			{
				car.Fuel = 75;
			}

			Console.WriteLine($"{brand} refueled with {car.Fuel-originalFuel} liters");
		}

		static void Revert(string brand, int kilometers, List<Car> cars)
		{
			Car car = cars.First(c => c.Model == brand);

			car.Mileage -= kilometers;
			if (car.Mileage<10_000)		
			{
				car.Mileage = 10_000;
				return;
			}

			Console.WriteLine($"{brand} mileage decreased by {kilometers} kilometers");
		}
	}

	class Car
	{
		public string Model { get; set; }
		public int Mileage { get; set; }
		public int Fuel { get; set; }
	}
}
