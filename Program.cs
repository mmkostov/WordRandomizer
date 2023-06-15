using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Prompt a number from 3 to 10
        int number = PromptNumber();

        // Load dictionary words of the same length as the number
        List<string> words = LoadDictionaryWords(number);

        // Select a random word
        Random random = new Random();
        string randomWord = words[random.Next(words.Count)];

        Console.WriteLine($"Random word of length {number} is: {randomWord}");
    }

    static int PromptNumber()
    {
        int number;
        do
        {
            Console.Write("Enter a number from 3 to 10: ");
        } while (!int.TryParse(Console.ReadLine(), out number) || number < 3 || number > 10);

        return number;
    }

    static List<string> LoadDictionaryWords(int length)
    {
        string dictionaryFilePath = "dictionary.txt";
        //Za g-n Kunis, moje da go smenite s neshto drugo

        List<string> words = new List<string>();

        using (StreamReader reader = new StreamReader(dictionaryFilePath))
        {
            string word;
            while ((word = reader.ReadLine()) != null)
            {
                if (word.Length == length)
                {
                    words.Add(word);
                }
            }
        }

        return words;
    }
}
