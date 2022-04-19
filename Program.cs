using System;
using System.Threading;


namespace deleteElementInArrays
{



    class Program
    {
        static void outputGiveAnswer(int[] arr, int index)
        {
            Console.WriteLine("\nЕсли хотите запустить программу заново, нажмите y\n");

            Console.WriteLine("Если хотите прекратить работу программы нажмте n\n");

            ConsoleKeyInfo inputAnswer = Console.ReadKey();

            switch (inputAnswer.Key)
            {
                case ConsoleKey.Y:
                    {
                        Console.WriteLine("\nЗапускаю программу заново...");
                        Thread.Sleep(1500);

                        comeBackMetod();
                        break;
                    }

                case ConsoleKey.N:
                    {
                        Console.WriteLine("\nХорошо, закрываю программу...");
                        Thread.Sleep(1500);

                        break;
                    }


                default:
                    Console.WriteLine("\nВы нажали на другую кнопку, я расцениваю это как ошибку.");

                    Console.WriteLine("Предоставляю вам выбрать еще раз.\n");
                    Thread.Sleep(1500);

                    checkArray(arr, index);
                    break;
            }
        }

        static void forArrays(int[] arr) // default foreach array.
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        static void comeBackMetod()
        {
            Console.Clear();

            Console.WriteLine("Укажи размер одномерного массива.");
            int valueIndexes = int.Parse(Console.ReadLine());

            int[] numberArray = new int[valueIndexes];

            valueIndex(numberArray);


            Console.WriteLine("Укажи под каким индексом нужно удалить элемент.");
            int index = int.Parse(Console.ReadLine());

            deleteIndexArray(numberArray, index);

            againProgramBegin();
        }

        static void checkArray(int[] arr, int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Указан отрицательный индекс.");
                Thread.Sleep(1500);

                outputGiveAnswer(arr, index);
            }
            else if (index >= arr.Length)
            {
                Console.WriteLine("Индекс выходит за допустимые значения массива.");
                Thread.Sleep(1500);

                outputGiveAnswer(arr, index);
            }
            else if (index == arr.Length - 1)
            {
                if (index == 0)
                {
                    if (arr.Length == 1)
                    {
                        Console.WriteLine("Вы не можете удалить массив целиком :0");
                        Thread.Sleep(1500);

                        outputGiveAnswer(arr, index);
                    }
                }
            }
        }
        static void deleteIndexArray(int[] arr, int index)
        {
            while (true) // Бесконечный цикл, чтобы было использовать break;
            {
                if (index == arr.Length - 1) // Если индекс = 0 и массив равен 1 - 1, т.е 0, то
                {
                    if (index == 0) // Если индекс 0, то перезапуск
                    {
                        if (arr.Length == 1)
                        {
                            checkArray(arr, index);
                        }
                    }
                }
                else
                {
                    if (index >= 0 && index < arr.Length)
                    {
                        int[] newArray = new int[arr.Length - 1];

                        for (int i = 0; i < index; i++)
                            newArray[i] = arr[i];

                        for (int i = index + 1; i < arr.Length; i++)
                            newArray[i - 1] = arr[i];

                        arr = newArray;

                        Console.WriteLine("Ваш новый массив: \n");
                        forArrays(newArray);
                        break;
                    }
                    else
                    {
                        checkArray(arr, index);
                        break;
                    }
                }
            }
        }

        static void valueIndex(int[] arr)
        {
            int numberInIndexes; // Переменная для того, чтобы присваивать к нашему массиву значения
                                 // Которые будут указывать пользователем.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Укажи элемент под индексом {i + 1}");

                numberInIndexes = int.Parse(Console.ReadLine());

                arr[i] = numberInIndexes; // Под индексы ставим числа.
            }
            Console.WriteLine("Ваш массив: ");
            forArrays(arr); // Вызываем метод, который покажет получившейся массив.
        }

        static void againProgramBegin()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\tХотите еще раз попробовать?\n");
            Thread.Sleep(1500);

            Console.WriteLine("Если хотите продолжить нажмите 'y'\n");
            Thread.Sleep(1000);

            Console.WriteLine("Если хотите завершить нажмите 'n'\n");
            Thread.Sleep(1000);

            ConsoleKeyInfo inputAnswer = Console.ReadKey();
            switch (inputAnswer.Key)
            {
                case ConsoleKey.Y:
                    {
                        comeBackMetod();
                        break;
                    }
                case ConsoleKey.N:
                    {
                        Console.WriteLine("Хорошо, завершаю программу..");
                        Thread.Sleep(1000);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы нажали другую кнопку.\n");
                        Thread.Sleep(1000);

                        Console.WriteLine("Я это расцениваю как ошибку.");

                        Console.WriteLine("\nПерезапускаю программу....");
                        Thread.Sleep(1000);

                        againProgramBegin();
                        break;
                    }
            }
        }


        static void Main(string[] args)
        {

            Console.Title = "Arrays";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Укажи размер одномерного массива.");
            int valueIndexes = int.Parse(Console.ReadLine()); // Размер нашего массива через переменную.

            int[] numberArray = new int[valueIndexes];

            valueIndex(numberArray); // Вызываем метод, который будет присваивать элементы для нашего массива.


            Console.WriteLine("Укажи под каким индексом нужно удалить элемент.");
            int index = int.Parse(Console.ReadLine()); // arr[index]

            deleteIndexArray(numberArray, index); // Запускает метод, который удалит нам нужный индекс..
            Thread.Sleep(1500);

            againProgramBegin();
        }
    }
}