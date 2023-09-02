using System;

namespace _02._Character_Multiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();

			string maxLenght = string.Empty;
			string minLenght = string.Empty;
			int result = 0;

			if (input[0].Length > input[1].Length)
			{
				maxLenght = input[0];
				minLenght = input[1];
			}
			else
			{
				maxLenght = input[1];
				minLenght = input[0];
			}

			result = Result(maxLenght, minLenght, result);
			Console.WriteLine(result);
		}

		static int Result(string maxLenght, string minLenght, int result)
		{
			for (int i = 0; i < minLenght.Length; i++)
			{
				result += maxLenght[i] * minLenght[i];
			}

			for (int i = minLenght.Length; i < maxLenght.Length; i++)
			{
				result += maxLenght[i];
			}

			return result;
		}
	}
}
