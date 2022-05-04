using System;
using System.Threading;

namespace carDrive
{
	class Car
	{
		private int speed = 0;



		private void randomNumForGiveInfoOrSpeedInMethod()
		{

			Random random = new Random();

			int randomNum = random.Next(-100, 100);

			if (randomNum > 0)
			{
				giveSpeedForCar();
			}

			if (randomNum < 0)
			{
				giveMinusSpeedForCar();
			}

			if (randomNum == 0)
			{
				stopSpeedForCar();
			}
		}


		public void giveInfoForSpeedCar ()
		{
			randomNumForGiveInfoOrSpeedInMethod();

			if (speed > 0)
			{
				Console.WriteLine($"\tДвижемся со скоростью {speed} км\\ч");
			}

			if (speed == 0)
			{
				Console.WriteLine($"\t\nСтоим на месте, т.к скорость {speed} км\\ч");
			}

			if (speed < 0)
			{
				Console.WriteLine($"\t\nЕдем назад со скоростью {-speed} км\\ч");
			}

			
		}

		private int stopSpeedForCar() 
		{ 

			Random random = new Random();

			speed = random.Next(0, 1);

			return speed;
		}

		private int giveSpeedForCar()
		{

			Random random = new Random();

			speed = random.Next(10);

			return speed;
		}

		private int giveMinusSpeedForCar ()
		{

			Random random = new Random();

			speed = random.Next(-10, 0);

			return speed;
		}

	}

	class Program
	{
		static void Main(string [] args)
		{
			var car = new Car();

			car.giveInfoForSpeedCar();
		}

	}
}