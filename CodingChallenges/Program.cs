using System.Diagnostics.Metrics;
using System.Text;

public class Program
{
    public static int CountWordsWithAllUniqueLetters(string pInputValue)
    {
        if (string.IsNullOrWhiteSpace(pInputValue))
        {
            return 0;
        }

        StringBuilder newStringFormed = new();
        string[] newStringArray = pInputValue.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int totalUniqueCountHolder = 0;
        bool isUniqueWord = true;

        foreach (string word in newStringArray)
        {
;
            for (int outterIndex = 0; outterIndex <= word.Length - 1; outterIndex++)
            {
                char currentChar = word[outterIndex];

                for (int innerIndex = outterIndex + 1; innerIndex <= word.Length - 1; innerIndex++)
                {
                    char innerChar = word[innerIndex];

                    if (currentChar == innerChar)
                    {
                        isUniqueWord = false;
                        break;
                    }
                }

                if (!isUniqueWord)
                {
                    break;
                }

            }

            if (isUniqueWord)
            {
                totalUniqueCountHolder++;
            }

            isUniqueWord = true;

        }

            return totalUniqueCountHolder;

    }

    public static int CountWordsWithRepeatedLetters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        string[] newStringArray = pInputValue.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<char> newListOfChars = [];
        int counter = 0;
        int totalCounter = 0;

        foreach (string word in newStringArray)
        {
            foreach (char currentChar in word)
            {
                if (!newListOfChars.Contains(currentChar))
                {
                    newListOfChars.Add(currentChar);
                }
                else
                {
                    counter++;
                }
            }

            if (counter >=1)
            {
                totalCounter++;
            }

            newListOfChars.Clear();
            counter = 0;
        }

        return totalCounter;


    }

    public static string RemoveDuplicateWordsPreserveOrder(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newStringToBeReturned = new();
        string[] newStringArray = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> newListOfString = [];

        foreach (string word in newStringArray)
        {
            string wordLowered = word.ToLower();

            if (!newListOfString.Contains(wordLowered))
            {
                newListOfString.Add(wordLowered);
                newStringToBeReturned.Append(word + ' ');
            }
        }

        return newStringToBeReturned.ToString().Trim();
    }

    public static string FindWordWithMostUniqueCharacters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        List<char> newListChar = [];
        string highestUniqueCharacterCountString = "";
        int counter = 0;
        int highestUniqueWordCounter = int.MinValue;
        string[] newStringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in newStringSplit)
        {
            foreach (char character in word)
            {
                char characterLowered = char.ToLower(character);

                if (!newListChar.Contains(characterLowered))
                {
                    newListChar.Add(characterLowered);
                    counter++;
                }
            }

            if (counter > highestUniqueWordCounter)
            {
                highestUniqueWordCounter = counter;
                highestUniqueCharacterCountString = word;
            }

            counter = 0;
        }

        return highestUniqueCharacterCountString;
    }



    public static void Main(string[] args)
    {
        // Find Word With Most Unique Characters
        Console.WriteLine(FindWordWithMostUniqueCharacters("apple banana card")); // apple
        Console.WriteLine(FindWordWithMostUniqueCharacters("cat dog sun"));       // cat
        Console.WriteLine(FindWordWithMostUniqueCharacters("HELLO CyberPunk world")); // CyberPunk
        Console.WriteLine(FindWordWithMostUniqueCharacters(""));                  // ""
        Console.WriteLine(FindWordWithMostUniqueCharacters(null!));               // ""

        /*
            4. New Challenge: Find Word With Most Unique Characters

            * Return the word containing the highest number of different characters.
            * Comparison should be case-insensitive.
            * Preserve the original casing of the returned word.

            * Example:
              "hello world cyberpunk" -> "cyberpunk"

            * Example:
              "apple banana card" -> "card"

            * If tied, return the first word with the highest count.
            * Return "" for null or empty.
            * Split is allowed.
            * You may use List<char>.Contains().
            * No LINQ, Dictionary, or HashSet.

            --------------------------------------------------

            5. New Challenge: Find Most Common Word Length

            * Return the word length that appears most frequently.

            * Example:
              "cat dog sun elephant" -> 3

              Because:
              cat = 3
              dog = 3
              sun = 3
              elephant = 8

            * Example:
              "I am Paul John" -> 4

              Because:
              I = 1
              am = 2
              Paul = 4
              John = 4

            * If tied, return the first word length that reached the highest frequency.
            * Return 0 for null or empty.
            * Split is allowed.
            * No LINQ or Dictionary.

            --------------------------------------------------

            6. Optional Stretch / Important Revision:
               Find Most Frequent Character In Each Word

            * Return each word followed by its most frequent character.

            * Example:
              "hello world" -> "hello:l world:w"

            * Example:
              "mississippi card" -> "mississippi:i card:c"

            * Example:
              "cat dog sun" -> "cat:c dog:d sun:s"

            * Comparison is case-insensitive.
            * Preserve the original character casing in the result.
            * If characters tie, return the first character to appear in that word.
            * Return "" for null or empty.
            * Split is allowed.
            * No LINQ, Dictionary, or HashSet.
        */

        // Count Words With All Unique Letters
        // Notes: Debugged this to find the solution - Needs more Revision (Est: 40 minutes)
        //Console.WriteLine(CountWordsWithAllUniqueLetters("cat dog hello"));        // 2
        //Console.WriteLine(CountWordsWithAllUniqueLetters("apple banana sun"));     // 1
        //Console.WriteLine(CountWordsWithAllUniqueLetters("book moon tree"));       // 0
        //Console.WriteLine(CountWordsWithAllUniqueLetters("Cat DOG hello"));        // 2
        //Console.WriteLine(CountWordsWithAllUniqueLetters(""));                     // 0
        //Console.WriteLine(CountWordsWithAllUniqueLetters(null!));                   // 0

        // Count Words With Repeated Letters
        Console.WriteLine(CountWordsWithRepeatedLetters("hello world cat"));       // 1
        Console.WriteLine(CountWordsWithRepeatedLetters("apple banana dog"));      // 2
        Console.WriteLine(CountWordsWithRepeatedLetters("cat dog sun"));           // 0
        Console.WriteLine(CountWordsWithRepeatedLetters("book moon tree"));        // 3
        Console.WriteLine(CountWordsWithRepeatedLetters("HELLO Cat DOG"));         // 1
        Console.WriteLine(CountWordsWithRepeatedLetters(""));                      // 0
        Console.WriteLine(CountWordsWithRepeatedLetters(null!));                    // 0

        // Remove Duplicate Words Preserve Order
        Console.WriteLine(RemoveDuplicateWordsPreserveOrder("Hello world HELLO")); // Hello world
        Console.WriteLine(RemoveDuplicateWordsPreserveOrder("Cyberpunk card vault CARD card"));// Cyberpunk card vault
        Console.WriteLine(RemoveDuplicateWordsPreserveOrder("Apple apple APPLE banana")); // Apple banana
        Console.WriteLine(RemoveDuplicateWordsPreserveOrder("cat dog cat sun DOG"));// cat dog sun
        Console.WriteLine(RemoveDuplicateWordsPreserveOrder("")); // ""
        Console.WriteLine(RemoveDuplicateWordsPreserveOrder(null!)); // ""
    }
}
