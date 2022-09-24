//Write a program that enters file name with its full path (like: C:\myFolder\myFile.txt), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(). Be sure to catch all possible exceptions and print user friendly error message.

// Create a file with 3 lines.
//Create a method that reads file and edit it with 2 new lines(Text).Save the file in file system.
//Read updated file and check number of rows are 5.

namespace Advan.Feat.Exerc.Task4;
using System;
using System.IO;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Contents of the file found are: \n");
            //Pass the file path and file name to the StreamReader constructor
            StreamReader fileContent = new StreamReader("C:\\Users\\armir\\Desktop\\myfolder\\armir.txt");
            //Read the first line of text
            string line = fileContent.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                Console.WriteLine(line);
                //Read the next line
                line = fileContent.ReadLine();
            }
            Console.WriteLine("\n");
            fileContent.Close();
            // _ = Console.ReadLine();

            var lineCount0 = File.ReadLines(@"C:\Users\armir\Desktop\myfolder\armir.txt").Count();

            Console.WriteLine($"The total number of lines in this file at the moment are: {lineCount0}");

            StreamWriter sw = new StreamWriter("C:\\Users\\armir\\Desktop\\myfolder\\armir.txt", true);

            do
            {
                //Write a line of text
                sw.WriteLine("This is the 1st added line!");
                Console.WriteLine();
                //Write a second line of text
                sw.WriteLine("This is the 2nd added line!");

            }
            while (line != null);
            
            sw.Close();
            _ = Console.ReadLine();


            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(@"C:\Users\armir\Desktop\myfolder\armir.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("New contents of the file are: \n");
            foreach (string i in lines)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            var lineCount = File.ReadLines(@"C:\Users\armir\Desktop\myfolder\armir.txt").Count();

            Console.WriteLine($"The total number of lines in this file are: {lineCount}");

            Console.WriteLine("Press any key to exit. \n");
            _ = Console.ReadKey();

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}