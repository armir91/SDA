namespace Advanced.Features.Coding.Shared;

public class Helpers
{
    public static List<string> ListMethod(List<string> names)
    {
        return names.OrderByDescending(name => name).ToList();
    }
    
    public static List<string> ListMethodCase(List<string> names)
    {
        return names.OrderByDescending(name => name, StringComparer.OrdinalIgnoreCase).ToList();
    }
    
    public static void PrintDictionary(Dictionary<string, int> programmingLanguages)
    {
        for (var i = 0; i < programmingLanguages.Count; i++)
        {
            var pair = programmingLanguages.ElementAt(i);

            /*if (i<programmingLanguages.Count - 2)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value},");
            }
            else
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}.");
            }*/

            var stringValue = $"Key: {pair.Key}, Value: {pair.Value}";
            stringValue = (i == programmingLanguages.Count - 1) ? $"{stringValue}." : $"{stringValue},";
            Console.WriteLine(stringValue);
        }
    }
}