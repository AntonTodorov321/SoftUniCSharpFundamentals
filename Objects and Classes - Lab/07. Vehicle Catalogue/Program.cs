using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			Collection collection = new Collection();
			string[] command = Console.ReadLine().Split("/");
			while (command[0] != "end")
			{
				switch (command[0])
				{
					case "Car":
						Cars car = new Cars
						{
							Brand = command[1],
							Model = command[2],
							Horsepower = int.Parse(command[3])
						};
						collection.Car.Add(car);
						break;
					case "Truck":
						Truck truck = new Truck
						{
							Brand = command[1],
							Model = command[2],
							Weight = int.Parse(command[3])
						};
						collection.Truck.Add(truck);
						break;
				}
				command = Console.ReadLine().Split("/");
			}

			if (collection.Car.Count > 0)
			{
				List<Cars> orderCars = collection.Car.OrderBy(car => car.Brand).ToList();
				Console.WriteLine("Cars:");
				foreach (var car in orderCars)
				{
					Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
				}
			}
			if (collection.Truck.Count > 0)
			{
				List<Truck> orderTruck = collection.Truck.OrderBy(truck => truck.Brand).ToList();
				Console.WriteLine("Trucks:");
				foreach (var truck in orderTruck)
				{
					Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
				}
			}
		}
	}

	class Truck
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Weight { get; set; }
	}
	class Cars
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Horsepower { get; set; }
	}
	class Collection
	{
		public Collection()
		{
			this.Car = new List<Cars>();
			Truck = new List<Truck>();
		}
		public List<Cars> Car { get; set; }
		public List<Truck> Truck { get; set; }
	}
}
