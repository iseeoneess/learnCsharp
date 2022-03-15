using System;
using System.Globalization; // Чтобы использовать NumberFormatInfo, подключили либу


namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)

        {

            string str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo // Глобальная конвертация
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine(a);

        }
    }
}