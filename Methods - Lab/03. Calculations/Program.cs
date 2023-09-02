using System;

namespace _03._Calculations
{
	class Program
	{
		static void Main(string[] args)
		{
			string operation = Console.ReadLine();
			int number1 = int.Parse(Console.ReadLine());
			int number2= int.Parse(Console.ReadLine());
			if (operation=="add")
			{
				addNumbers(number1, number2);
			}
			else if (operation=="subtract")
			{
				subtractNumbers(number1, number2);
			}
			else if (operation=="divide")
			{
				devideNumbers(number1, number2);
			}
			else
			{
				multiplyNumber(number1, number2);
			}	
		}

		private static void multiplyNumber(int number1, int number2) => Console.WriteLine(number1 * number2);

		private static void devideNumbers(int number1, int number2) => Console.WriteLine(number1/number2);

		private static void subtractNumbers(int number1, int number2) => Console.WriteLine(number1 - number2);

		private static void addNumbers(int number1, int number2) => Console.WriteLine(number1+number2);
		
	}
}
