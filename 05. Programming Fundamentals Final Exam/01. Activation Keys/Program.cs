using System;

namespace _01._Activation_Keys
{
	class Program
	{
		static void Main(string[] args)
		{
			string activationKey = Console.ReadLine();

			while (true)
			{
				string cmd = Console.ReadLine();
				if (cmd== "Generate")
				{
					break;
				}

				string[] tokens = cmd.Split(">>>");
				string action = tokens[0];

				switch (action)
				{
					case "Contains":
						string substring = tokens[1];

						if (activationKey.Contains(substring))
							Console.WriteLine($"{activationKey} contains {substring}");
						else
							Console.WriteLine("Substring not found!");
						break;

					case "Flip":
						{
							string casing = tokens[1];
							int startIndexOfSubstring = int.Parse(tokens[2]);
							int endIndexOfSubstring = int.Parse(tokens[3]);
							string originalSubstring = activationKey.Substring(startIndexOfSubstring, endIndexOfSubstring - startIndexOfSubstring);
							string newSubstring = string.Empty;

							if (casing == "Upper")
								newSubstring = originalSubstring.ToUpper();
							else
								newSubstring = originalSubstring.ToLower();

							activationKey= activationKey.Replace(originalSubstring, newSubstring);
							Console.WriteLine(activationKey);
						}
						break;

					case "Slice":
						int startIndex = int.Parse(tokens[1]);
						int endIndex = int.Parse(tokens[2]);
						activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
						Console.WriteLine(activationKey);
						break;
				}
			}

			Console.WriteLine($"Your activation key is: {activationKey}");
		}
	}
}
