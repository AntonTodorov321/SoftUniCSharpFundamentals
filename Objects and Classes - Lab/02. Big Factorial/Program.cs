using System;
using System.Numerics;

namespace _02._Big_Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberToFacturiel = int.Parse(Console.ReadLine());
			BigInteger result = 1;
			for (int i = 0; i <= numberToFacturiel; i++)
			{
				result *= i;
			}
			Console.WriteLine(result);
		}
	}
}
