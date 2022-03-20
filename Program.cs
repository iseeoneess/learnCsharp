using System;


namespace LearnCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ты гуль?");
			int i = 1007;
			string ghoul = Console.ReadLine();
			if (ghoul == "я гуль" || ghoul == "Я гуль")
			{
				while (i > 0)
				{
					if (i == 6)
					{
						int j = 40;
						
						while (j > 0)
                        {
							j--;
							Thread.Sleep(30);
							Console.WriteLine("Ты долбаееб.Ф_В)Ф_+");
							continue;
                        }
						break;
					}
					else
					{
						i -= 7;
						Thread.Sleep(17);

						string result = i.ToString() + " - 7";
						Console.WriteLine(result);
					}
				}
			}

		}
	}
}
