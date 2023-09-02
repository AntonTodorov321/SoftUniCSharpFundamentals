using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfStudenst = int.Parse(Console.ReadLine());
			List <Student> studentList = new List<Student>();
			for (int i = 0; i < countOfStudenst; i++)
			{
				string[] studentInfo = Console.ReadLine().Split();
				Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
				studentList.Add(student);
			}
			List<Student> orderList = studentList.OrderByDescending(student=>student.Grade).ToList();
			foreach (Student student in orderList)
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
			}
		}
	}

	class Student
	{
		public Student(string firstName , string lastName , double grade)
		{
			FirstName = firstName;
			LastName = lastName;
			Grade = grade;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Grade { get; set; }
	}
}
