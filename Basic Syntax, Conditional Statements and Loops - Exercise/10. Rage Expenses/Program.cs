using System;

namespace _10._Rage_Expenses
{
	class Program
	{
		static void Main(string[] args)
		{
			int lostGame = int.Parse(Console.ReadLine());
			double headSetPrice = double.Parse(Console.ReadLine());
			double mousePrice = double.Parse(Console.ReadLine());
			double keyboardPrice = double.Parse(Console.ReadLine());
			double displayPrice = double.Parse(Console.ReadLine());
			int totoalMouseTrashCounter = 0;
			int keyboardTrashCounter = 0;
			int totoalHeadSetTrashCounter = 0;
			int displayTrashCounter = 0;
			int totoalKeyboardTrashCounter = 0;


			for (int i = 1; i <= lostGame; i++)
			{
				if (i%2==0)
				{
					totoalHeadSetTrashCounter++;
				}
				if (i%3==0)
				{
					totoalMouseTrashCounter++;
				}
				if (i%2==0 && i%3==0)
				{
					keyboardTrashCounter++;
					totoalKeyboardTrashCounter++;
				}
				if (keyboardTrashCounter%2==0 && keyboardTrashCounter>0)
				{
					keyboardTrashCounter = 0;
					displayTrashCounter++;
				}
			}
			double rageQuitSum = totoalHeadSetTrashCounter * headSetPrice + totoalMouseTrashCounter * mousePrice + totoalKeyboardTrashCounter * keyboardPrice + displayTrashCounter * displayPrice;
			Console.WriteLine($"Rage expenses: {rageQuitSum:f2} lv.");

		}
	}
}
