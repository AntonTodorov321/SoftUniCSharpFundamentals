using System;

namespace _02._Sum_Digits
{
	class Program
	{
		static void Main(string[] args)
		{
			string num = Console.ReadLine();
			int sum = 0;
			char[] charArray = num.ToCharArray();
			for (int i = 0; i < charArray.Length; i++)
			{
				sum += int.Parse(charArray[i].ToString());
			}
			Console.WriteLine(sum);
		}
	}
}
