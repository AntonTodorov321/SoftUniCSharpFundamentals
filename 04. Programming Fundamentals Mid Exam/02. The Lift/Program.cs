using System;
using System.Linq;

namespace _02._The_Lift
{
	class Program
	{
		const int MAXIMUM_CAPASITY = 4;
		static void Main(string[] args)
		{
			int peopleWaiting = int.Parse(Console.ReadLine());
			int[] liftState = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < liftState.Length; i++)
			{
				for (int j = liftState[i]; j < MAXIMUM_CAPASITY; j++)
				{
					peopleWaiting--;
					liftState[i]++;
					if (peopleWaiting == 0)
					{
						if (liftState.Sum() != liftState.Length * 4)
						{
							Console.WriteLine("The lift has empty spots!");
						}
						Console.WriteLine(string.Join(" ", liftState));
						return;
					}
				}
			}
			Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
			Console.WriteLine(string.Join(" ", liftState));

		}
	}
}
