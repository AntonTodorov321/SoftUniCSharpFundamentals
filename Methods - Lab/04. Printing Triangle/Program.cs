using System;

namespace _04._Printing_Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			for (int i = 1; i <= num-1; i++)
			{
			printNum(num,i);
			}
			for (int i = num; i <=0 ; i--)
			{
				printNum(num, i);
			}
		}

		private static void printNum(int num, int target)
		{
			for (int i = 1; i <= target; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}
