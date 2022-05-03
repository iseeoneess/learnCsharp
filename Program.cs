using System;
using System.Linq;
using System.Threading;


namespace exampleForOOP
{
    class Car
    {
        public int priceCar;
        public string modelName;
        public int mileAge;
        public int horsePower;
        public string colorCar;
    }


    class inputCharacteristicCar
    {
        static Car getCar()
        {
            var car = new Car();

            Console.Write("Input price car: \n");
            car.priceCar = int.Parse(Console.ReadLine());

            Console.Write("Input model name car: \n");
            car.modelName = Console.ReadLine();

            Console.Write("Input mile age car: \n");
            car.mileAge = int.Parse(Console.ReadLine());

            Console.Write("Input horse power car: \n");
            car.horsePower = int.Parse(Console.ReadLine());

            Console.Write("Input color car: \n");
            car.colorCar = Console.ReadLine();
            return car;
        }

        static void printCarCharacteristic (Car car)
        {
            Console.WriteLine($"Price car: {car.priceCar}$");
            Console.WriteLine($"Model name: {car.modelName}");
            Console.WriteLine($"Mile age car: {car.mileAge} km/h");
            Console.WriteLine($"Horse power car: {car.horsePower} hp");
            Console.WriteLine($"Color car: {car.colorCar}");
        }


        static void Main(string[] args)
        {
            printCarCharacteristic(getCar());
        }
    }
}