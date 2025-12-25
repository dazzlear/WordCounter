using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--WORD COUNTER(Words, Vowels, Consonants, & Numbers)--");
        Console.WriteLine("Type a sentence to count words.");
        Console.WriteLine("Type 'exit' to quit.\n");

        while (true)
        {
            // User input
            Console.Write("Input: ");
            string input = Console.ReadLine() ?? "";

            if (input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            // Count words only (split by whitespace)
            int wordCount = input
                .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            int vowelCount = 0;
            int consonantCount = 0;
            int numberCount = 0;

            // Count vowels, consonants, and numbers
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    numberCount++;
                }
                else if (char.IsLetter(ch))
                {
                    char lower = char.ToLower(ch);

                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                        vowelCount++;
                    else
                        consonantCount++;
                }
                // ignore spaces, punctuation, symbols
            }

            Console.WriteLine($"Wodss counttt  : {wordCount}");
            Console.WriteLine($"Vowel count     : {vowelCount}");
            Console.WriteLine($"Consonant count : {consonantCount}");
            Console.WriteLine($"Number count    : {numberCount}\n");
        }

        Console.WriteLine("Goodbye!");
    }
}
