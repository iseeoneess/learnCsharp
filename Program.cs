using System;
using System.Linq;
using System.Threading;

namespace indexsAndDiapasones
{
	class Program
	{
		static void Main(string[] args)
		{
			int [][] randomArray = new int[3][];

			randomArray[0] = new int[3];
			randomArray[1] = new int[4];
			randomArray[2] = new int[5];


			Random random = new Random();

            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = 0; j < randomArray[i].Length; j++)
                {
                    randomArray[i][j] = random.Next(156);
                }
            }

            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = 0; j < randomArray[i].Length; j++)
                {
                    Console.Write(randomArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
		}


	}
}

