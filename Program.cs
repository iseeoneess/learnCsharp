 using System;


namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число 1:");

            string num1 = Console.ReadLine();

            int convert1 = Convert.ToInt32(num1);


            Console.WriteLine("Введите число 2:");

            string num2 = Console.ReadLine();

            int convert2 = Convert.ToInt32(num2);


            int sum = convert1 + convert2;

            Console.WriteLine("Сумма чисел: " + sum);


        }
    }
}