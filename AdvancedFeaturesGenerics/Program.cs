using static AdvancedFeaturesGenerics.Program;

namespace AdvancedFeaturesGenerics;

internal class Program
{
    static void Main(string[] args)
    {
        // instantiate generic with Integer
        var intObj = new TestClass<int>();

        //adding integer values into collection

        intObj.Add(1);
        intObj.Add(2);
        intObj.Add(3);
        intObj.Add(4);
        intObj.Add(5);

        //what happens if intObj.Add(6);

        //display values 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(intObj[i]);
        }

        _= Console.ReadKey();

        // instatiate generic with string
        var stringObj = new TestClass<string>();

        // adding integer  values into colletcion
        stringObj.Add("One");
        stringObj.Add("Two");
        stringObj.Add("Three");
        stringObj.Add("Four");
        stringObj.Add("Five");

        //displaying values
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(stringObj[i]);
        }

        //Add peoples
        var peoples = new TestClass<People>();
        var avjol = new People
        {
            Age = 29,
            Name = "Avjol",
            Surname = "Sakaj"
        };
        //fillimisht e krijon pastaj e shton
        peoples.Add(avjol);
        peoples.Add(new People
        {
            Age = 29,
            Name = "Renald",
            Surname = "Fejzulla"
        });

        peoples.Add(new People
        {
            Age = 29,
            Name = "Renald",
            Surname = "Fejzulla"
        });

        peoples.Add(new People
        {
            Age = 29,
            Name = ".",
            Surname = "Fejzulla"
        });

        peoples.Add(new People
        {
            Age = 29,
            Name = "Renald",
            Surname = "Fejzulla"
        });

        peoples.Add(new People
        {
            Age = 29,
            Name = "Renald",
            Surname = "Fejzulla"
        });
        
        // e shton qe ne krijim
           //dispplaying vlaues
        for (var i = 0; i < 5; i++)
        {
            var people = peoples[i];
            Console.WriteLine($"{people.Name} {people.Surname} {people.Age}");
        }
    }

    public class TestClass<T>
    {
        private readonly T[] obj = new T[5];
        private int count = 0;

        //adding items
        public void Add(T item)
        {
            // checking length
            if(count + 1 < 6)
            {
                obj[count] = item;
            }
            count++;
        }

        // indexer fr foreach statement iteration
        public T this[int index]
        {
            get => obj[index];
            set => obj[index] = value;
        }
    }

    public class People
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}