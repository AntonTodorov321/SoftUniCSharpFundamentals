using System;
using System.Text;

namespace _07._String_Explosion
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			StringBuilder textAfterExplosion = new StringBuilder();
			int power = 0;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i]=='>')
				{
					power += int.Parse(text[i + 1].ToString());
					textAfterExplosion.Append(">");
				}
				else if (power==0)
				{
					textAfterExplosion.Append(text[i]);
				}
				else
				{
					power--;
				}
			}

			Console.WriteLine(textAfterExplosion);
		}
	}
}
