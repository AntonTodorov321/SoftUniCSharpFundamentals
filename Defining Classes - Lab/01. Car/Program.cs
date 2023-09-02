using System;
using System.Collections.Generic;

namespace CarManufacturer
{
	 public class StartUp
	{
		static void Main(string[] args)
		{
			List<Car> cars = new List<Car>();
			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd== "No more tires")
				{
					break;
				}
				string[] tokes = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				Car car = new Car()
				{
					Tires[0]=(int.Parse(tokes[0]),double.Parse(tokes[1])),
				};

			}
		}
	}
}
