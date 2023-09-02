using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> studentList = new List<Student>();
			while (true)
			{
				string[] studentInfo = Console.ReadLine().Split();
				if (studentInfo[0]=="end")
				{
					break;
				}
				Student student = new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]);
				studentList.Add(student);
			}
			string town = Console.ReadLine();
			List<Student> filtredStudent = studentList.Where(student => student.Town == town).ToList();
			foreach (Student student in filtredStudent)
			{
				Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
			}
		}
	}

	class Student
	{
		public Student(string firstName, string lastName, int age, string town)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Town = town;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Town { get; set; }
	}
}
