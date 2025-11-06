using System;

namespace SimplePrintingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Printing Console Application";

            // Header
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("     SIMPLE PRINTING CONSOLE APP");
            Console.WriteLine("======================================\n");
            Console.ResetColor();

            // Personal Details printed directly (no variables)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Personal Details ===");
            Console.ResetColor();
            Console.WriteLine("Name: Nikesh Bhattarai");
            Console.WriteLine("Address: Kathmandu, Nepal");
            Console.WriteLine("Contact Number: +977-976-2882561");
            Console.WriteLine("College: Itahari International College");
            Console.WriteLine("========================\n");

            // Call the second class for motivational quote
            MotivationalQuote quote = new MotivationalQuote();
            quote.PrintQuote();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to exit...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }

    // Second class (uses variables)
    class MotivationalQuote
    {
        public void PrintQuote()
        {
            // Using variables to store data
           string quoteOfTheDay = "“Believe you can and you're halfway there.”";
            string author = "- Theodore Roosevelt";
            string date = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== Motivational Quote of the Day ===");
            Console.ResetColor();
            Console.WriteLine($"Date: {date}\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(quoteOfTheDay);
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
}
