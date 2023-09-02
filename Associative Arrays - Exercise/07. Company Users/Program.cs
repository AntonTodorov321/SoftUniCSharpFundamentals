using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> companyEmployee = new Dictionary<string, List<string>>();

			while (true)
			{
				string[] cmd = Console.ReadLine().Split(" -> ");

				if (cmd[0]=="End")
				{
					break;
				}

				string companyName = cmd[0];
				string employeeId = cmd[1];

				if (!companyEmployee.ContainsKey(companyName))
				{
					companyEmployee[companyName] = new List<string>();
				}
				if (companyEmployee[companyName].Contains(employeeId))
				{
					continue;
				}
				companyEmployee[companyName].Add(employeeId);
			}


			foreach (var item in companyEmployee)
			{
				string companyName = item.Key;
				List<string> employeedId = item.Value;

				Console.WriteLine(companyName);

				foreach (var id in employeedId)
				{
					Console.WriteLine($"--{id}");
				}
			}
		}
	}
}
