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

			int inputArray = int.Parse(Console.ReadLine());

			int [] inputArrayValue = new int[inputArray];

			for (int i = 0; i < inputArrayValue.Length; i++)
            {
                Console.WriteLine($"\nВведите индекс числа {i + 1}");
				inputArrayValue[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("\nВывод массива: ");

            foreach (int i in inputArrayValue)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

		}
	}
}
