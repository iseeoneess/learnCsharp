using System;

namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{

			// Ternar operaion (a == b? true : false;)
			Console.WriteLine("Введите число больше 5");

			int inputNum = int.Parse(Console.ReadLine());

			bool outputNum = inputNum < 5 ? false : true;

			Console.WriteLine(outputNum);

			Console.ReadLine();
		}
	}
}
