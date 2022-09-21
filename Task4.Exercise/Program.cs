using System.Text.RegularExpressions;
using System;
using System.Xml.Linq;
namespace Task4.Exercise;

internal class Program
{
    static void Main(string[] args)
    {

        float f = 10.12f;
        long l = 200L;

        Console.WriteLine(f + l);


        Console.WriteLine("Dogs ^ cats...");

        Dog dog = new Dog();
        dog.Speak();
        dog.Move();
        dog.ToString();

        Cat cat = new Cat();
        cat.Speak();
        cat.Move();
        cat.ToString();


        Array[] animal = new Array[5];

    }  

    public abstract class Animal
    {
        private string name;
        private int weight;

        public abstract void Speak();
        public abstract void Move();
        public abstract void ToString();
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog speak");
        }

        public override void Move()
        {
            Console.WriteLine("Dog move!");

        }

        public override void ToString()
        {
            Console.WriteLine("simple");

        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat speak");
        }

        public override void Move()
        {
            Console.WriteLine("Cat move!");

        }

        public override void ToString()
        {
            Console.WriteLine("simple");

        }
    }
}