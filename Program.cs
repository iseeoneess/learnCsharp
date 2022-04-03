using System;
using System.Linq;
using System.Threading;

namespace functionsAndMetods
{
	class Program
	{
		static int sumsNums(int a, int b)
		{
			int result = a + b;
			return result;
		}

		static void resultNums (int firstNum, int secondNum, int result)
            {
                Console.WriteLine($"Результат сложения {firstNum} и {secondNum} = {result}");
            }
		static void Main(string[] args)
		{
			int a, b, c;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());

			c = sumsNums(a, b);

			resultNums(a, b, c);

			Console.ReadLine();
            
		}
	}
}