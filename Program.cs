using System;
using System.Threading;

namespace equals
{
	class Progrma
	{

        // <T> сделали generic метод, ахуеть, это позволяет юзать любой тип данных..
		static void resizeArray <T> (ref T [] array, int newSize)
        {
            T[] newArray = new T [newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray [i] = array [i];
            }

            array = newArray;
        }

		static void Main(string[] args)
        {
            int [] firstArray = { 1, 2, 3, 10, 15, 122 };
            string[] zeliboba = { "hi", "Hello", "Привет", "Nihao", "Namaste" };

            resizeArray (ref firstArray, 9);
            resizeArray (ref zeliboba, 3);

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
	}
}