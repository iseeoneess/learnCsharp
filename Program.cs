using System;


namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			int evenNumber = 0,
				 oddNumber = 0;



			int evenNumberSums = 0,
				oddNumberSums = 0;



			Console.WriteLine("Введите первое число диапазона\n");

			int currentValue = int.Parse(Console.ReadLine());

			Console.WriteLine("Введите второе число диапазона\n");

			int limitValue = int.Parse(Console.ReadLine());

			
				while (currentValue <= limitValue)
                {
					currentValue++;

					if (currentValue % 2 == 0)
					{
						evenNumber++;
						evenNumberSums += currentValue;
					}

					else if (currentValue % 2 == 1)
					{
						oddNumber++;
						oddNumberSums += currentValue;
					}
				}

				 
			Console.WriteLine("Четных чисел в диапазоне:\n" + evenNumber);
			Console.WriteLine("Нечетных чисел в диапазоне:\n" + oddNumber);

			Console.WriteLine("Сумма четных чисел: " + evenNumberSums);
			Console.WriteLine("Сума нечетных чисел: " + oddNumberSums);
		}
	}
}
