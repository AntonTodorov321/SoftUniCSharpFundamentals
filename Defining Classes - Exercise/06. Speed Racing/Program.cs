using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
	 public class StartUp
	{
		static void Main(string[] args)
		{
			List<Car> cars = new List<Car>();
			int numOfCar = int.Parse(Console.ReadLine());

			for (int i = 0; i < numOfCar; i++)
			{
				string[] tokens = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string model = tokens[0];
				double fuelAmount = double.Parse(tokens[1]);
				double fuelConsumptionFor1km = double.Parse(tokens[2]);

				Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
				cars.Add(car);
			}

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd=="End")
				{
					break;
				}

				string[] tokens = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string carModel = tokens[1];
				int amountOfKm = int.Parse(tokens[2]);

				Car carToDrive = cars.Where(X => X.Model == carModel).FirstOrDefault();

				Car.Drive(amountOfKm, carToDrive);
			}

			foreach (var car in cars)
			{
				Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
			}
		}
	}
}
