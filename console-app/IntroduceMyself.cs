using System;
namespace console_app
{
	public class IntroduceMyself
	{
		static void Main(string[] args)
		{
			Human denis = new Human("Denis", "Rowland");
			denis.PublicKey = 333;
			denis.IntroduceMyself();

			Human michael = new Human("Michael", "Finn");
            michael.PublicKey = 463;
            michael.IntroduceMyself();

			Human basicHuman = new Human();
			basicHuman.IntroduceMyself();

			Console.ReadKey();
		}
	}
}

