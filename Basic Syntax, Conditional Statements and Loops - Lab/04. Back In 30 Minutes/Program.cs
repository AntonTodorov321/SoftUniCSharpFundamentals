using System;

namespace _04._Back_In_30_Minutes
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minets = int.Parse(Console.ReadLine());
			minets += 30;
			if (minets>=60)
			{
				minets -= 60;
				hours++;
			}
			if (hours>=24)
			{
				hours = 0;
			}
			Console.WriteLine($"{hours}:{minets:d2}");
		}
	}
}
