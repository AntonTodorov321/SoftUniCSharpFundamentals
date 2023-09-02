using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfStudent = int.Parse(Console.ReadLine());
			Dictionary<string, List<double>> studentsGrage = new Dictionary<string, List<double>>();

			for (int i = 0; i < countOfStudent; i++)
			{
				string currStudentName = Console.ReadLine();
				double currStudentGrade = double.Parse(Console.ReadLine());

				if (!studentsGrage.ContainsKey(currStudentName))
				{
					studentsGrage[currStudentName] = new List<double>();
				}

				studentsGrage[currStudentName].Add(currStudentGrade);
			}

			foreach (var studnet in studentsGrage)
			{
				string studentName = studnet.Key;
				double studentAvgGrade = studnet.Value.Average();
				if (studentAvgGrade >= 4.5)
				{
					Console.WriteLine($"{studentName} -> {studentAvgGrade:f2}");
				}
			}
		}
	}
}
