using System;
using System.Threading;

namespace getSets
{
    class someone
    {
        private int x;

        private int setX()
        {
            return x;
        } 

        private void setX(int x)
        {
            this.x = x;
            return;
        }

        private int number;

        public int numberValue
        {
            get { return number; }
            set { number = value; }
        }

        private int myVar;

        public int Age
        {
            get { return myVar; }
            set { myVar = value + 1; }
        }


        public void PrintAge()
        {
            Console.WriteLine($"Age: {Age}");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            someone someone = new someone();
            someone.Age = 10;
            someone.PrintAge();

            int age = someone.Age;
            age += 1;
            Console.WriteLine($"Age main = {age}");
        }
    }
}