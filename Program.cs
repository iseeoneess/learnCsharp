using System;
using System.Threading;

namespace equals
{
	class Progrma
	{
		static int [] generatorArrays()
		{
			int[] array = new int [5];

			Random r = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = r.Next(10);
			}
			return array;
		}


		static void Main (string[] args)
		{
			int [] maxIndexArray = generatorArrays();

            for (int i = 0; i < maxIndexArray.Length; i++)
            {
                Console.Write(" " + maxIndexArray[i]);
            }

			Console.WriteLine("\nМаксимальный элемент массива: " + maxIndexArray.Max());

			Console.ReadLine();
		}
	}
}