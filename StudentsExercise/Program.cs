using System.Security.Cryptography.X509Certificates;

namespace StudentsExercise;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********************************************************");
        Console.WriteLine("Students portal:");
        Console.WriteLine("**********************************************************");

        var students = new List<Student>();

        students.Add(new Student
        {
            Grade = 10,
            Name = "Arli",
            Surname = "Muka"
        });

        students.Add(new Student
        {
            Grade = 10,
            Name = "Armir",
            Surname = "Keta"
        });

        students.Add(new Student
        {
            Grade = 4,
            Name = "Toni",
            Surname = "Montana"
        });

        students.Add(new Student
        {
            Grade = 6,
            Name = "Alis",
            Surname = "Poci"
        });

        students.Add(new Student
        {
            Grade = 8,
            Name = "Anri",
            Surname = "Loci"
        });

        students.Add(new Student
        {
            Grade = 5,
            Name = "Sadik",
            Surname = "Mino"
        });

        students.Add(new Student
        {
            Grade = 9,
            Name = "Lavi",
            Surname = "Baki"
        });

        students.Add(new Student
        {
            Grade = 7,
            Name = "Baci",
            Surname = "Bici"
        });

        /*students.Add(new Student
        {
            
        });*/

       // students.Add(new Student());

        // Loop to print all students and their grade for each.
        for (var i = 0; i < students.Count - 1; i++)
        {
            var student = students[i];

            if (student != null)
            {
                if (student.Grade > 9)
                {
                    Console.Write($"Student name is: {student.Name} {student.Surname} and his grade is:  {student.Grade} => ");
                    student.IsExcellent();
                }
                else if (student.Grade <= 9 && student.Grade > 4)
                {
                    Console.Write($"Student name is: {student.Name} {student.Surname} and his grade is:  {student.Grade} => ");
                    student.HavePassed();
                }
                else
                {
                    Console.Write($"Student name is: {student.Name} {student.Surname} and his grade is:  {student.Grade} => ");
                    student.HaveFailed();
                }
            }
            else
            {
                Console.WriteLine("Null people");
            }
        }


        // ordering
        Console.WriteLine(" ");
        Console.WriteLine("**********************************************************");
        Console.WriteLine("Ordering the List of students according to their Grade(ASC):");
        Console.WriteLine("**********************************************************");

        for (var i = 0; i < students.Count - 1; i++)
        {
            students.Sort((e1, e2) => e1.Grade.CompareTo(e2.Grade));
            

            var student = students[i];

            Console.WriteLine($"Student name is: {student.Name} {student.Surname} and his grade is:  {student.Grade}");
        }
        Console.WriteLine(" ");
        Console.WriteLine("******************************:");
        Console.WriteLine("Get the average of all grades:");
        Console.WriteLine("******************************:");

        var avg = students.Select(x => x.Grade).DefaultIfEmpty(0).Average();
        Console.WriteLine($"The average of all the grades is: {avg}");

    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Grade { get; set; }

        public Student()
        {
        }

        public Student(string name, string surname, int grade)
        {
            this.Name = name;
            this.Surname = surname;
            this.Grade = grade;
        }

        public void HavePassed()
        {
            Console.WriteLine("Congrats! You have passed!");
        }public void HaveFailed()
        {
            Console.WriteLine("Oh nooo! You have not passed this time! You have to try again!");
        }
        public void IsExcellent()
        {
            Console.WriteLine("Thumbs up - You belong to the ELITE ones!!!");
        }
    }
}