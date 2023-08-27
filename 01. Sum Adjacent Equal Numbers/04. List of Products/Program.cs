using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
	class Program
	{
		static void Main(string[] args)
		{
			int target = int.Parse(Console.ReadLine());
			List<string> productList = new List<string>();
			for (int i = 0; i < target; i++)
			{
				string product = Console.ReadLine();
				productList.Add(product);
			}
			productList.Sort();
			int counter = 1;
			foreach (string product in productList)
			{
				Console.WriteLine($"{counter}.{product}");
				counter++;
			}
		}
	}
}
