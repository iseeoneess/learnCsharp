using System;
using System.Globalization; // Чтобы использовать NumberFormatInfo, подключили либу


namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)

        {
            string inputNum = Console.ReadLine(); // Получаем значение от пользователя

            int num; // Объявляем переменную, в которую поместится наше число

            bool resultNum = int.TryParse(inputNum, out num); // Создаем еще 1 переменную, которая выдаст true or false
            // Пробуем ее спарсить. // Впихиваем то, что хотим запарсить, в 2 аргумент передаем ту переменную, которую объявили выше.

            if (resultNum) // Если resultNum == true {};
            {
                Console.WriteLine("Конвертация успешна, значение = " + num);
            }
            else
            {
                Console.WriteLine("Error, введите число!");
            }

        }
    }
}