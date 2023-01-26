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


//namespace console_app
//{
//	public class IfStatements
//	{
//		static void Main(string[] args)
//		{
//			int age = 25;

//			switch (age)
//			{
//				case 15:
//					Console.WriteLine("You are too young");
//					break;
//				case 30:
//					Console.WriteLine("You are too old");
//					break;
//				case 25:
//					Console.WriteLine("You are of age");
//					break;
//				default:
//					Console.WriteLine("How old are you");
//					break;

//			}




//			Console.Read();
//		}
//	}
//}

//for loops

//namespace console_app
//{
//    public class IfStatements
//    {
//        static void Main(string[] args)
//        {
//           for(int counter = 0; counter < 10; counter++)
//            {
//                Console.WriteLine(counter);
//            }




//            Console.Read();
//        }
//    }
//}

//Do while loop

//namespace console_app
//{
//    public class IfStatements
//    {
//        static void Main(string[] args)
//        {
//            int lengthOfText = 0;
//            string wholeText = "";

//            do
//            {
//                Console.WriteLine("Please enter the name of a a friend");
//                string nameOfFriend = Console.ReadLine();
//                int cuurentLength = nameOfFriend.Length;
//                lengthOfText += cuurentLength;
//                wholeText += nameOfFriend;
//            } while (lengthOfText < 20);
//            Console.WriteLine("Thanks, that was enough! " + wholeText);
//            Console.Read();
//        }
//    }
//}


// Break 

//namespace console_app
//{
//    public class IfStatements
//    {
//        static void Main(string[] args)
//        {

//            for(int counter = 0; counter < 10; counter++)
//            {
//                Console.WriteLine(counter);
//                if(counter == 3)
//                {
//                    Console.WriteLine("At 3 we stop");
//                    break;
//                }
//            }

//            Console.Read();
//        }
//    }
//}

// Continue

//namespace console_app
//{
//    public class IfStatements
//    {
//        static void Main(string[] args)
//        {

//            for (int counter = 0; counter < 10; counter++)
//            {
                
//                if (counter % 2 ==  0)
//                {
//                    Console.WriteLine("Here comes an odd number");
//                    continue;
//                }
//                Console.WriteLine(counter);
//            }

//            Console.Read();
//        }
//    }
//}





