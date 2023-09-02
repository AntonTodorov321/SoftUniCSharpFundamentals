using System;
using System.Collections.Generic;

namespace DefiningClasses
{
	public  class StartUp
	{
		static void Main(string[] args)
		{
			int countOfPeople = int.Parse(Console.ReadLine());
			Family family = new Family();

			for (int i = 0; i < countOfPeople; i++)
			{
				string[] tokens = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				Person person = new Person(tokens[0], int.Parse(tokens[1]));
				family.AddMember(person);
			}

			Person oldestMember = family.GetOldestMember();
			List<Person> peopleOlderThan30 = family.peopleOlderThan30();

			foreach (var people in peopleOlderThan30)
			{
				Console.WriteLine($"{people.Name} - {people.Age}");
			}
		}
	}
}
