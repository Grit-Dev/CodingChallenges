using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    //PMG TODO: This is wrong. Need to come up with a new way to complete this challenge
    public static bool AreStringsAnagrams(string pInputValue, string pInputValueComparison)
    {
        if (pInputValue == null || pInputValueComparison == null)
        {
            return false;
        }

        if (pInputValue == "" && pInputValueComparison == "")
        {
            return true;
        }

        List<char> charsListOfInputValue = [];

        foreach (char character in pInputValue)
        {
            charsListOfInputValue.Add(character);
        }

        foreach (char character in pInputValueComparison)
        {
            if (!charsListOfInputValue.Contains(character))
            {
                return false;
            }
        }

        return true;
    }
    public static void Main(string[] args)
    {
        // Optional Stretch: Are Strings Anagrams - Need a new solution - Next Days coding challenge:
        Console.WriteLine($"listen and silent should return true => Answer: {AreStringsAnagrams("listen", "silent") == true}");
        Console.WriteLine($"triangle and integral should return true => Answer: {AreStringsAnagrams("triangle", "integral") == true}");
        Console.WriteLine($"hello and world should return false => Answer: {AreStringsAnagrams("hello", "world") == false}");
        Console.WriteLine($"APPLE and PAPEL should return true if case-insensitive => Answer: {AreStringsAnagrams("APPLE", "PAPEL") == true}");
        Console.WriteLine($"empty and empty should return true => Answer: {AreStringsAnagrams("", "") == true}");
        Console.WriteLine($"null and test should return false => Answer: {AreStringsAnagrams(null!, "test") == false}");
        Console.WriteLine($"test and null should return false => Answer: {AreStringsAnagrams("test", null!) == false}");

        /*
            NEXT CHALLENGES

            Rules:
            - No LINQ
            - No .Where()
            - No .Select()
            - No .Count()
            - No .Sum()
            - No .Max()
            - No .Min()
            - No .OrderBy()
            - No .Sort()
            - No .Reverse()
            - No .Distinct()
            - No Dictionary / HashSet unless told
            - No AI/Copilot code completion

            1. Warm-up: Count Characters Except Spaces

            * Return how many characters are in a string, excluding spaces.
            * Example: "Hello World" -> 10
            * Example: " Cyberpunk Vault " -> 14
            * Example: "Paul" -> 4
            * Return 0 for null or empty.
            * Use char.IsWhiteSpace(character).

            2. Revision: Are Strings Anagrams

            * Return true if both strings contain the same characters with the same counts.
            * Example: "listen", "silent" -> true
            * Example: "triangle", "integral" -> true
            * Example: "hello", "world" -> false
            * Example: "aab", "aba" -> true
            * Example: "aab", "ab" -> false
            * Return false if either string is null.
            * "" and "" -> true.
            * Use the count-each-character approach.
            * Do not use Sort, LINQ, Dictionary, or HashSet.

            3. Revision: Find First Non-Repeating Character

            * Return the first character that appears only once.
            * Example: "swiss" -> 'w'
            * Example: "hello" -> 'h'
            * Example: "aabbc" -> 'c'
            * Example: "aabb" -> '_'
            * Return '_' for null or empty.
            * Use nested loops.
            * Case-insensitive comparison.

            4. New Challenge: Find Last Non-Repeating Character

            * Return the last character that appears only once.
            * Example: "swiss" -> 'i'
            * Example: "hello" -> 'o'
            * Example: "aabbc" -> 'c'
            * Example: "aabb" -> '_'
            * Return '_' for null or empty.
            * Use nested loops.
            * Loop from the end of the string.
            * Case-insensitive comparison.

            5. New Challenge: Remove Consecutive Duplicate Characters

            * Return a string where consecutive duplicate characters are reduced to one.
            * Example: "aaabbc" -> "abc"
            * Example: "helloo" -> "helo"
            * Example: "ababa" -> "ababa"
            * Example: "a" -> "a"
            * Return "" for null or empty.
            * Key idea:
                - Track the previous character.
                - Add the current character only if it is different from the previous one.

            6. Optional Stretch: Count Word Occurrences

            * Return how many times a target word appears in a sentence.
            * Example: "hello world hello", target "hello" -> 2
            * Example: "Cyberpunk card vault", target "card" -> 1
            * Example: "one two three", target "four" -> 0
            * Return 0 for null or empty sentence.
            * Return 0 if target is null or empty.
            * Split is allowed for this version.
            * Make it case-insensitive.
        */
    }
}
