using System;
using System.Collections.Generic;

namespace _04._Tribonacci_Sequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfOperation = int.Parse(Console.ReadLine());
			List<int> tribonacciSequence = new List<int>();
			tribonacciSequence.Add(1);
			int sum = 0;

			for (int i = 0; i < countOfOperation-1; i++)
			{
				sum = 0;
				sum = GetSumOfPreviousThree(tribonacciSequence,i,sum);
				tribonacciSequence.Add(sum);
			}

			Console.WriteLine(string.Join(" ",tribonacciSequence));
		}

		 static int GetSumOfPreviousThree(List<int> tribonacciSequence, int number,int sum)
		{
			for (int i = number; i >= tribonacciSequence.Count-3; i--)
			{
				if (i ==-1)
				{
					return sum;
				}
				sum += tribonacciSequence[i];
			}

			return sum;
		}
	}
}
