using System;

namespace _01._Bonus_Scoring_System
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfStudent = int.Parse(Console.ReadLine());
			int numOfLecture = int.Parse(Console.ReadLine());
			int additionalBonus = int.Parse(Console.ReadLine());
			int maxAttendence = 0;
			double maxBonus = double.MinValue;

			for (int i = 0; i < numOfStudent; i++)
			{
				 int attendence = int.Parse(Console.ReadLine());
				double currBonus = (double)attendence / numOfLecture * (5 + additionalBonus);
				if (currBonus>maxBonus)
				{
					maxBonus = currBonus;
					maxAttendence = attendence;
				}
			}
			Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
			Console.WriteLine($"The student has attended {maxAttendence} lectures.");
		}
	}
}
