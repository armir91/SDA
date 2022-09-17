using System.Security.Cryptography.X509Certificates;

namespace AdvancedFeatures.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid number: ");
            string s = Console.ReadLine();
            try
            {
                double a = int.Parse(s!);
                Console.WriteLine("You entered a valid number!");


                double v = Sqrt(a);
                Console.WriteLine($"Sqrt of {a} is: {v}.");
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Invalid integer nr!");
                throw;

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The number is too big");
               // throw;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
              //  throw;

            }
            catch
            {
                Console.WriteLine("Exception");

                // throw;
            }
            finally
            {
                Console.WriteLine("All done!");
            }
            Console.WriteLine("Code executed after try-finally");
        }

        private static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Sqrt for negative nr is undefined!");

            }
            return Math.Sqrt(value);
        }
    }
}