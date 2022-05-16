using System;
using System.Threading;

namespace classConstructor
{

	class Gun
	{
        public Gun(bool m4a1)
        {
			this.m4a1 = m4a1;
        }

		private bool m4a1;

		private void Reload()
		{
				Console.WriteLine("Оружие не заряжено.");
				Thread.Sleep(500);
				Console.WriteLine("Отправляю на перезарядку!!");
				Thread.Sleep(1050);
				Console.WriteLine("Готово.");
				m4a1 = true;
				Shoot();
		}

		public void Shoot ()
		{
			if (m4a1)
                Console.WriteLine("Выстрел!");
			else
				Reload();
			m4a1 = false;
		}
	}

	class Program
	{
		static void conditionGuns ()
        {
			Gun gun;
			Console.WriteLine("Введите состояние пушки. '1 - заряжено, 2 - не заряжено'");

			int conditionGun = int.Parse(Console.ReadLine());

			switch (conditionGun)
			{
				case 1:
					gun = new Gun(true);
					gun.Shoot();
					break;
				case 2:
					gun = new Gun(false);
					gun.Shoot();
					break;
				default:
					Console.WriteLine("Попробуйте еще раз!");
					conditionGuns();
					break;
			}

		}


		static void Main(string [] args)
		{
			
			conditionGuns();
		}

		
	}
}