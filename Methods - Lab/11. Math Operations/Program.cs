using System;

namespace _11._Math_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			char operation = char.Parse(Console.ReadLine());
			int secondNum = int.Parse(Console.ReadLine());
			double sum = Calculate(firstNum, operation, secondNum);
			Console.WriteLine(sum);
		}

		static double Calculate(int firstNum, char operation, int secondNum)
		{
			double sum = 0;
			switch (operation)
			{
				case '+':
					sum = firstNum + secondNum;
					break;
				case '-':
					sum = firstNum - secondNum;
					break;
				case '*':
					sum = firstNum * secondNum;
					break;
				case '/':
					sum = firstNum / secondNum;
					break;
			}
			return sum;
		}
	}
}
