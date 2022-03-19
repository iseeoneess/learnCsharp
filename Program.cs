using System;


namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();


				double FirstValue, SecondValue;
				string operation;

				Console.WriteLine("Привет, это калькулятор.");

				Console.WriteLine("");

				Console.WriteLine("Пока что я умею производить операции только с 2 числами.");

				Console.WriteLine("");

				try
				{
					Console.WriteLine("Хорошо, напиши первое число:");

					FirstValue = double.Parse(Console.ReadLine());


					Console.WriteLine("Отлично, напиши второе:");

					SecondValue = double.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("Не удалось преобразовать строку в число..");

					Console.WriteLine("Если хочешь продолжить - нажми Enter");

					Console.ReadLine();

					continue;
				}


				Console.WriteLine("Выбери то, что ты хочешь сделать с числами...");

				Console.WriteLine("");

				Console.WriteLine("'+' '-' '*' '/' ");
				Console.WriteLine("");

				operation = Console.ReadLine();

				switch (operation)
				{
					default:
						{
							Console.WriteLine("Ошибка, следуйте инструкциям.");
							break;
						}

					case "+":
						{
							double result = FirstValue + SecondValue;
							Console.WriteLine("");
							Console.WriteLine("Сумма чисел равна: " + result);
							Console.WriteLine("");
							break;
						}
					case "-":
						{
							double result = FirstValue - SecondValue;
							Console.WriteLine("");
							Console.WriteLine("Разность чисел равна: " + result);
							Console.WriteLine("");
							break;
						}
					case "*":
						{
							double result = FirstValue * SecondValue;
							Console.WriteLine("");
							Console.WriteLine("Произведние чисел равна: " + result);
							Console.WriteLine("");
							break;
						}
					case "/":
						{
							if (SecondValue == 0)
							{
								Console.WriteLine("");
								Console.WriteLine(0);
								Console.WriteLine("");

							}
							else
							{
								double result = FirstValue / SecondValue;
								Console.WriteLine("");
								Console.WriteLine("Делние чисел равна: " + result);
								Console.WriteLine("");
							}

							break;
						}
				}
				Console.WriteLine("Программа закончила свою работу...");

				Console.WriteLine("");

				Console.WriteLine("Если хочешь продолжить мою работу - нажми ENTEER");

				Console.ReadLine();

			}
		}
	}
}