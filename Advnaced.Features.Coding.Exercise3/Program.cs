namespace Advanced.Features.Coding.Shared;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> programmingLanguages = new Dictionary<string, int>();
        programmingLanguages.Add("Java", 3);
        programmingLanguages.Add("C++", 7);
        programmingLanguages.Add("C#", 5);
        programmingLanguages.Add("Javascript", 4);

        Helpers.PrintDictionary(programmingLanguages);  
    }
}