using System;
using System.Collections.Generic;

namespace _05._Courses
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> courseStudent = new Dictionary<string, List<string>>();

			while (true)
			{
				string[] command = Console.ReadLine().Split(" : ");
				if (command[0] == "end")
				{
					break;
				}
				string couseName = command[0];
				string studentName = command[1];

				if (!courseStudent.ContainsKey(couseName))
				{
					courseStudent[couseName] = new List<string>();
				}
				courseStudent[couseName].Add(studentName);
			}

			foreach (var courseName in courseStudent)
			{
				List<string> student = courseName.Value;  
				Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");
				foreach (var studentName in student)
				{
					Console.WriteLine($"-- {studentName}");
				}
			}
		}
	}
}
