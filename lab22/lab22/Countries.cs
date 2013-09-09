using System;

namespace lab22
{
	public abstract class Countries
	{
        public delegate void myDelegateType(string message);

        public event myDelegateType bigCountry;
        public event myDelegateType smallCountry;

		private string name;
		private int size;
		private string[] regions;

		public virtual void setName(string name) { this.name = name; }
		public virtual string getName() { return name; }

		public virtual void setSize(int size) { this.size = size; }
		public virtual int getSize() { return size; }

		public virtual void setRegions ()
		{
			Console.WriteLine ("Enter the nubmer of regions:");
			var j = Int32.Parse(Console.ReadLine());
			regions = new string[j];

			for (int i = 0; i<j; i++)
				regions[i] = Console.ReadLine();

            //myDelegateType myDelegate = new myDelegateType(writeMessage);
            //myDelegate += new myDelegateType(anotherMessage);

            //smallCountry += new myDelegateType(writeMessage);

            //bigCountry += new myDelegateType(writeMessage);
            //bigCountry += new myDelegateType(anotherMessage);

            smallCountry += delegate {
                Console.WriteLine("Small country");
            };


            if (j > 1 && j < 3)
            {
                smallCountry("Small country");
            }
            else
            {
                bigCountry("Big contry");
            }

		}

		public virtual string[] getRegions ()
		{
			return regions;
		}

        public static void writeMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void anotherMessage(string message)
        {
            message = "Hoy";
            Console.WriteLine(message);
        }
	}
}

