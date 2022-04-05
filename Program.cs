using System;
using System.Linq;
using System.Threading;

namespace findIndexsFromArrays
{
	// Элемент для поиска индекса в массиве с типом int. Метод должен вернуть индекс первого найденного элемента (если он будет найден)
	class Program
	{
		static void Main(string[] args)
		{

			int[] arr = new int[10];

			Console.WriteLine("\tДанная программа позволяет найти индекс элемента массива\n");

			Console.WriteLine("Введите желаемое число, которое хотите найти в массиве.");

            int indexValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Программа выведет индекс этого числа.");

            Console.WriteLine("Наш массив: ");

			whileArray(arr);

            Console.WriteLine("\nВаш элемент: ");

			findIndexFromArray(arr, indexValue);

			

			
		}

		static void whileArray(int [] array)
		{
			Random random = new Random();
			for (int r = 0; r < array.Length; r++)
			{
				array[r] = random.Next(100);
			}

            for (int i = 0; i < array.Length; i++)
            {
				Console.Write($"{array[i]} ");
            }
		}
		// Не рабочая функция.
		static void findIndexFromArray(int [] array,int indexValue)
        {
            for (int i = indexValue; i < array.Length; i++)
            {
                Console.WriteLine($"Ваше число {array[i]}");
            }
        }

	}
}
