using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--WORD COUNTER (Words only)--");
        Console.WriteLine("Type a sentence to count words.");
        Console.WriteLine("Type 'exit' to quit.\n");

        while (true)
        {
            // User input
            Console.Write("Input: ");
            string input = Console.ReadLine() ?? "";

            if (input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            // Count words only
            int wordCount = input
                .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            Console.WriteLine($"Word count: {wordCount}\n");
        }

        Console.WriteLine("Goodbye!");
    }
}