using System;
using System.Collections.Generic;

namespace _05._Multiply_Big_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string reallyBigNum = Console.ReadLine();
			int num = int.Parse(Console.ReadLine());
			List<int> result = new List<int>();
			int reminder = 0;

			if (num == 0)
			{
				Console.WriteLine(0);
				return;
			}


			for (int i = reallyBigNum.Length - 1; i >= 0; i--)
			{
				int curNum = int.Parse(reallyBigNum[i].ToString());
				int curMultiplyer = curNum * num+reminder;
				result.Add(curMultiplyer % 10);
				reminder = curMultiplyer / 10;
			}

			if (reminder != 0)
			{
				result.Add(reminder);
			}
			result.Reverse();
			Console.WriteLine(string.Join("", result));
		}
	}
}
