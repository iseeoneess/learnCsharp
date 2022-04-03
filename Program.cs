using System;
using System.Linq;
using System.Threading;

namespace indexsAndDiapasones
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,,] myArr = new int[2, 4, 5];

			Random random = new Random();

			for (int z = 0; z < myArr.GetLength(0); z++)
			{
				for (int y = 0; y < myArr.GetLength(1); y++)
				{
					for (int x = 0; x < myArr.GetLength(2); x++)
					{
						myArr[z, y, x] = random.Next(100);
					}
				}
			}


			for (int z = 0; z < myArr.GetLength(0); z++)
			{
                Console.WriteLine($"Страница под номером {z + 1}:\n");
				for (int y = 0; y < myArr.GetLength(1); y++)
				{
					for (int x = 0; x < myArr.GetLength(2); x++)
					{
                        Console.Write(myArr[z,y,x] + " ");
					}
					Console.WriteLine($"Столбец под номером: {y + 1}\n");
				}
			}





			Console.ReadLine();


		}
	}
}

