using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Проверка на четность

            Console.WriteLine("Введите число, которое будет проверено на четность.");

            int number;
            

            number = int.Parse(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine("Число " + number + " является четным.");

            }

            else if (number == 0)
            {
                Console.WriteLine("Ошибка.");
            }

            else if (number % 2 == 1)
            {
                Console.WriteLine("Число " + number + " не является четным :(");
            }

            else
            {
                Console.WriteLine("Ошибка, попробуйте вписать целое число.");
            }
        }
    }
}