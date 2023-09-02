using System;

namespace _10._Poke_Mon
{
	class Program
	{
		static void Main(string[] args)
		{
			int power = int.Parse(Console.ReadLine());
			int distanseBetweenPoke = int.Parse(Console.ReadLine());
			int exhaustionFactor = int.Parse(Console.ReadLine());
			int pokeCounter = 0;
			int fullPower = power;
			while (power>distanseBetweenPoke)
			{
				power -= distanseBetweenPoke;
				pokeCounter++;
				if (fullPower*0.5==power)
				{
					power /= exhaustionFactor;
				}

			}
			Console.WriteLine(power);
			Console.WriteLine(pokeCounter);
		}
	}
}
