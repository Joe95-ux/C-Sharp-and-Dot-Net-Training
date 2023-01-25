//using System;
//namespace console_app
//{
//    public class Methods
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(AddNums(20, 10));
//            Console.WriteLine(MultiplyNums(5, 10));
//            Console.Read();

//        }

//        public static int AddNums(int num1, int num2)
//        {
//            return num1 + num2;
//        }

//        public static int MultiplyNums(int num1, int num2)
//        {
//            return num1 * num2;
//        }

//    }
//}


// user input
//namespace console_app
//{
//    public class Methods
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Calculate());
//            Console.Read();

//        }

//        public static int Calculate()
//        {
//            Console.WriteLine("Please enter the first number");
//            string firstNum = Console.ReadLine();
//            Console.WriteLine("Please enter the Second number");
//            string secondNum = Console.ReadLine();

//            int num1 = int.Parse(firstNum);
//            int num2 = int.Parse(secondNum);

//            return num1 + num2;

//        }


//    }
//}

//namespace console_app
//{
//    public class ExceptionsHandling
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number");
//            string input = Console.ReadLine();
//            Console.Read();

//            try
//            {
//                int userInput = int.Parse(input);
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Format exception. Please enter the correct type next time");
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("Overflow exception. Number was too long for an Int32");
//            }
//            catch (ArgumentException)
//            {
//                Console.WriteLine("Argument null exception, the argument was empty(null");
//            }
//            finally
//            {
//                Console.WriteLine("This is called anyways!");
//            }

//        }



//    }
//}
