using System;
using System.Collections.Generic;
// USE DEBUG MODE TO SEE AUTOGROW of Capacity
namespace GenericList
{
	class TestGenericList
	{
		public static void Main(string[] args)
		{
			var genl = new GenericList<string>();
			
			genl.Add("0");
			genl.Add("1");
			genl.Add("2");
            genl.Add("this is index 3");
			genl.Add("4");
			genl.Add("5");
			genl.Add("6");
            genl.Add("7");
            genl.Add("8");

            Console.WriteLine("GenericList from strings");
            
            foreach (var item in genl)
            {
                Console.WriteLine(item);
            }

            string inserted = "this is set to new 4";

			int index = genl.IndexOf("this is index 3");

            genl.Insert(4, inserted);

			genl.RemoveAt(2);

            Console.WriteLine("Element at index 4 :");
			Console.WriteLine(genl[4]+"\n");

			//genl.Clear();


			var genlInt = new GenericList<int>();
			genlInt.Add(-1);
			genlInt.Add(0);
			genlInt.Add(1);
			genlInt.Add(2);
			genlInt.Add(3);
			genlInt.Add(4);
			genlInt.Add(5);

            Console.WriteLine();
            // ToString test
            Console.WriteLine("ToString test\n");
            Console.WriteLine("GenericList from ints");
            Console.WriteLine(genlInt.ToString());
            
            // min max test
            Console.WriteLine("min max test\n");
            Console.WriteLine("Min is {0}", genlInt.Min());
            Console.WriteLine("Max is {0}", genlInt.Max());

            var listasd = new List<int>();
            int cap = 0;
            for (int i = 0; i < 10; i++)
            {
                listasd.Add(i);
                cap = listasd.Capacity;
            }
		}
	}
}