using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfArticles = int.Parse(Console.ReadLine());
			List<Article> articleList = new List<Article>();
			for (int i = 0; i < countOfArticles; i++)
			{
				string[] lines = Console.ReadLine().Split(", ");
				Article article = new Article
				{
					Title = lines[0],
					Content = lines[1],
					Autor = lines[2]
				};
				articleList.Add(article);
			}
			string word = Console.ReadLine();
			foreach (Article article in articleList)
			{
				Console.WriteLine(article);
			}
		}
	}

	class Article
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Autor { get; set; }

		public override string ToString() => $"{Title} - {Content}: {Autor}";	
	}
}
