using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfSongs = int.Parse(Console.ReadLine());
			List<Songs> songsList = new List<Songs>();
			for (int i = 0; i < numOfSongs; i++)
			{
				string[] songInfo = Console.ReadLine().Split("_");
				Songs songs = new Songs(songInfo[0], songInfo[1], songInfo[2]);
				songsList.Add(songs);
			}
			string typeList = Console.ReadLine();
			if (typeList=="all")
			{
				foreach (Songs song in songsList)
				{
					Console.WriteLine(song.Name);
				}
			}
			else
			{
				List<Songs> filtredSong = songsList.Where(song => song.TypeList == typeList).ToList();
				foreach (Songs song in filtredSong)
				{
					Console.WriteLine(song.Name);
				}
			}
		}
	}

	class Songs
	{
		public Songs(string typeList, string name, string time)
		{
			TypeList = typeList;
			Name = name;
			Time = time;
		}
		public string TypeList { get; set; }
		public string Name { get; set; }
		public string Time { get; set; }
	}
}
