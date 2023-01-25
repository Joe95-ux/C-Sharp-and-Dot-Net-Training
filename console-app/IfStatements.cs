using System;
//namespace console_app
//{
//	public class IfStatements
//	{
//		static void Main(string[] args)
//		{
//			string temp = "25";
//			int parsedVal;
//			bool success = int.TryParse(temp, out parsedVal);

//			if (success)
//			{
//                if (parsedVal < 11)
//                {
//                    Console.WriteLine("Wear a jacket");
//                }
//                if (parsedVal > 10)
//                {
//                    Console.WriteLine("Do not Wear a jacket");
//                }

//            }
//			else{
//				Console.WriteLine("Parsing Failed");

//            }


//			Console.Read();
//        }
//	}
//}


namespace console_app
{
	public class IfStatements
	{
		static void Main(string[] args)
		{
			int age = 25;

			switch (age)
			{
				case 15:
					Console.WriteLine("You are too young");
					break;
				case 30:
					Console.WriteLine("You are too old");
					break;
				case 25:
					Console.WriteLine("You are of age");
					break;
				default:
					Console.WriteLine("How old are you");
					break;

			}
			
			


			Console.Read();
		}
	}
}



