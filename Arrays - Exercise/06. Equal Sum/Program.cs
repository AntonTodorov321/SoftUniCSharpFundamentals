using System;
using System.Linq;

namespace _06._Equal_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int leftSum = 0;
			int rightSum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers.Length==1)
				{
					Console.WriteLine("0");
					return;
				}
				leftSum = 0;
				for (int leftElemet = i; leftElemet > 0; leftElemet--)
				{
					int nextLeftElement = leftElemet - 1;
					leftSum += numbers[nextLeftElement];
				}
				rightSum = 0;
				for (int righElement = i; righElement < numbers.Length-1; righElement++)
				{
					int nextRightElement = righElement + 1;
					rightSum += numbers[nextRightElement];
				}
				if (leftSum==rightSum)
				{
					Console.WriteLine(i);
					return;
				}
			}
			Console.WriteLine("no");
		}
	}
}
