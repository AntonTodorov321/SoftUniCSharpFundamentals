using System;

namespace _01._SoftUni_Reception
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstEmplayeerCapasity = int.Parse(Console.ReadLine());
			int secondEmplayeerCapasity = int.Parse(Console.ReadLine());
			int tirdEmplayeerCapasity = int.Parse(Console.ReadLine());
			int studentCount = int.Parse(Console.ReadLine());
			int totoalCapasity = firstEmplayeerCapasity + secondEmplayeerCapasity +tirdEmplayeerCapasity;
			int counterHours = 0;
			while (studentCount > 0)
			{
				counterHours++;
				studentCount -= totoalCapasity;
				if (counterHours % 4 == 0)
				{
					counterHours++;
				}
			}
			Console.WriteLine($"Time needed: {counterHours}h.");
		}
	}
}
