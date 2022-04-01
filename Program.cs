using System;
using System.Linq;
using System.Threading;

namespace indexsAndDiapasones
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Данный массив генерирует случайные числа.\n");

            Console.WriteLine("Массив будет представлен в виде таблицы.\n");


            Console.WriteLine("Кол-во строк и колонок не должно превышать число 3.\n");

            Console.WriteLine("Введите кол-во строк\n");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во колонок\n");
            int width = int.Parse(Console.ReadLine());

            int[,] twiceArray = new int [height, width];

            

            for (int i = 0; i < twiceArray.GetLength(0); i++)
            {
                for (int j = 0; j < twiceArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Позиция заполнения по Y:{i + 1}, по X: {j + 1}");
                    twiceArray[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine();





            for (int i = 0; i < twiceArray.GetLength(0); i++)
            {
                if (height >= 4 && width >= 4)
                {
                    Console.WriteLine("Вы ввели числа выше допустимых значений.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("Закрытие программы\n");
                    Thread.Sleep(1000);
                    break;
                }
                else {
                    Console.WriteLine();
                    for (int j = 0; j < twiceArray.GetLength(1); j++)
                    {
                        Console.Write(twiceArray[i, j] + "\t");
                    }
                }
               
            }
		}
	}

}

