using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
	public class StatUp
	{
		static void Main(string[] args)
		{
			int countOfCar = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();

			for (int i = 0; i < countOfCar; i++)
			{
				string[] tokens = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				Car car = new Car(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]), tokens[4], double.Parse(tokens[5]), int.Parse(tokens[6]), double.Parse(tokens[7]), int.Parse(tokens[8]), double.Parse(tokens[9]), int.Parse(tokens[10]), double.Parse(tokens[11]), int.Parse(tokens[12]));

				cars.Add(car);
			}

			string command = Console.ReadLine();
			List<Car> filtredCar = new List<Car>();
			if (command== "fragile")
			{
				filtredCar = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1)).ToList();
			}
			else
			{
				filtredCar = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();
			}

			foreach (var car in filtredCar)
			{
				Console.WriteLine(car.Model);
			}
		}
	}
}
