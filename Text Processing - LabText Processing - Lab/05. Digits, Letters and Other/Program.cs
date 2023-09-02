using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] text = Console.ReadLine().ToCharArray();
			char[] digit = text.Where(ch => char.IsDigit(ch)).ToArray();
			char[] letter = text.Where(ch => char.IsLetter(ch)).ToArray();
			char[] others = text.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();
		
			Console.WriteLine(digit);
			Console.WriteLine(letter);
			Console.WriteLine(others);
		}
	}
}
