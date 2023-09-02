using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
	public class Car
	{
		public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
		{
			Model = model;
			FuelAmount = fuelAmount;
			FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
		}

		public string Model { get; set; }
		public double FuelAmount { get; set; }
		public double FuelConsumptionPerKilometer { get; set; }
		public double TravelledDistance { get; set; } = 0;


		public static void Drive(int amountOfKm, Car carToDrive)
		{
			if (carToDrive.FuelConsumptionPerKilometer * amountOfKm > carToDrive.FuelAmount)
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
			else
			{
				carToDrive.FuelAmount -= amountOfKm * carToDrive.FuelConsumptionPerKilometer;
				carToDrive.TravelledDistance += amountOfKm;
			}
		}
	}
}
