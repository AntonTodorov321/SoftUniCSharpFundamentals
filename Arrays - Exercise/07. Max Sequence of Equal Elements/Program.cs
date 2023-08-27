using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int maxLenght = int.MinValue;
			int counter = 1;
			int bestIndex = 0;
			for (int i = 0; i < numbers.Length-1; i++)
			{

				if (numbers[i]==numbers[i+1])
				{
					counter++;
				}
				else
				{
					counter = 1;
				}
				if (counter>maxLenght)
				{
					maxLenght = counter;
					bestIndex = numbers[i];
				}
				
			}
			for (int i = 0; i < maxLenght; i++)
			{
				Console.Write($"{bestIndex} ");
			}
		}
	}
}
