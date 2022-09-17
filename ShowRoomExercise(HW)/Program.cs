using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ShowRoomExercise;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car(0, "Gold", "Base Car", 1000, false, DateTime.Now.AddMonths(-30));
        car.GetCarSpecification();

        Benz benz = new Benz(1, "Silver", "Mercedes", 3000, true, DateTime.Now.AddMonths(-25));
        benz.GetCarSpecification();

        Ford ford = new Ford(2, "grey", "Fiesta", 3000, true, DateTime.Now.AddMonths(-20));
        ford.GetCarSpecification();

        Ferrari ferrari = new Ferrari(3, "RED", "Ferrari", 10000, false, DateTime.Now.AddMonths(-15));
        ferrari.GetCarSpecification();

        Toyota toyota = new Toyota(4, "yellow", "Yaris", 5000, true, DateTime.Now.AddMonths(-10));
        ferrari.GetCarSpecification();

        Tesla tesla = new Tesla(5, "Gold", "Tesla", 1000000, false, DateTime.Now.AddMonths(-5));
        tesla.GetCarSpecification();
    }

    public class Car
    {
        public int carSeries;
        public string carColor;
        public string carBrand;
        public int carPrice;
        public bool isAvailable;
        public DateTime createdDate;

        public Car(int carSeries, string carColor, string carBrand, int carPrice, bool isAvailable, DateTime createdDate)
        {
            this.carSeries = carSeries;
            this.carColor = carColor;
            this.carBrand = carBrand;
            this.carPrice = carPrice;
            this.isAvailable = isAvailable;
            this.createdDate = createdDate;
        }

        public virtual void GetCarSpecification()
        {
            Console.WriteLine("This car specification is coming from BASE car!");
            Console.WriteLine($"This car is number: {carSeries} series model");
            Console.WriteLine($"This car is: {carColor}.");
            Console.WriteLine($"This car is a: {carBrand}.");
            Console.WriteLine($"This car cost: {carPrice} euro.");
            if (isAvailable)
            {
                Console.WriteLine("This car is available for immediate purchase!");
            }
            else
            {
                Console.WriteLine("This car is not available for immediate purchase!");
            }
            Console.WriteLine($"This car has been produced on the: {createdDate}.");
            Console.WriteLine("***************************************************");
        }
    }

    public class Benz : Car
    {
        public Benz(int carSeries, string carColor, string carBrand, int carPrice, bool isAvailable, DateTime createdDate) : base(carSeries, carColor, carBrand, carPrice, isAvailable, createdDate)
        {

        }

        public override void GetCarSpecification()
        {
            Console.WriteLine("This car specification is coming from BENZ class / overrides the base class method!");
            Console.WriteLine($"This car is number: {carSeries} series model");
            Console.WriteLine($"This car is: {carColor}.");
            Console.WriteLine($"This car is a: {carBrand}.");
            Console.WriteLine($"This car cost: {carPrice} euro.");
            if (isAvailable)
            {
                Console.WriteLine("This car is available for immediate purchase!");
            }
            else
            {
                Console.WriteLine("This car is not available for immediate purchase!");
            }
            Console.WriteLine($"This car has been produced on the: {createdDate}.");
            Console.WriteLine("***************************************************");
        }
    }
    public class Ferrari : Car
    {
        public Ferrari(int carSeries, string carColor, string carBrand, int carPrice, bool isAvailable, DateTime createdDate) : base(carSeries, carColor, carBrand, carPrice, isAvailable, createdDate)
        {

        }

        public override void GetCarSpecification()
        {
            Console.WriteLine("This car specification is coming from FERRARI class / overrides the base class method!!");
            Console.WriteLine($"This car is number: {carSeries} series model");
            Console.WriteLine($"This car is: {carColor}.");
            Console.WriteLine($"This car is a: {carBrand}.");
            Console.WriteLine($"This car cost: {carPrice} euro.");
            if (isAvailable)
            {
                Console.WriteLine("This car is available for immediate purchase!");
            }
            else
            {
                Console.WriteLine("This car is not available for immediate purchase!");
            }
            Console.WriteLine($"This car has been produced on the: {createdDate}.");
            Console.WriteLine("***************************************************");
        }
    }
    public class Ford : Car
    {
        public Ford(int carSeries, string carColor, string carBrand, int carPrice, bool isAvailable, DateTime createdDate) : base(carSeries, carColor, carBrand, carPrice, isAvailable, createdDate)
        {

        }

        public override void GetCarSpecification()
        {
            Console.WriteLine("This car specification is coming from FORD class / overrides the base class method!!");
            Console.WriteLine($"This car is number: {carSeries} series model");
            Console.WriteLine($"This car is: {carColor}.");
            Console.WriteLine($"This car is a: {carBrand}.");
            Console.WriteLine($"This car cost: {carPrice}euro.");
            if (isAvailable)
            {
                Console.WriteLine("This car is available for immediate purchase!");
            }
            else
            {
                Console.WriteLine("This car is not available for immediate purchase!");
            }
            Console.WriteLine($"This car has been produced on the: {createdDate}.");
            Console.WriteLine("***************************************************");
        }
    }

    public class Toyota : Car
    {
        public Toyota(int carSeries, string carColor, string carBrand, int carPrice, bool isAvailable, DateTime createdDate) : base(carSeries, carColor, carBrand, carPrice, isAvailable, createdDate)
        {

        }
        public override void GetCarSpecification()
        {
            Console.WriteLine("This car specification is coming from TOYOTA class / overrides the base class method!!");
            Console.WriteLine($"This car is number: {carSeries} series model");
            Console.WriteLine($"This car is: {carColor}.");
            Console.WriteLine($"This car is a: {carBrand}.");
            Console.WriteLine($"This car cost: {carPrice} euro.");
            if (isAvailable)
            {
                Console.WriteLine("This car is available for immediate purchase!");
            }
            else
            {
                Console.WriteLine("This car is not available for immediate purchase!");
            }
            Console.WriteLine($"This car has been produced on the: {createdDate}.");
            Console.WriteLine("***************************************************");
        }
    }

    public class Tesla : Car
    {
        public Tesla(int carSeries, string carColor, string carBrand, int carPrice, bool isAvailable, DateTime createdDate) : base(carSeries, carColor, carBrand, carPrice, isAvailable, createdDate)
        {

        }
        public override void GetCarSpecification()
        {
            Console.WriteLine("This car specification is coming from TESLA class / overrides the base class method!!");
            Console.WriteLine($"This car is number: {carSeries} series model");
            Console.WriteLine($"This car is: {carColor}.");
            Console.WriteLine($"This car is a: {carBrand}.");
            Console.WriteLine($"This car cost: {carPrice} euro.");
            if (isAvailable)
            {
                Console.WriteLine("This car is available for immediate purchase!");
            }
            else
            {
                Console.WriteLine("This car is not available for immediate purchase!");
            }
            Console.WriteLine($"This car has been produced on the: {createdDate}.");
            Console.WriteLine("***************************************************");
        }
    }
}