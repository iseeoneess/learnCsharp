using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Среднее арифметическое двух чисел
            Console.WriteLine("Введите первое число: ");

            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            double thirdNum = double.Parse(Console.ReadLine());
            
            double result = (firstNum + secondNum + thirdNum) / 3;

            Console.WriteLine("Среднее арифметическое данных чисел = " + result);

        }
    }
}