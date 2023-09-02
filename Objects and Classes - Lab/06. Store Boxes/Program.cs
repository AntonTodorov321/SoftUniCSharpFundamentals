using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Box> boxList = new List<Box>();
			while (true)
			{
				string[] tokens = Console.ReadLine().Split();
				if (tokens[0]=="end")
				{
					break;
				}
				Box box = new Box
				{
					SerialNumber = tokens[0],
					ItemQuantity = int.Parse(tokens[2]),
					Item = new Item(tokens[1], decimal.Parse(tokens[3]))
				};
				boxList.Add(box);
			}
			List<Box> orderBox = boxList.OrderByDescending(box => box.PriceForBox).ToList();
			foreach (Box box in orderBox)
			{
				Console.WriteLine($"{box.SerialNumber}");
				Console.WriteLine($"-- {box.Item.Name} – ${box.Item.Price:f2}: {box.ItemQuantity}");
				Console.WriteLine($"-- ${box.PriceForBox:f2}");
			}
		}
	}

	class Item
	{
		public Item(string name, decimal price)
		{
			Name = name;
			Price = price;
		}

		public string Name { get; set; }
		public decimal Price { get; set; }
	}

	class Box
	{
		public string SerialNumber { get; set; }
		public Item Item { get; set; }
		public int ItemQuantity { get; set; }
		public decimal PriceForBox { 
			get 
			{
				return ItemQuantity * Item.Price;
			}
		}
	}
}
