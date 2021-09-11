using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car(),
                new Car("BMW"),
                new Car("Audi", 2001),
                new Car("Mazda", 2001, 15999.99),
                new Car("KIA", 2001, 20000, 1.5),
                new Car("Toyota", 2001, 20000, 1.5, 0.6),
            };

            cars[3].FuelCapacity = 1.1;
            cars[3].CurrentFuelAmount = 0.9;

            Console.WriteLine(cars[3].FuelCapacity);
            Console.WriteLine(cars[3].CurrentFuelAmount);

            double fuelAmount = 0.1;
            cars[3].AddFuel(fuelAmount);

            double km = 5;
            cars[5].Drive(ref km);

            foreach (var car in cars)
            {
                Console.WriteLine(car + "\n");
            }
        }
    }
}
