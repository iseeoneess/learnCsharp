using System;
using System.Threading;

namespace equals
{
	class Progrma
	{
		static ref int [] resizeArrays (ref int [] arrray)
        {
			int size = int.Parse(Console.ReadLine());

			arrray = new int[size];
            return ref arrray;
        }


		static void Main(string[] args)
        {
			int[] beginVersionArray = { 1, 9, 10, 11 };


            Console.WriteLine("Первоначальный массив: ");

			foreach (int i in beginVersionArray)
            {

				Console.Write(i + " ");
            }
			int [] newVersionArray = resizeArrays(ref beginVersionArray);

			foreach (int i in newVersionArray)
            {
                Console.Write(i + " ");
            }

        }
	}
}