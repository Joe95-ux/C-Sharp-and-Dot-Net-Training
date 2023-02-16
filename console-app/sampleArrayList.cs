using System;
using System.Collections;

namespace console_app
{
	public class sampleArrayList
	{
		static void Main(string[] args)
		{
			//declaring an arraylist with indefinite amount of objects
			ArrayList myArrayList = new ArrayList();

			//declaring an arraylist with definite amount of objects
			ArrayList myArrayList2 = new ArrayList(100);

			myArrayList.Add(25);
			myArrayList.Add("Hello");
			myArrayList.Add("World");
			myArrayList.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myArrayList");
            Console.WriteLine("    Count:    {0}", myArrayList.Count);
            Console.WriteLine("    Capacity: {0}", myArrayList.Capacity);
            Console.Write("    Values:");
            PrintValues(myArrayList);

        }
		public static void PrintValues(IEnumerable myList)
		{
			foreach(Object obj in myList)
			{
				Console.Write(" {0}", obj);
				Console.WriteLine();
			}
		}

	}
}

