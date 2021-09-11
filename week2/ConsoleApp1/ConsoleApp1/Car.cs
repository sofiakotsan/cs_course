using System;

namespace ConsoleApp1
{
    public partial class Car
    {
        string brand;
        uint manufacturingYear;
        double price;
        double fuelCapacity;
        double currentFuelAmount;
        static int carsCount;
        static int numOfWheels;

        public string Brand { get => brand; set
            {
                if (value == null)
                    throw new Exception("Cant set brand to null");
                brand = value;
            }
        }

        public uint ManufacturingYear { get => manufacturingYear; set => manufacturingYear = value; }
        public double Price { get => price; set 
            {
                if (value < 0)
                    throw new Exception("Price can't be less than zero");
                price = value;
            } 
        }
        public double FuelCapacity
        {
            get => fuelCapacity; set
            {
                if (value < 0)
                    throw new Exception("Fuel capacity can't be less than zero");
                fuelCapacity = value;
            }
        }

        public double CurrentFuelAmount
        {
            get => currentFuelAmount; set
            {
                if (value < 0)
                    throw new Exception("Fuel amount can't be less than zero");
                else if (value > fuelCapacity)
                    throw new Exception("Fuel amount can't be more than fuel capacity");
                currentFuelAmount = value;
            }
        }

        public static int CarsCount { get => carsCount; }
        public static int NumOfWheels { get => numOfWheels; }

        static Car()
        {
            carsCount = 0;
            numOfWheels = 4;
        }

        public Car(string _brand, uint _manufacturingYear, double _price, double _fuelCapacity, double _currentFuelAmount)
        {
            Brand = _brand;
            ManufacturingYear = _manufacturingYear;
            Price = _price;
            FuelCapacity = _fuelCapacity;
            CurrentFuelAmount = _currentFuelAmount;

            ++carsCount;
        }

        public Car(string _brand, uint _manufacturingYear, double _price, double _fuelCapacity):this(_brand, _manufacturingYear, _price, _fuelCapacity, 0.0) { }
        public Car(string _brand, uint _manufacturingYear, double _price):this(_brand, _manufacturingYear, _price, 0.0, 0.0) { }
        public Car(string _brand, uint _manufacturingYear):this(_brand, _manufacturingYear, 0.0, 0.0, 0.0) { }
        public Car(string _brand):this(_brand, 0, 0.0, 0.0, 0.0) { }
        public Car():this("not set", 0, 0.0, 0.0, 0.0) { }

        public override string ToString()
        {
            string output = $"Brand: {brand}\nManufacturing year: {manufacturingYear}\n" +
                $"Price: {price}\nFuel capacity: {fuelCapacity}\nCurrent fuel amount: {currentFuelAmount}";
            return output;
        }

        public void AddFuel(double fuelAmount)
        {
            CurrentFuelAmount = currentFuelAmount + fuelAmount;
        }

    }
}
