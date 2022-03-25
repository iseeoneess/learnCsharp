using System;

namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите кол-во элементов массива");

			int inputArray = int.Parse(Console.ReadLine()); // Создали переменную в которую кладем наше кол-во

			int[] inputArrayValue = new int[inputArray]; // Создали массив, в котором указали кол-во элементов с атрибутом
														 // new int t.e кол-во эл. [и указали нашу переменную]

			for (int i = 0; i < inputArrayValue.Length; i++)
			// Создали цикл, который Перебирает наш массив
			// и заставляет юзера вводить желаемые числа в массив
			{
				Console.WriteLine($"\nВведите индекс числа {i + 1}\n");
				inputArrayValue[i] = int.Parse(Console.ReadLine());

			}

			Console.Write("Вывод массива: \n");
			// Использовали foreach, tk он банально проще в синтаксисе.
			for (int i = inputArrayValue.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(inputArrayValue[i]);
			}

			int resultNum = 0;

			Console.Write("\nСумма четных чисел массива: \n");

			for (int i = 0; i < inputArrayValue.Length; i++)
			{
				if (inputArrayValue[i] % 2 == 0)
				{
					resultNum += inputArrayValue[i];
				}
			}
			Console.Write("\t");
			Console.Write(resultNum);


			int minValue = inputArrayValue[0];
			Console.Write("\nМинимальное число массива: \n");

            for (int i = 1; i < inputArrayValue.Length; i++)
            {
				if (inputArrayValue[i] < minValue)
                {
                    minValue = inputArrayValue[i];
                }
            }
			Console.Write("\t");
            Console.WriteLine(minValue);


			//for (int i = 0; i < inputArrayValue.Length; i++)
			//{
			//    if (inputArrayValue[i] % 2 == 0)
			//    {
			//        for (int k = 0; k < inputArrayValue.Length; k++)
			//        {
			//            int result = i;
			//            if (result == k)
			//            {
			//                Console.Write($"");
			//            }
			//        }

			//    }
			//}

			Console.ReadLine();

		}
	}
}
