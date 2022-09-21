using System.Security.Cryptography.X509Certificates;

namespace Task2Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Please insert a number: ");
				int s = int.Parse(Console.ReadLine());

				if (s < 0)
				{
					throw new ArgumentOutOfRangeException();
				}
                Console.WriteLine($"SQRT of: {s} is: {s*s}");

            }
			catch (Exception ex)
			{

				Console.WriteLine("Invalid nr!");
				
			}
			finally
			{
				Console.WriteLine("All done!");
			}
        }
    }
}