using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
	class Program
	{
		static void Main(string[] args)
		{
			string cmd = Console.ReadLine();
			Dictionary<string, int> resorceCount = new Dictionary<string, int>();
			while (cmd !="stop")
			{
				string resouce = cmd;
				int quantity = int.Parse(Console.ReadLine());

				if (!resorceCount.ContainsKey(resouce))
				{
					resorceCount[resouce] = 0;
				}
				resorceCount[resouce]+=quantity;

				cmd = Console.ReadLine();
			}

			foreach (var resource in resorceCount)
			{
				Console.WriteLine($"{resource.Key} -> {resource.Value}");
			}
		}
	}
}
