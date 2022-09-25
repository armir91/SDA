using System.Drawing;

namespace Advan.Feat.Exerc.Task5;

internal class Program
{
    static void Main(string[] args)
    {
        // Creating a count variable
        var total = 0;

        // Creating an array of colors
        int[] numbers = { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };

        // Counting the total number of time blue appears
        // in the array
        

        // Displaying the count
        for(int i = 0; i < numbers.Length; i++)
        {
            total = numbers.Count(c => c == numbers[i]);

            Console.WriteLine($"The number {numbers[i]} occurs: {total} times!");

        }
    }
}