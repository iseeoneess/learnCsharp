using System;
using System.Threading;

namespace insertMetod
{
    class Program
    {
        static void forArrays<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void insertMetod<T>(ref T[] arr, int index, T value)
        {
            T[] newArray = new T[arr.Length + 1];



            if (!(index + 1 > arr.Length))
            {
                newArray[index] = value;
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = arr[i];
                }

                for (int i = index; i < arr.Length; i++)
                {
                    newArray[i + 1] = arr[i];
                }
                arr = newArray;
            }
            else
            {
                Console.WriteLine("Ты долбаеб, указанный индекс больше, чем есть у массива!");
            }

            forArrays(arr);

        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            string[] stringArray = { "hi", "bye", "bia", "si" };

            Program.insertMetod(ref intArray, 21, 3);
            Program.insertMetod(ref stringArray, 1, "bia");

            Console.ReadLine();
        }
    }
}