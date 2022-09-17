using System.Security.Cryptography.X509Certificates;

namespace EngineExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENGINES!");
            Console.WriteLine("***********");

            Engine engine = new Engine("Base Class Engine", "WolksWagen", 100, 500, 70, 320);
            engine.EngineProperties();

            BenzEngine engineX = new BenzEngine("EngineX", "Tesla", 120, 600, 80, 350);
            engineX.EngineProperties();
        }

        public class Engine
        {
            public string name;
            public string producer;
            public int power;
            public int rpm;
            public int temperature;
            public int maxSpeed;

            public Engine(string name, string producer, int power, int rpm, int temperature, int maxSpeed)
            {
                this.name = name;
                this.producer = producer;
                this.power = power;
                this.rpm = rpm;
                this.temperature = temperature;
                this.maxSpeed = maxSpeed;
            }

            public virtual void EngineProperties()
            {
                Console.WriteLine($"The name of our engine is: {name}.");
                Console.WriteLine($"The producer of our {name} is: {producer}.");
                Console.WriteLine($"The power of {name} is: {power} hp.");
                Console.WriteLine($"The rpm of {name} is: {rpm} rotations per minute.");
                Console.WriteLine($"The temperature of {name} is: {temperature} degrees.");
                Console.WriteLine($"The maximum speed of {name} is: {maxSpeed} miles/h.");
                Console.WriteLine("***********");
            }

        }

        public class BenzEngine : Engine
        {
            public BenzEngine(string name, string producer, int power, int rpm, int temperature, int maxSpeed) : base(name, producer, power, rpm, temperature, maxSpeed)
            {

            }

            public override void EngineProperties()
            {
                Console.WriteLine($"The name of our engine is: {name}.");
                Console.WriteLine($"The producer of our {name} is: {producer}.");
                Console.WriteLine($"The power of {name} is: {power} hp.");
                Console.WriteLine($"The rpm of {name} is: {rpm} rotations per minute.");
                Console.WriteLine($"The temperature of {name} is: {temperature} degrees.");
                Console.WriteLine($"The maximum speed of {name} is: {maxSpeed} miles/h.");
                Console.WriteLine("***********");
            }
        }

        public class Tesla : Engine
        {

            public Tesla(string name, string producer, int power, int rpm, int temperature, int maxSpeed) : base(name, producer, power, rpm, temperature, maxSpeed)
            {
            }
        }
    }
}