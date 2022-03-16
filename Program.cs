using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Среднее арифметическое двух чисел
            Console.WriteLine("Данная программа вычисляет С.А двух чисел.");
            
            double firstNum, secondNum, thirdNum;


            Console.WriteLine("Введите первое число: ");

            firstNum = double.Parse(Console.ReadLine());


            Console.WriteLine("Введите второе число");

            secondNum = double.Parse(Console.ReadLine());


            Console.WriteLine("Введите третье число");

            thirdNum = double.Parse(Console.ReadLine());


            double result = (firstNum + secondNum + thirdNum) / 3;

            Console.WriteLine("Среднее арифметическое этих чисел = " + result);

        }
    }
}