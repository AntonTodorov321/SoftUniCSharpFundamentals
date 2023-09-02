using System;

namespace _01._Ages
{
	class Program
	{
		static void Main(string[] args)
		{
			//•	0 - 2 – baby
			//•	3 - 13 – child
			//•	14 - 19 – teenager
			//•	20 - 65 – adult
			//•	>= 66 – elder
			//•	All the values are inclusive
			int num = int.Parse(Console.ReadLine());
			string value = num <= 2 ? "baby" : num <= 13 ? "child" : num <= 19 ? "teenager" : num <= 65 ? "adult" : "elder";
			Console.WriteLine(value);




			//switch (num)
			//{
			//	case int n when n <= 2:
			//		Console.WriteLine("baby");
			//		break;
			//	case int n when n <= 13:
			//		Console.WriteLine("child");
			//		break;
			//	case int n when n <= 19:
			//		Console.WriteLine("teenager");
			//		break;
			//	case int n when n <= 65:
			//		Console.WriteLine("adult");
			//		break;
			//	default:
			//		Console.WriteLine("elder");
			//		break;
			//}








			//if (num <= 2)
			//{
			//	Console.WriteLine("baby");
			//}
			//else if (num <= 13)
			//{
			//	Console.WriteLine("child");
			//}
			//else if (num <= 19)
			//{
			//	Console.WriteLine("teenager");
			//}
			//else if (num <= 65)
			//{
			//	Console.WriteLine("adult");
			//}
			//else 
			//{
			//	Console.WriteLine("elder");
			//}

		}
	}
}
