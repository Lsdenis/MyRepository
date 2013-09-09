using System;
using System.Collections.Generic;

namespace lab22
{
	public delegate void delegateSortType(List<Democracy> list);
    public delegate void myDelegateType(string message);

	class MainClass
	{
		public static void Main (string[] args)
		{
			try {

				List<Democracy> listOfMyCountries = new List<Democracy>();
				Democracy myRussia = new Democracy("Russia", 1000000);
				listOfMyCountries.Add(myRussia);
				Democracy myBelarus = new Democracy("Belarus", 2260700);
				listOfMyCountries.Add(myBelarus);
				delegateSortType delegateSort = new delegateSortType(Democracy.sort);
				delegateSort(listOfMyCountries);
				for (int i=0; i < listOfMyCountries.Count; i++)
				{
					Democracy tmp = listOfMyCountries[i];
					tmp.getInformationAboutCountry();
				}

			} catch (Exception ex) {
				Console.WriteLine (ex.ToString());
			}

		}
	}
}
