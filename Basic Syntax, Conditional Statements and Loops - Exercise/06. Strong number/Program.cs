using System;

namespace _06._Strong_number
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int numCopy = num;
			int sumOfFacturiels = 0;
			while (num>0)
			{
				int facturiel = 1;
				int digit = num % 10;
				num /= 10;
				for (int i = 2; i <= digit; i++)
				{
					facturiel = facturiel * i;
				}
				sumOfFacturiels += facturiel;
			}
			Console.WriteLine(numCopy == sumOfFacturiels ?"yes":"no");
		}
	}
}
