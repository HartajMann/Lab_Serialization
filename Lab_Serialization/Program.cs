using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace Lab_Serialization
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Event e1 = new Event();
			e1.eventNumber = 1;
			e1.location = "Calgary";
			string path = @"C:\Users\Harthaj\Documents\sait-sem2\oops_2\Lab_Serialization\Lab_Serialization\event.txt";
			BinaryFormatter bf = new BinaryFormatter();
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				bf.Serialize(fs, e1);
			}
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				Event newEvent = (Event)bf.Deserialize(fs);
				Console.WriteLine(newEvent.eventNumber);
				Console.WriteLine(newEvent.location);
			}
			e1.ReadFromFile(path);
			Console.ReadKey();
		}
	}
}
