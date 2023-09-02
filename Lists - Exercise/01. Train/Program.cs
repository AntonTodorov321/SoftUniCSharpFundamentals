using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> passengerInWagon = Console.ReadLine().Split().Select(int.Parse).ToList();
			int maxCapacity = int.Parse(Console.ReadLine());
			string[] command = Console.ReadLine().Split();
			while (command[0]!="end")
			{
				if (command[0]=="Add")
				{
					int passendgerInWagonToAdd = int.Parse(command[1]);
					passengerInWagon.Add(passendgerInWagonToAdd);
				}
				else
				{
					int passengerToGoingUp = int.Parse(command[0]);
					FindSpaceForPassenger(passengerInWagon, maxCapacity, passengerToGoingUp);
				}
				command = Console.ReadLine().Split();
			}
			Console.WriteLine(string.Join(" ",passengerInWagon));
		}

		static void FindSpaceForPassenger(List<int> passengerInWagon, int maxCapacity, int passengerToGoingUp)
		{
			for (int i = 0; i < passengerInWagon.Count; i++)
			{
				if (passengerInWagon[i]+passengerToGoingUp<=maxCapacity)
				{
					passengerInWagon[i] += passengerToGoingUp;
					break;
				}
			}
		}
	}
}
