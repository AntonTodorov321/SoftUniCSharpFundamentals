using System;

namespace _08._Beer_Kegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfKegs = int.Parse(Console.ReadLine());
			double biggestKeg = double.MinValue;
			string biggestKegName = "";
			for (int i = 0; i < countOfKegs; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());
				double currentVolumeOfKeg = Math.PI * Math.Pow(radius, 2) * height;
				if (currentVolumeOfKeg>biggestKeg)
				{
					biggestKeg = currentVolumeOfKeg;
					biggestKegName = model;
				}
			}
			Console.WriteLine(biggestKegName);
		}
	}
}
