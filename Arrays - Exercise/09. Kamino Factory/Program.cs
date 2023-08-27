using System;
using System.Linq;

namespace _09._Kamino_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrLenght = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			int[] bestDna = new int[arrLenght];
			int bestSum = 0;
			int bestIndex = 0;
			int bestSequece = 0;
			while (command!="Clone them!")
			{
				int[] currentDna = command.Split("!").Select(int.Parse).ToArray();
				int currentSum = 0;
				int currentIndex = 0;
				int currentSequece = 1;
				for (int i = 0; i < arrLenght-1; i++)
				{

					if (currentDna[i]==currentDna[i+1] && currentDna[i]==1)
					{
						currentSequece++;
						currentIndex = i+1;
					}
				}
				currentSum = currentDna.Sum();
				if (currentSequece>bestSequece)
				{
					bestSequece = currentSequece;
					bestIndex = currentIndex;
					bestSum = currentSum;
					bestDna = currentDna;
				}
				else if (currentSequece==bestSequece)
				{
					if (bestIndex>currentIndex)
					{
						bestSequece = currentSequece;
						bestIndex = currentIndex;
						bestSum = currentSum;
						bestDna = currentDna;
					}
					else if (bestIndex==currentIndex)
					{
						if (currentSum>bestSum)
						{
							bestSequece = currentSequece;
							bestIndex = currentIndex;
							bestSum = currentSum;
							bestDna = currentDna;
						}
					}
				}
					command = Console.ReadLine();
			}
			Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
			Console.WriteLine(string.Join(" ",bestDna));
		}
	}
}
