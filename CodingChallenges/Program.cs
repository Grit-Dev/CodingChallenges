using System.Globalization;
using System.Text;

public class Program
{
    public static int CountLettersOnly(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character))
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Letters Only
        Console.WriteLine($"abc123! should return 3 => Answer: {CountLettersOnly("abc123!")}");
        Console.WriteLine($"Cyberpunk 2077 should return 9 => Answer: {CountLettersOnly("Cyberpunk 2077")}");
        Console.WriteLine($"12345 should return 0 => Answer: {CountLettersOnly("12345")}");
        Console.WriteLine($"Empty string should return 0 => Answer: {CountLettersOnly("")}");
        Console.WriteLine($"Null should return 0 => Answer: {CountLettersOnly(null!)}");

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

            1. Count Letters Only

            * Return how many letters are in a string.
            * Letters means char.IsLetter(character).
            * Example: "abc123!" -> 3
            * Example: "Cyberpunk 2077" -> 9
            * Example: "12345" -> 0
            * Return 0 for null or empty.

            2. Revision: Compress Consecutive Repeated Characters

            * Return a compressed string based on consecutive repeated characters.
            * Example: "aaabbc" -> "a3b2c1"
            * Example: "hello" -> "h1e1l2o1"
            * Example: "ababa" -> "a1b1a1b1a1"
            * Example: "a" -> "a1"
            * Return "" for null or empty.
            * Key idea:
                - Track currentChar
                - Track count
                - When the character changes, append old character + count
                - Handle the final character after the loop

            3. Revision: Find First Non-Repeating Character

            * Return the first character that appears only once.
            * Example: "swiss" -> 'w'
            * Example: "hello" -> 'h'
            * Example: "aabbc" -> 'c'
            * Example: "aabb" -> '_'
            * Return '_' for null or empty.
            * Use nested loops.
            * Case-insensitive.

            4. New Challenge: Remove Duplicate Characters Preserve Order

            * Return a new string with duplicate characters removed.
            * Keep the first time each character appears.
            * Example: "hello" -> "helo"
            * Example: "swiss" -> "swi"
            * Example: "Cyberpunk" -> "Cyberpunk"
            * Return "" for null or empty.
            * Use a loop and StringBuilder.
            * You may use .Contains() for now.

            5. New Challenge: Find Longest Word

            * Return the longest word itself, not the length.
            * Example: "Cyberpunk card vault" -> "Cyberpunk"
            * Example: "I am Paul" -> "Paul"
            * Example: "one three seven" -> "three"
            * Return "" for null or empty.
            * Split is allowed for this version.
            * If tied, return the first longest word.

            6. Optional Stretch: Are Strings Anagrams

            * Return true if two strings contain the same letters in a different/same order.
            * Example: "listen", "silent" -> true
            * Example: "triangle", "integral" -> true
            * Example: "hello", "world" -> false
            * Return false if either is null.
            * "" and "" -> true.
            * Do not use Sort or LINQ.
            * This is harder. Save it for last.
        */
    }
}
