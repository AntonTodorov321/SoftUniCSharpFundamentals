using System;

namespace _09._Sum_of_Odd_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			int number = 0;
			for (int i = 1; i <= n; i++)
			{
				number =  (i * 2)-1;
				Console.WriteLine(number);
				sum += number;
			}
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
