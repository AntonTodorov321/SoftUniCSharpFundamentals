using System;

namespace _03._Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfPeople = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());
			double courses = countOfPeople / (double)capacity;
			Console.WriteLine($"{Math.Ceiling(courses)}");
		}
	}
}
