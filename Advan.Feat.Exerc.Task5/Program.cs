using System.Drawing;

namespace Advan.Feat.Exerc.Task5;

internal class Program
{
        static void Main(string[] args)
        {
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

