using System;
using System.Linq;
using System.Threading;

namespace twiceEquation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Квадратные уравнения";
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("Данная программа решает простые квадратные уравнения.\n");

			Console.WriteLine("Вводите поочердно то, что требует программа.\n");

			Console.WriteLine("Напоминаю как выглядит квадратное уравнение:\n");

			Console.WriteLine("Пример: x^2 - 10x + 6 = 0");

			Console.WriteLine("\tГде x^2 - а, 10x - b, 6 - c\n");

			Console.WriteLine("Когда будете вводить a и b, учитывайте, что программа автоматически ставит x.\n");

			Console.WriteLine("Введите a: ");

			Console.WriteLine("\tЕсли вы хотите, чтобы a было в виде x^2, то напишите 0");
			int a = int.Parse(Console.ReadLine());
			if (a == 0)
			{
				a = 1;
			}
			Console.WriteLine("Введите первый знак (+ или -) : ");
			char firstSign = char.Parse(Console.ReadLine());
			Console.WriteLine("Введите b: ");
			int b = int.Parse(Console.ReadLine());
			if (firstSign == '-')
			{
				b = -b;
			}
			Console.WriteLine("Введите второй знак (+ или -): ");
			char secondSign = char.Parse(Console.ReadLine());
			Console.WriteLine("Введите c");
			int c = int.Parse(Console.ReadLine());
			if (secondSign == '-')
			{
				c = -c;
			}
			Console.WriteLine("Введите то, что будет после равно");
			int equals = int.Parse(Console.ReadLine());



			Console.WriteLine($"\tВаше уравнение: {a}x^2 {firstSign} {b}x {secondSign} {c} = {equals}");
			while (true)
			{
				int square = Convert.ToInt32(Math.Pow(b, 2));

				int discriminanteFormula = square - 4 * a * c;

				int squareDiscriminanteFormula = Convert.ToInt32(Math.Sqrt(discriminanteFormula));

				if (discriminanteFormula > 0)
				{
					double resultX1 = (-b + squareDiscriminanteFormula) / (2 * a);
					double resultX2 = (-b - squareDiscriminanteFormula) / (2 * a);

					Console.WriteLine($"Первый корень: {resultX1}");
					Console.WriteLine($"Второй корень: {resultX2}");
					break;
				}
				if (discriminanteFormula < 0)
				{
					Console.WriteLine("Корней нет.");
					break;
				}

				if (discriminanteFormula == 0)
				{
					double resultX1 = (-b + squareDiscriminanteFormula) / (2 * a);

					Console.WriteLine($"Т.к корень дискриминанта равен нулю, то и корень будет 1: {resultX1}");
					break;
				}
			}
			Console.ReadLine();
		}
	}
}