using System.Drawing;

namespace Advan.Feat.Exerc.Task5;

internal class Program
{
        static void Main(string[] args)
        {

        /*Dictionary<int, int> ItemCount = new Dictionary<int, int>();

        int[] items = { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };

        foreach (int item in items)
        {
            if (ItemCount.ContainsKey(item))
            {
                ItemCount[item]++;
            }
            else
            {
                ItemCount.Add(item, 1);
            }
        }

        Console.WriteLine("A|B");
        foreach (KeyValuePair<int, int> res in ItemCount)
        {
            Console.WriteLine(res.Key + "|" + res.Value);
        }*/

        int[] arr = new int[] { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };
        foreach (int i in arr.Distinct())
        {
            int count = occurance(arr, i);
            Console.WriteLine($"The number:{i} occurred: {count} times.");
        }

        Console.ReadLine();
    }

    public static int occurance(int[] arr, int x)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (x == num)
            {
                count++;
            }
        }
        return count;
    }
}

