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

            Console.WriteLine(twiceArray[1,2]); //41
		}
	}

}

