using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    // PMG TODO: Redo - Bug: 
    public static string RemoveConsecutiveDuplicateCharacters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        List<char> newList = [];
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char character in pInputValue)
        {
            if (!newList.Contains(character))
            {
                newList.Add(character);
                stringBuilder.Append(character);
            }
        }

        return stringBuilder.ToString();
    }

    public static void Main(string[] args)
    {
        //// 5. Remove Consecutive Duplicate Characters - BUG Challenge
        //Console.WriteLine($"aaabbc should return abc => Answer: {RemoveConsecutiveDuplicateCharacters("aaabbc")}");
        //Console.WriteLine($"helloo should return helo => Answer: {RemoveConsecutiveDuplicateCharacters("helloo")}");
        //Console.WriteLine($"ababa should return ababa => Answer: {RemoveConsecutiveDuplicateCharacters("ababa")}");
        //Console.WriteLine($"a should return a => Answer: {RemoveConsecutiveDuplicateCharacters("a")}");
        //Console.WriteLine($"Empty string should return empty => Answer: {RemoveConsecutiveDuplicateCharacters("")}");
        //Console.WriteLine($"Null should return empty => Answer: {RemoveConsecutiveDuplicateCharacters(null!)}");

        /*
            NEXT CHALLENGES

            1. Warm-up: Count Punctuation Characters

            * Return how many punctuation characters are in a string.
            * Use char.IsPunctuation(character).
            * Example: "Hello!" -> 1
            * Example: "Wait... what?" -> 4
            * Example: "abc123" -> 0
            * Return 0 for null or empty.

            2. Revision: Remove Consecutive Duplicate Characters

            * Return a string where consecutive duplicate characters are reduced to one.
            * Example: "aaabbc" -> "abc"
            * Example: "helloo" -> "helo"
            * Example: "ababa" -> "ababa"
            * Return "" for null or empty.
            * Compare current character to previous character.

            3. Revision: Are Strings Anagrams

            * Return true if both strings contain the same characters with the same counts.
            * Example: "listen", "silent" -> true
            * Example: "aab", "aba" -> true
            * Example: "aab", "ab" -> false
            * Make it case-insensitive.
            * Do not use Sort, LINQ, Dictionary or HashSet.

            4. New Challenge: Count Character Groups

            * Return how many consecutive character groups are in a string.
            * Example: "aaabbc" -> 3 because aaa, bb, c
            * Example: "helloo" -> 4 because h, e, ll, oo
            * Example: "ababa" -> 5
            * Return 0 for null or empty.

            5. New Challenge: Get Initials From Name

            * Return the initials from a full name.
            * Example: "Paul McGinley" -> "PM"
            * Example: "john ronald reuel tolkien" -> "JRRT"
            * Example: "  cyberpunk   vault  " -> "CV"
            * Return "" for null or empty.
            * Split is allowed.

            6. Optional Stretch: Is Pangram

            * Return true if a sentence contains every letter a-z at least once.
            * Example: "The quick brown fox jumps over the lazy dog" -> true
            * Example: "Hello world" -> false
            * Return false for null or empty.
            * No LINQ, Dictionary, or HashSet.
        */
    }
}
