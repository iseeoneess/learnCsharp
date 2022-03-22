using System;


namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите h треугольника\n");
			int height = int.Parse(Console.ReadLine());



			// normal piramade

			for (int i = 1; i <= height; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}


			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine();
			}




			// reversive piramide..
			for (int i = 1; i <= height; i++)
			{
				for (int j = height; j >= i; j--)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}


			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine();
			}


			// tabalation piramide..
			for (int i = 1; i <= height; i++)
            {
                for (int j = height; j >= i; j--)
                {
					Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
					Console.Write("##");
                }
				Console.WriteLine();
            }




            for (int i = 0; i < 2; i++)
			{
				Console.WriteLine();
			}




			// tabulation reversive piramide...

			for (int i = 0; i <= height; i++)
			{
                for (int j = 0; j <= i; j++)
                {
					Console.Write(" ");
                }

                for (int k = height; k > i; k--)
                {
					Console.Write("##");
                }
				Console.WriteLine();
			}



		}
	}
}
