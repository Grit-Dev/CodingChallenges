using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        /*
            NEXT CHALLENGES

            1. Warm-up / Pattern Revision: Count Words With All Unique Letters

            * Return how many words contain no repeated letters.
            * Example: "cat dog hello" -> 2 because cat and dog have no repeated letters.
            * Example: "apple banana sun" -> 1 because only sun has all unique letters.
            * Example: "book moon tree" -> 0
            * Return 0 for null or empty.
            * Case-insensitive.
            * Split is allowed.
            * No HashSet or Dictionary.

            --------------------------------------------------

            2. Revision: Count Words With Repeated Letters

            * Return how many words contain at least one repeated letter.
            * Example: "hello world cat" -> 1
            * Example: "apple banana dog" -> 2
            * Example: "cat dog sun" -> 0
            * Example: "book moon tree" -> 3
            * Return 0 for null or empty.
            * Case-insensitive.
            * Split is allowed.
            * Use nested loops.
            * Stop checking a word once you know it has a repeated letter.

            --------------------------------------------------

            3. Revision: Remove Duplicate Words Preserve Order

            * Return a sentence with duplicate words removed.
            * Preserve the first occurrence of each word.
            * Comparison must be case-insensitive.
            * Preserve the original casing of the first occurrence.

            * Example:
              "Hello world HELLO" -> "Hello world"

            * Example:
              "Cyberpunk card vault CARD card" -> "Cyberpunk card vault"

            * Example:
              "Apple apple APPLE banana" -> "Apple banana"

            * Return "" for null or empty.
            * Split is allowed.
            * Use List<string>.
            * No LINQ or HashSet.

            --------------------------------------------------

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
    }
}
