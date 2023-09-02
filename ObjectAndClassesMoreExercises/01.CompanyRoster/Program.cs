namespace _01._Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
			List<Department> departments = new List<Department>();
			int numOfEmployee = int.Parse(Console.ReadLine());

			for (int i = 0; i < numOfEmployee; i++)
			{
				string[] tokens = Console.ReadLine().Split();

				string empName = tokens[0];
				decimal empSalary = decimal.Parse(tokens[1]);
				string department = tokens[2];

				if (!departments.Any(x=>x.DepartmentName==department))
				{
					departments.Add(new Department(department));
				}

				departments.Find(x => x.DepartmentName == department).AddNewEmployee(empName, empSalary);
			}

			Department bestDepartment = departments.OrderByDescending(x => x.TotalSalry / x.Employees.Count()).First();

			Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

			foreach (var employee in bestDepartment.Employees.OrderByDescending(x=>x.Salary))
			{
				Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
			}
        }
    }

	class Employee
	{
		public Employee(string name,decimal salary)
		{
			Name = name;
			Salary = salary;
		}

		public string Name { get; set; }
		public decimal Salary { get; set; }
	}

	class Department
	{
		public string DepartmentName { get; set; }
		public List<Employee> Employees { get; set; } = new List<Employee>();
		public decimal TotalSalry { get; set; }

		public Department(string department)
		{
			DepartmentName = department;
		}

		public void AddNewEmployee(string empName, decimal empSalary)
		{
			Employees.Add(new Employee(empName, empSalary));
			TotalSalry += empSalary;
		}
	}
}