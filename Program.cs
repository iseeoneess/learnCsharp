using System;
using System.Linq;
using System.Threading;

namespace overloadFromMetods
{
	class Program
	{ 
		static void Main(string [] args)
		{
			Console.WriteLine("Данная программа решает простые квадратные уровнения.");

			Console.WriteLine("Вводите поочеердно то, что требует программа.");

			Console.WriteLine("Напоминаю как выглядит квадртаное уравнение:\n");

			Console.WriteLine("Пример: x^2 - 10x + 6 = 0");

			Console.WriteLine("Где x^2 - а, 10x - b, 6 - c");

			Console.WriteLine("Когда будете вводить a и b, учитывайте, что программа автоматически ставит x.");

			Console.WriteLine("Введите a: ");
			Console.WriteLine("Если вы хотите, чтобы a было в виде x^2, то напишите 0");
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

			


			Console.WriteLine($"Ваше уравнение: {a}x^2 {firstSign} {b}x {secondSign} {c} = {equals}");
			while(true)
			{
				int square = Convert.ToInt32(Math.Pow(b, 2));
				int discriminanteFormula = square - 4 * a * c;
				int squareDiscriminanteFormula = Convert.ToInt32(Math.Sqrt(discriminanteFormula));
				if (discriminanteFormula > 0)
				{
					int resultX1 = (-b + squareDiscriminanteFormula) / (2 * a);
					int resultX2 = (-b - squareDiscriminanteFormula) / (2 * a);

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
					int resultX1 = (-b + squareDiscriminanteFormula) / (2 * a);

					Console.WriteLine($"Т.к корень дискриминанта равен нулю, то и корень будет 1: {resultX1}");
					break;
				}
			}
			Console.ReadLine();
		}
	}
}