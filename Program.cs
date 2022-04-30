using System;
using System.Threading;


namespace enuming
{
    class Program
    {
        enum Countries
        {
            Russia = 1, 
            USA,
            Poland,
            Japan,
            UkraineDoggy,
            UK,
            Germany
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите страну из приведеннго списка:");

            var countries = Enum.GetValues(typeof(Countries));

            foreach (var item in countries)
            {
                Console.Write(item + " ");
            }

            

           

            Console.WriteLine("\nВведите желаемую страну: ");

            string inputValueOfCountry = Console.ReadLine();

            Countries country = (Countries)Enum.Parse(typeof(Countries), inputValueOfCountry, ignoreCase: true);


            switch (country)
            {
                case Countries.Russia:
                    Console.WriteLine($"You choosed {Countries.Russia}");
                    break;

                case Countries.USA:
                    Console.WriteLine($"You choosed {Countries.USA}");
                    break;

                case Countries.Poland:
                    Console.WriteLine($"You choosed {Countries.Poland}");
                    break;

                case Countries.Japan:
                    Console.WriteLine($"You choosed {Countries.Japan}");
                    break;

                case Countries.UkraineDoggy:
                    Console.WriteLine($"You choosed {Countries.UkraineDoggy}");
                    break;

                case Countries.UK:
                    Console.WriteLine($"You choosed {Countries.UK}");
                    break;

                case Countries.Germany:
                    Console.WriteLine($"You choosed {Countries.Germany}");
                    break;

                default:
                    Console.WriteLine("You don't choosed country.");
                    break;
            }
        }
    }
}