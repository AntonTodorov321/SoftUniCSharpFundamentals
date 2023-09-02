using System;

namespace _01._Integer_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			int secondNum = int.Parse(Console.ReadLine());
			int tirdNum = int.Parse(Console.ReadLine());
			int forthNum = int.Parse(Console.ReadLine());
			Console.WriteLine($"{firstNum + secondNum}) {tirdNum * forthNum}");
		}
	}
}
