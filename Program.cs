using System;
using System.Threading;



namespace ghoul
{
    class Program
    {
      static void giveElemenntsInIndexForArrays(int [] arr, int i)
        {
           Random r = new Random();
           arr [i] = r.Next(30);
           i++;
           if (i == arr.Length)
                return;
           giveElemenntsInIndexForArrays (arr, i);
        }




      static void recursiveMassive(int[] arr, int i)
        {

            int result = arr[i];
            Console.WriteLine(result);
            i++;
            if (i == arr.Length)
                return;
            recursiveMassive(arr, i);


        }
    

      static void Main(string[] args)
        {
            int i = 0;
            int[] arraksahjdkjla = new int[5];

            giveElemenntsInIndexForArrays(arraksahjdkjla, i);
            recursiveMassive(arraksahjdkjla, i);


        }
    }
}