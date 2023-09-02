using System;

namespace _01._World_Tour
{
	class Program
	{
		static void Main(string[] args)
		{
			string stops = Console.ReadLine();

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "Travel")
				{
					break;
				}

				string[] tokens = command.Split(":");
				string action = tokens[0];

				switch (action)
				{
					case "Add Stop":
						stops = AddStop(stops, tokens);
						Console.WriteLine(stops);
						break;
					case "Remove Stop":
						stops = RemoveStop(stops, tokens);
						Console.WriteLine(stops);
						break;
					case "Switch":
						stops = Switch(stops, tokens);
						Console.WriteLine(stops);
						break;
				}
			}

			Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
		}

		private static string Switch(string stops, string[] tokens)
		{
			string oldStop = tokens[1];
			string newStop = tokens[2];

			if (stops.Contains(oldStop))
			{
				stops = stops.Replace(oldStop, newStop);
			}

			return stops;
		}

		private static string RemoveStop(string stops, string[] tokens)
		{
			int startIndex = int.Parse(tokens[1]);
			int endIndex = int.Parse(tokens[2]);

			if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
			{
				stops = stops.Remove(startIndex, endIndex - startIndex + 1);
			}

			return stops;
		}

		private static string AddStop(string stops, string[] tokens)
		{
			int index = int.Parse(tokens[1]);
			string stopToAdd = tokens[2];
			if (index >= 0 && index < stops.Length)
			{
				stops = stops.Insert(index, stopToAdd);
			}
			return stops;
		}
	}
}
