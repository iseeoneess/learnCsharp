using System;
using System.Threading;

namespace insertMetod
{
	class Program
	{
        static void forArrays<T> (T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

		static void insertMetod<T>(ref T[] arr, int index, T value)
        {
            T[] newArray = arr;
 
            if (!(index + 1 > arr.Length))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[i] = arr[i];
                }
                arr[index] = value;
            }
            else
            {
                Console.WriteLine("Ты долбаеб, указанный индекс больше, чем есть у массива!");
            }

        }

		static void Main(string[] args)
        {
			int [] intArray = { 1, 2, 3, 4 };
			string [] stringArray = { "hi", "bye", "bia", "si" };

            Program.insertMetod(ref intArray, 3, 3);
            Program.insertMetod(ref stringArray, 1, "bia");

            Program.forArrays(intArray);
            Program.forArrays(stringArray);

            Console.ReadLine();
        }
	}
}