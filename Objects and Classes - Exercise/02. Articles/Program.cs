using System;

namespace _02._Articles
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] articleInfo = Console.ReadLine().Split(", ");
			Article article = new Article(articleInfo[0], articleInfo[1],articleInfo[2]);
			int countOfCommands = int.Parse(Console.ReadLine());
			for (int i = 0; i < countOfCommands; i++)
			{
				string[] command = Console.ReadLine().Split(": ");
				switch (command[0])
				{
					case "Edit":
						article.Content = command[1];
						break;
					case "ChangeAuthor":
						article.Author = command[1];
						break;
					case "Rename":
						article.Title = command[1];
						break;
				}
			}
			Console.WriteLine(article);
		}
	}
	class Article
	{
		public Article(string titile , string content , string author)
		{
			Title = titile;
			Content = content;
			Author = author;
		}

		public string Title { get; set; }
		public string Content { get; set; }
		public string Author { get; set; }

		public override string ToString()=> $"{Title} - {Content}: {Author}";
	}
}
