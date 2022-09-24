namespace AdvancedFeatures.AsynchronusExample;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lista:");

        ClassRoom classRoom1 = new ClassRoom();
        var classRoom = classRoom1;
        classRoom.Peoples = new List<People>
        {
            new People
            {
                Name = "Armir",
                Age = 31
            },

            new People
            {
                Name = "Reni",
                Age = 27
            },

            new People
            {
                Name = "Serin",
                Age = 32
            },

            new People
            {
                Name = "Topi",
                Age = 13
            }
        };


        var peopleBiggerThan22 = classRoom1.Peoples.Where(x => x.Age > 22);

        foreach (var people in peopleBiggerThan22)
        {
            Console.WriteLine(people.Name);
        }

        _ = classRoom1.GetPeoplesBiggerThanAsync(22);
        _ = Console.ReadLine();

    }

    public class ClassRoom
    {
        public List<People> Peoples { get; set; }

        public List<People> GetPeoplesBiggerThan(int age)
        {
            return Peoples.Where(x=> x.Age > age).ToList();
        }

        public async Task<List<People>> GetPeoplesBiggerThanAsync(int age)
        {
            return await Task.Run(async() =>
            {
                await Task.Delay(1000);
                //Thread.Sleep(2000);
                Console.WriteLine("This is going to run late");
                return GetPeoplesBiggerThan(age);
            });
        }

        /*public async List<People>> GetPeoplesBiggerThan(int age)
        {
              return await Peoples.Where(x=> x.Age > age).ToListAsync();
        }*/
    }

    public class People
    {
        public int Age { get; set; }
        public string? Name { get; set; }
    }
}