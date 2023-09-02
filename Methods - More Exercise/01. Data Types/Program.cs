using System;

namespace _01._Data_Types
{
	class Program
	{
		static void Main(string[] args)
		{
			string dataInfo = Console.ReadLine();
			string info = Console.ReadLine();

			switch (dataInfo)
			{
				case "int":
					PrintResult(int.Parse(info));
					break;
				case "real":
					PrintResult(double.Parse(info));
					break;
				case "string":
					PrintResult(info);
					break;
			}
		}

		 static void PrintResult(string info)
		{
			Console.WriteLine($"${info}$");
		}

		static void PrintResult(double number)
		{
			Console.WriteLine($"{(number*1.5):f2}");
		}

		static void PrintResult(int number)
		{
			Console.WriteLine(number * 2);
		}
	}
}
