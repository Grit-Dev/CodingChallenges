using System.Diagnostics.Metrics;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        /*
            NEXT CHALLENGES

            1. Warm-up / Revision: Find First Word With All Unique Letters

            * Return the first word containing no repeated letters.
            * Example: "hello apple cat dog" -> "cat"
            * Example: "book moon tree" -> ""
            * Example: "Apple SUN hello" -> "SUN"
            * Return "" for null or empty.
            * Case-insensitive comparison.
            * Preserve original casing.
            * Split is allowed.
            * Use nested loops.
            * No HashSet or Dictionary.

            --------------------------------------------------

            2. Revision: Count Words With Repeated Letters

            * Return how many words contain at least one repeated letter.
            * Example: "hello world cat" -> 1
            * Example: "apple banana dog" -> 2
            * Example: "cat dog sun" -> 0
            * Return 0 for null or empty.
            * Case-insensitive.
            * Use nested loops.
            * Stop checking each word as soon as a repeated letter is found.
            * Do not use List<char>, HashSet, or Dictionary.

            --------------------------------------------------

            3. Revision: Find Word With Most Unique Characters

            * Return the word with the highest number of unique characters.
            * Example: "abc abcd" -> "abcd"
            * Example: "apple banana card" -> "apple"
            * Example: "HELLO CyberPunk world" -> "CyberPunk"
            * If tied, return the first word.
            * Case-insensitive comparison.
            * Preserve original casing.
            * Return "" for null or empty.
            * You may use List<char>.Contains().
            * Remember: each word needs its own fresh character tracking.

            --------------------------------------------------

            4. New Challenge: Count Words With More Unique Than Repeated Characters

            * Return how many words have more unique characters than repeated character occurrences.

            * Example:
              "cat hello book"

              cat:
              unique characters = 3
              repeated occurrences = 0

              hello:
              unique characters = 4
              repeated occurrences = 1

              book:
              unique characters = 3
              repeated occurrences = 1

              Result -> 3

            * Return 0 for null or empty.
            * Case-insensitive.
            * Split is allowed.
            * You may use List<char>.
            * No LINQ, Dictionary, or HashSet.

            --------------------------------------------------

            5. New Challenge: Find Word With Highest Repeated Character Count

            * Return the word containing the greatest number of repeated character occurrences.

            * Example:
              "cat hello mississippi" -> "mississippi"

            * Example:
              "book moon tree" -> "book"

              If tied, return the first word.

            * Example:
              "cat dog sun" -> "cat"

              All have 0 repeated occurrences, so return the first word.

            * Case-insensitive comparison.
            * Preserve original casing.
            * Return "" for null or empty.
            * No LINQ, Dictionary, or HashSet.

            --------------------------------------------------

            6. Optional Stretch: Find Most Frequent Word Length And Count

            * Return the most common word length and how many times it occurs.

            * Example:
              "cat dog sun elephant"
              -> "Length:3 Count:3"

            * Example:
              "I am Paul John"
              -> "Length:4 Count:2"

            * If tied, use the first word length encountered.
            * Return "" for null or empty.
            * Split is allowed.
            * Use StringBuilder for the formatted result.
            * No LINQ or Dictionary.
        */
    }
}
