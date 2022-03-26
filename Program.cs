using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] workArray = { 22, 11, 1, 2, 1, 3, 3, 4, 10, 11, 12, 33, 44, 19, 3, 2, 2 };


            Array.Sort(workArray);

            for (int i = 0; i < workArray.Length; i++)
            {
                Console.WriteLine(workArray[i]);
            }

            Console.WriteLine("\t" + workArray.Min()); // вывыдит мин число массива
            Console.WriteLine("\t" + workArray.Max()); // вывыдит макс число массива

            int [] result = workArray.Distinct().ToArray();  // Отсортировали уникальных чисел..
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"'{result[i]}' "); // Наше i + '';
            }

            Console.ReadLine();








        }
    }
}