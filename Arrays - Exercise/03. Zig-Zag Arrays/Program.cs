using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			int[] arrOne = new int[count];
			int[] arrTwo = new int[count];
			for (int i = 0; i < count; i++)
			{
				int[] element = Console.ReadLine().Split().Select(int.Parse).ToArray();
				if (i%2==0)
				{
					arrOne[i] = element[0];
					arrTwo[i] = element[1];
				}
				else
				{
					arrOne[i] = element[1];
					arrTwo[i] = element[0];
				}
			}
			Console.WriteLine(string.Join(" ",arrOne));
			Console.WriteLine(string.Join(" ",arrTwo));
		}
	}
}
