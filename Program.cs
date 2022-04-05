using System;
using System.Linq;
using System.Threading;

namespace findIndexFromArrays
{
    class Program
    {
        static void randomRollingElementsFromArray(int [] array)
        {
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(10);
            }
        }



        static int findIndexFromArrays(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return i;
            }
            return -1;
        }
        static void Main (string[] args)
        {
            int[] arrayRolling = new int[5];

            Console.WriteLine("\tДанная программа выводит содержимое массива.\n");

            Console.WriteLine("Массив содержит 15 целых чисел.");

            Console.WriteLine("\nВы можете попытать свою удачу...\n");
            

            Console.WriteLine("Введите любое целое число.");

            
            Console.WriteLine("\nЕсли такое число есть в массиве, то он выведет его и его индекс\n");



            Console.WriteLine("\n\tА теперь введите число: \n");

            int indexValue = int.Parse(Console.ReadLine());

            randomRollingElementsFromArray(arrayRolling);

            int result = findIndexFromArrays(arrayRolling, indexValue);

            Console.WriteLine(result);
        }
    }
}