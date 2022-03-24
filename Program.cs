using System;

namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
            // arrays bitch...

            //char [] Myarray = Console.ReadLine().ToArray();

            //foreach (char i in Myarray)
            //	Console.WriteLine(i);

            Console.WriteLine("Введите кол-во элементов массива");

			int inputArray = int.Parse(Console.ReadLine()); // Создали переменную в которую кладем наше кол-во

			int [] inputArrayValue = new int[inputArray]; // Создали массив, в котором указали кол-во элементов с атрибутом
            // new int t.e кол-во эл. [и указали нашу переменную]

			for (int i = 0; i < inputArrayValue.Length; i++) 
                // Создали цикл, который Перебирает наш массив
                // и заставляет юзера вводить желаемые числа в массив
            {
                Console.WriteLine($"\nВведите индекс числа {i + 1}");
				inputArrayValue[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("\nВывод массива: ");
            // Использовали foreach, tk он банально проще в синтаксисе.
            foreach (int i in inputArrayValue)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

		}
	}
}
