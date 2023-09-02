using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehiclesList = new List<Vehicle>();
			while (true)
			{
				string[] vehicleInfo = Console.ReadLine().Split();
				if (vehicleInfo[0]=="End")
				{
					break;
				}
				Vehicle vehicle = new Vehicle(vehicleInfo[0], vehicleInfo[1], vehicleInfo[2], int.Parse(vehicleInfo[3]));
				vehiclesList.Add(vehicle);
			}
			while (true)
			{
				string findModel = Console.ReadLine();
				var currVehicle = vehiclesList.FirstOrDefault(vehicle => vehicle.Model == findModel);
			}
		}
	}

	class Vehicle
	{
		public Vehicle(string type,string model,string color,int horesepower)
		{
			Type = type;
			Model = model;
			Color = color;
			Horsepower = horesepower;
		}
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int Horsepower { get; set; }
	}
}
