using System;
using System.Threading;

namespace equals
{
    class Progrma
    {
        static int [] myArr ()
        {
            int[] arr = new int [5];
            return arr;
        }



        static void Main(string [] args)
        {
            int [] arr = myArr();

            arr ??= new int[0];

            Console.WriteLine($"Кол-во элементов в массиве {arr.Length}");
            
        }
    }
}