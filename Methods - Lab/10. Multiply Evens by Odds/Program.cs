using System;

namespace _10._Multiply_Evens_by_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			num = Math.Abs(num);
			int evenSum = GetSumOfEvenDigits(num);
			int oddSum = GetSumOfOddDigits(num);
			int finalFesult = GetMultipleOfEvenAndOdds(evenSum, oddSum);
			Console.WriteLine(finalFesult);
		}

		static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum) => evenSum * oddSum;

		static int GetSumOfOddDigits(int num)
		{
			int sum = 0;
			while (num > 0)
			{
				int currentDigit = num % 10;
				num /= 10;
				if (currentDigit % 2 != 0)
				{
					sum += currentDigit;
				}
			}
			return sum;
		}

		static int GetSumOfEvenDigits(int num)
		{
			int sum = 0;
			while (num>0)
			{
				int currentDigit = num % 10;
				num /= 10;
				if (currentDigit%2==0)
				{
					sum += currentDigit;
				}
			}
			return sum;
		}
	}
}
