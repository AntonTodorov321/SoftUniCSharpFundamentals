using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> studentList = new List<Student>();
			while (true)
			{
				string[] studentInfo = Console.ReadLine().Split();

				if (studentInfo[0] == "end")
				{
					break;
				}

				string firstName = studentInfo[0];
				string lastName = studentInfo[1];
				int age = int.Parse(studentInfo[2]);
				string town = studentInfo[3];

				if (IsStudentExisting(studentList, firstName, lastName))
				{
					Student student = GetStudent(studentList, firstName, lastName);
					student.Age = age;
				}
				else
				{
					Student student = new Student()
					{
						FirstName = firstName,
						LastName = lastName,
						Age = age,
						Town = town,
					};
					studentList.Add(student);
				}
			}
			string townToFind = Console.ReadLine();

			List<Student> filtredStudent = studentList.Where(student => student.Town == townToFind).ToList();
			foreach (Student student in filtredStudent)
			{
				Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
			}
		}

		private static Student GetStudent(List<Student> studentList, string firstName, string lastName)
		{
			Student existingStudent = null;
			foreach (Student student in studentList)
			{
				if (student.FirstName == firstName && student.LastName == lastName)
				{
					existingStudent = student;
					break;
				}
			}
			return existingStudent;
		}

		private static bool IsStudentExisting(List<Student> studentList, string firstName, string lastName)
		{
			foreach (Student student in studentList)
			{
				if (student.FirstName == firstName && student.LastName == lastName)
				{
					return true;
				}
			}
			return false;
		}
	}

	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Town { get; set; }
	}
}

