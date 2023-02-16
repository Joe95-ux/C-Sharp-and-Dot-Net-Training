//using System;
//namespace console_app
//{
//	public class JaggedArray
//	{
//		static void Main(string[] args)
//		{
//			int[][] jaggedArray = new int[3][];

//			jaggedArray[0] = new int[] { 12, 13, 23, 40 };
//            jaggedArray[1] = new int[] { 2, 13, 33, 10 };
//            jaggedArray[2] = new int[] { 42, 12, 16, 50 };

//			// alternatively

//			int[][] jackedArray2 = new int[][]
//			{
//				new int[] { 12, 13, 23, 40 },
//				new int[] { 2, 13, 33, 10 },
//				new int[] { 42, 12, 16, 50 }
//			};
//            Console.WriteLine("The value in the middle of the first entry is {0}", jackedArray2[0][2]);

//            for (int i = 0; i < jackedArray2.Length; i++)
//			{
//				Console.WriteLine("Element {0}", i);
//				for(int j = 0; j < jackedArray2[i].Length; j++)
//				{
//					Console.WriteLine("{0} ", jackedArray2[i][j]);
//				}
//			}
//			Console.ReadKey();
//        }
//	}
//}

