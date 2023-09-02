using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> fistPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
			while (fistPlayerCard.Count > 0 && secondPlayerCard.Count > 0)
			{
				if (fistPlayerCard[0] > secondPlayerCard[0])
				{
					fistPlayerCard.Add(fistPlayerCard[0]);
					fistPlayerCard.Add(secondPlayerCard[0]);
				}
				else if (secondPlayerCard[0]>fistPlayerCard[0])
				{
					secondPlayerCard.Add(secondPlayerCard[0]);
					secondPlayerCard.Add(fistPlayerCard[0]);
				}
				fistPlayerCard.RemoveAt(0);
				secondPlayerCard.RemoveAt(0);
			}
			if (fistPlayerCard.Count>secondPlayerCard.Count)
			{
				Console.WriteLine($"First player wins! Sum: {fistPlayerCard.Sum()}");
			}
			else
			{
				Console.WriteLine($"Second player wins! Sum: {secondPlayerCard.Sum()}");
			}
		}

	}
}

