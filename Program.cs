using System;
using System.Threading;

namespace mainWork
{
	class createCharachter
	{
		private string birthdayTime = "24.04.2005";
		private string [] dateBaseForColorHair = {"Red", "Green", "Blue"};
		private int numerableColorHair;
		private string outputColorHair;
		public int sizeHair;
		public string gender;
		public string name;

		public void human()
		{
			giveInfoForHumanCreator();

			Console.WriteLine("Отлично, у тебя получилось создать персонажа.\n" +
				"Давай посмотрим, что получилось..\n");

			Console.WriteLine($"Дата рождения: {birthdayTime}\n");
			Console.WriteLine($"Имя: {name}\n");
			Console.WriteLine($"Пол: {gender}\n");
			Console.WriteLine($"Цвет волос: {outputColorHair}\n");
			Console.WriteLine($"Размер волос: {sizeHair} см\n");
		}

		private void arrayInfo()
		{
            for (int i = 0; i < dateBaseForColorHair.Length; i++)
            {
                Console.Write($"Цвет {dateBaseForColorHair[i] } под номером {i + 1} \n");
            }
            Console.WriteLine();
		}

		private void outputInfoForColorHair ()
		{

			switch (numerableColorHair)
			{
				case 1:
					outputColorHair = "Red";
					break;
				case 2:
					outputColorHair = "Green";
					break;
				case 3:
					outputColorHair = "Blue";
					break;
					
				default:
					Console.WriteLine("Error 404!");
					outputInfoForColorHair();
					break;
			}
		}

		public void giveInfoForHumanCreator ()
		{

			Console.WriteLine("Привет! Я программа, которая позволит тебе создать своего персонажа\n");
			Thread.Sleep(1000);

			Console.WriteLine("(частично :=) Пока что я могу составить и вывести только:\n Имя, пол, цвет волос, размер волос\n");
			Thread.Sleep(1000);



			giveInfoForNameHuman();
			chooseGenderForHuman();
			giveOutputInfoForNumerableColorHair();
			chooseSizeHair();



			void giveInfoForNameHuman ()
			{
				Console.WriteLine("Отлично, введи имя своего персонажа:\n");

				try
				{
					name = Console.ReadLine();
					Thread.Sleep(1000);
				}
				catch (Exception)
				{
					Console.WriteLine("Ошибка!");
					giveInfoForNameHuman();
					throw;
				}
			}

			void chooseGenderForHuman ()
			{
				Console.WriteLine("Теперь пол: \n");

				try
				{
					gender = Console.ReadLine();
					Thread.Sleep(1000);
				}
				catch (Exception)
				{
					Console.WriteLine("Ошибка!");
					chooseGenderForHuman();
					throw;
				}
			
			}

			void giveOutputInfoForNumerableColorHair ()
			{
				try
				{
					
					arrayInfo();
					Console.WriteLine("Выбери нужный цвет под номером");
					numerableColorHair = int.Parse(Console.ReadLine());
					outputInfoForColorHair();

				}
				catch (Exception)
				{
					Console.WriteLine("Error, try again!");
					giveOutputInfoForNumerableColorHair();
					throw;
				}
			}



			void chooseSizeHair ()
			{
				Console.WriteLine("Прекрасненько!\n " +
				"А теперь выбери размер (до 30см)\n");

				try
				{
					sizeHair = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					if (sizeHair > 30)
					{
						Console.WriteLine("Ошибка");
					}
					chooseSizeHair();
					throw;
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			createCharachter createCharachter = new createCharachter();
			createCharachter.human();

			
		}
	}
}