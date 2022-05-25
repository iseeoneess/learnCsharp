using System;
using System.Threading;

namespace prototypeChance
{
    class GiveAnswer
    {
        public int giveNumberForAnswer;
        private int randomNum;

        private void generateRandomNum()
        {
            Random r = new Random();

            randomNum = r.Next(10);
            return;
        }


        public void indexQuestion()
        {
            generateRandomNum();
            giveNumberForAnswer = randomNum;

            Random r = new Random();

            int indexRandomNum = r.Next(10);

            if (giveNumberForAnswer > 5)
            {
                switch (indexRandomNum)
                {
                    case 0:
                        Console.WriteLine("Да!");
                        break;
                    case 1:
                        Console.WriteLine("Определенно!");
                        break;
                    case 2:
                        Console.WriteLine("Безусловно!");
                        break;
                    case 3:
                        Console.WriteLine("Оно того стоит!");
                        break;
                    case 4:
                        Console.WriteLine("Скорее да, чем нет!");
                        break;
                    case 5:
                        Console.WriteLine("Конечно!");
                        break;
                    case 6:
                        Console.WriteLine("Попробуй");
                        break;
                    case 7:
                        Console.WriteLine("Несомненно");
                        break;
                    case 8:
                        Console.WriteLine("Дерзай");
                        break;
                    case 9:
                        Console.WriteLine("100%");
                        break;
                    case 10:
                        Console.WriteLine("Лучшее решение в твоей жизни!");
                        break;
                    default:
                        break;
                }

            }

            else if (giveNumberForAnswer < 5)
            {
                switch (indexRandomNum)
                {
                    case 0:
                        Console.WriteLine("Нет!");
                        break;
                    case 1:
                        Console.WriteLine("Ни в коем случае!");
                        break;
                    case 2:
                        Console.WriteLine("Не смей");
                        break;
                    case 3:
                        Console.WriteLine("Не стоит");
                        break;
                    case 4:
                        Console.WriteLine("Мне кажется нет");
                        break;
                    case 5:
                        Console.WriteLine("Попробуй другое");
                        break;
                    case 6:
                        Console.WriteLine("Не делай этого!");
                        break;
                    case 7:
                        Console.WriteLine("Лучше сделай наоборот");
                        break;
                    case 8:
                        Console.WriteLine("Never!");
                        break;
                    case 9:
                        Console.WriteLine("Тяжело говорить, но нет");
                        break;
                    case 10:
                        Console.WriteLine("Не сегодня");
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите насущный вопрос о котором вы долго думаете ");
            Console.Write("и не можете принять решение\n");

            string inputQuestion = Console.ReadLine();

            GiveAnswer answer = new GiveAnswer();

            answer.indexQuestion();
        }
    }
}




