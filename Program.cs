using System;
using System.Threading;

namespace equals
{
	class Progrma
	{
		static void resizeArray(ref int [] array, int newSize)
        {
            int [] newArray = new int [newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray [i] = array [i];
            }

            array = newArray;
        }

		static void Main(string[] args)
        {
            int [] firstArray = { 1, 2, 3, 10, 15, 122 };

            resizeArray (ref firstArray, 9);

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
	}
}