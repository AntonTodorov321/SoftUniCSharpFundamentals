using System;

namespace _04._Reverse_Array_of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] elements = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
			Array.Reverse(elements);
			foreach (string element in elements)
			{
				Console.Write($"{element} ");
			}
			
		}
	}
}
