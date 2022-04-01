using System;
using System.Linq;

namespace indexsAndDiapasones
{
	class Program
	{
		static void Main(string[] args)
		{
            int[,] twiceArray =
            {
                { 2, 5, 10, 11 },
                { 99, 36, 41, 52 },
                { 91, 75, 34, 41 }
            };

            int height = twiceArray.GetLength(0);
            int width = twiceArray.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < width; x++)
                {
                    Console.Write(twiceArray[y, x] + "\t");
                }
            }
        }
	}

}

