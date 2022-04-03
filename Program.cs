using System;
using System.Linq;
using System.Threading;

namespace functionsAndMetods
{
	// Написать метод, который выводит на экран строку.
	// Символы из которых состит строка и их кол-во вводятся пользователями.
	class Program
	{
        static void outputResult(string symbol, int iteration)
        {
            if (iteration != 0 && iteration > 0)
            {
                for (int i = 0; i < iteration; i++)
                {
                    Console.Write($" {symbol}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Введите положительное число больше нуля.");

            }
        }

		static void Main(string [] args)
        {
            Console.WriteLine("Введите символ или строку");

            string symbol = Console.ReadLine();

            Console.WriteLine("Сколько раз вывести это?");

            int iteration = int.Parse(Console.ReadLine());

            outputResult(symbol, iteration);

            
        }
	}
}