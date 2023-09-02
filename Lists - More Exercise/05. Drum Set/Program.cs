using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			List<int> originalDrumQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> drumQuality = new List<int>();

			foreach (var drum in originalDrumQuality)
			{
				drumQuality.Add(drum);
			}

			while (true)
			{
				string cmd = Console.ReadLine();

				if (cmd == "Hit it again, Gabsy!")
				{
					break;
				}

				int power = int.Parse(cmd);

				for (int i = 0; i < drumQuality.Count; i++)
				{
					drumQuality[i] -= power;
					if (drumQuality[i] <= 0)
					{
						drumQuality[i] = originalDrumQuality[i];

						if (bujet - drumQuality[i] * 3 <= 0)
						{
							drumQuality.RemoveAt(i);
							originalDrumQuality.RemoveAt(i);
							i--;
						}
						else
							bujet -= drumQuality[i] * 3;
					}
				}
			}

			Console.WriteLine(string.Join(" ",drumQuality));
			Console.WriteLine($"Gabsy has {bujet:f2}lv.");
		}
	}
}
