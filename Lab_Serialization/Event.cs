using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Serialization
{
	[Serializable] 
	public class Event
	{
		public int eventNumber { get; set; }
		public string location { get; set; }

		public void ReadFromFile(string Path)
		{
			using (StreamWriter sw = new StreamWriter(Path))
			{
				sw.Write("Hackathon");
			}

			using (StreamReader sr = new StreamReader(Path))
			{
				string word = sr.ReadToEnd();
				Console.WriteLine("In Word: " + word);
				Console.WriteLine("The First Character is: " +word[0]);
				Console.WriteLine("The Middle Character is: " + word[word.Length / 2]);
				Console.WriteLine("The Last Character is: " + word[word.Length - 1]);
			}
		}
	}
}
