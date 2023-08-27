using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
	class Program
	{
		static void Main(string[] args)
		{
			int target = int.Parse(Console.ReadLine());
			int[] numbers = new int[target];
			for (int i = 0; i < target; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}
			for (int i = target-1; i >=0 ; i--)
			{
				Console.Write($"{numbers[i]} ");
			}

		}
	}
}
