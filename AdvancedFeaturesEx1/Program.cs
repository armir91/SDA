namespace AdvancedFeaturesEx1;

internal class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Greet();

        Student student2 = new Student();
        student2.SetAge(25);
        student2.Greet();
        student2.ShowAge();

        Professor profesori = new Professor();
        profesori.SetAge(50);
        profesori.Greet();
        profesori.Explain();

    }

    public class Person
    {
       public int age;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }

    public class Student : Person
    {

        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age}");
        }
    }

    public class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining!");
        }
    }
}