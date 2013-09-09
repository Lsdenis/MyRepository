using System;
using System.Collections.Generic;

namespace lab22
{
	public class Democracy : Countries, interface1
	{
		private string typeOfGoverment = "Democracy";
		public string[] region;
		public Democracy (string name, int size)
		{
			setSize(size);
			setName(name);
			setRegions();
		}

		public Democracy (string name): this (name, 0){}
		public Democracy (): this ("Untitled", 0){}

		public string getTypeOfGoverment () { return typeOfGoverment; }

		public void changeName()
		{
			Console.WriteLine("Write new name of the country: ");
			Console.Write("Name {0} is changed to ", getName());
			setName(Console.ReadLine());
		}

		public void changeSize ()
		{
			Console.WriteLine("Write new size of the country: ");
			Console.Write("Size {0} is changed to ", getSize());
			setSize(Int32.Parse(Console.ReadLine()));
		}

		public void getInformationAboutCountry()
		{
			Console.WriteLine("" +
			                  "Name - {0}\n" +
			                  "Size - {1}\n" +
			                  "Type of goverment - {2}\n" +
			                  "Regions: ",
			                  getName(), getSize().ToString(), getTypeOfGoverment());
			string[] tmpRegions = getRegions();
			for (int i=0; i < tmpRegions.Length; i++)
				Console.Write("--{0}--", tmpRegions[i]);
			Console.WriteLine();
		}

		public string this [int index] {
			get { return region[index]; }
			set { region[index] = value; }
		}

		public static void sort(List<Democracy> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = i + 1; j < list.Count; j++)
				{
					if (list[i].getSize() > list[j].getSize())
					{
						var temp = list[i];
						list[i] = list[j];
						list[j] = temp;
					}
				}
			}
		}
	}
}

