using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double FirstValue, SecondValue;

            Console.WriteLine("Привет, это калькулятор.");

            Console.WriteLine("");

            Console.WriteLine("Пока что я умею производить операции только с 2 числами.");

            Console.WriteLine("");


            Console.WriteLine("Хорошо, напиши первое число:");

            FirstValue = double.Parse(Console.ReadLine());


            Console.WriteLine("Отлично, напиши второе:");

            SecondValue = double.Parse(Console.ReadLine());


            Console.WriteLine("Выбери то, что ты хочешь сделать с числами...");

            Console.WriteLine("");

            Console.WriteLine("'+' '-' '*' '/' ");

            string operation = Console.ReadLine();

            switch (operation)
            {
                default:
                    {
                        Console.WriteLine("Ошибка, следуйте инструкциям.");
                        break;
                    }

                case "+":
                    {
                        double result = FirstValue + SecondValue;
                        Console.WriteLine("Сумма чисел равна: " + result);
                        break;
                    }
                case "-":
                    {
                        double result = FirstValue - SecondValue;
                        Console.WriteLine("Разность чисел равна: " + result);
                        break;
                    }
                case "*":
                    {
                        double result = FirstValue * SecondValue;
                        Console.WriteLine("Произведние чисел равна: " + result);
                        break;
                    }
                case "/":
                    {
                        if (SecondValue == 0)
                        {
                            Console.WriteLine("Ошибка..");
                            
                        }
                        else
                        {
                            double result = FirstValue / SecondValue;
                            Console.WriteLine("Делние чисел равна: " + result);
                        }
                        
                        break;
                    }
            }

        }
    }
}