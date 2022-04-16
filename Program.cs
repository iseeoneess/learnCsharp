using System;
using System.Threading;

namespace equals
{
    class Progrma
    {
        static void Main(string [] args)
        {
            // Оператор объединения null... ??
            string a = "";

            Random random = new Random();

            int randomInformatin = random.Next(2);

            if (randomInformatin == 0)
            {
                a = null;
            }
            else if (randomInformatin == 1)
            {
                Console.WriteLine("Проверка пройдена, введите текст");
                a = Console.ReadLine();
            }


            Console.WriteLine(a ?? "Проверка не пройдена!"); // Оператор проверки так сказать
            // Если в a null, то выведет сообщение справа.


            
        }
    }
}