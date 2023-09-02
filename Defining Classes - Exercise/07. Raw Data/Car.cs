using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
	public class Car
	{

		public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
		{
			Model = model;
			Engine = new Engine { Speed = engineSpeed, Power = enginePower };
			Cargo = new Cargo { Weight = cargoWeight, Type = cargoType };
			Tires = new Tires[4];
			Tires[0] = new Tires { Pressure= tire1Pressure,Age = tire1Age};
			Tires[1] = new Tires { Pressure= tire2Pressure,Age = tire2Age};
			Tires[2] = new Tires { Pressure= tire3Pressure,Age = tire3Age};
			Tires[3] = new Tires { Pressure= tire4Pressure,Age = tire4Age};
		}
		public string Model { get; set; }
		public Engine Engine { get; set; }
		public Cargo Cargo { get; set; }
		public Tires[] Tires { get; set; }
	}
}
