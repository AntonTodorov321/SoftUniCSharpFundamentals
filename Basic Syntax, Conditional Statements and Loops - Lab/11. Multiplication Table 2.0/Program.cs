using System;

namespace _11._Multiplication_Table_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int start = int.Parse(Console.ReadLine());
			do
			{
				Console.WriteLine($"{num} X {start} = { num*start}");
				start++;
			} while (start <= 10);
		}
	}
}
