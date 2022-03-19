using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double FirstValue, SecondValue;


            Console.WriteLine("Введите первое число.");

            FirstValue = double.Parse(Console.ReadLine());


            Console.WriteLine("Введите второе число.");

            SecondValue = double.Parse(Console.ReadLine());


            Console.WriteLine("Выберите операцию, которую хотите произвести: ");

            Console.WriteLine("'+' '-' '*' '/' ");
            
            string sign = Console.ReadLine();


            if (sign == "+")
            {
                double result = FirstValue + SecondValue;
                Console.WriteLine("Сумма чисел = " + result);
            }

            else if (sign == "-")
            {
                double result = SecondValue - FirstValue;
                Console.WriteLine("Разность чисел = " + result);
            }

            else if (sign == "*")
            {
                double result = FirstValue * SecondValue;
                Console.WriteLine("Произведение чисел = " + result);
            }

            else if (sign == "/")
            {
                double result = FirstValue / SecondValue;
                Console.WriteLine("Деление чисел = " + result);
            }

            else
            {
                Console.WriteLine("Error, следуйте инструкциям.");
            }

        }
    }
}