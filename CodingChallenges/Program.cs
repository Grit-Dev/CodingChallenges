using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
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

        if (pInputValue.Length != pInputValueComparison.Length)
        {
            return false;
        }

        int firstValueCount = 0;
        int secondValueCount = 0;

        for (int outerIndex = 0; outerIndex < pInputValueComparison.Length; outerIndex++)
        {
            char currentChar = pInputValue[outerIndex];

            for (int innerIndex = 0; innerIndex < pInputValueComparison.Length; innerIndex++)
            {

                if (pInputValueComparison[innerIndex] == currentChar)
                {
                    firstValueCount++;
                }

                if (pInputValue[innerIndex] == currentChar)
                {
                    secondValueCount++;
                }
            }

            if (firstValueCount != secondValueCount)
            {
                return false;
            }

            firstValueCount = 0;
            secondValueCount = 0;

        }



        return true;

    }

    public static int CountCharactersExceptSpaces(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                count++;
            }
        }

        return count;
    }

    public static string FindFirstNonRepeatingCharacter(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "_";
        }

        int count = 0;

        for (int outterIndex = 0; outterIndex < pInputValue.Length; outterIndex++)
        {
            char character = pInputValue[outterIndex];

            foreach (char characterTwo in pInputValue)
            {
                if (characterTwo == character)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                return character.ToString();
            }

            count = 0;
        }

        return "_";
    }

    public static char FindLastNonRepeatingCharacter(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return '_';
            }
        }

        int counter = 0;

        for (int outterIndex = pInputValue.Length -1; outterIndex >= 0; outterIndex--)
        {
            char character = pInputValue[outterIndex];

            for (int innerIndex = pInputValue.Length -1; innerIndex >= 0; innerIndex--)
            {
                if (character == pInputValue[innerIndex])
                {
                    counter++;
                }
            }

            if (counter == 1)
            {
                return character;
            }

            counter = 0;
        }

        return '_';
    }

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

    public static int CountWordOccurrences(string pInputValue, string pTargetString)
    {
        if (string.IsNullOrEmpty(pInputValue) || string.IsNullOrEmpty(pTargetString))
        {
            return 0;
        }

        int counter = 0;
        pInputValue = pInputValue.ToLower();
        pTargetString = pTargetString.ToLower();
        string [] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in stringSplit)
        {
            if (pTargetString == word)
            {
                counter++;
            }
        }

        return counter;

    }

    public static void Main(string[] args)
    {

        // 1. Count Characters Except Spaces
        //Console.WriteLine($"Hello World should return 10 => Answer: {CountCharactersExceptSpaces("Hello World") == 10}");
        //Console.WriteLine($" Cyberpunk Vault  should return 14 => Answer: {CountCharactersExceptSpaces(" Cyberpunk Vault ") == 14}");
        //Console.WriteLine($"Paul should return 4 => Answer: {CountCharactersExceptSpaces("Paul") == 4}");
        //Console.WriteLine($"Empty string should return 0 => Answer: {CountCharactersExceptSpaces("") == 0}");
        //Console.WriteLine($"Null should return 0 => Answer: {CountCharactersExceptSpaces(null!) == 0}");

        // 2. Are Strings Anagrams
        //Console.WriteLine($"listen and silent should return true => Answer: {AreStringsAnagrams("listen", "silent")}");
        //Console.WriteLine($"triangle and integral should return true => Answer: {AreStringsAnagrams("triangle", "integral")}");
        //Console.WriteLine($"hello and world should return false => Answer: {AreStringsAnagrams("hello", "world")}");
        //Console.WriteLine($"aab and aba should return true => Answer: {AreStringsAnagrams("aab", "aba")}");
        //Console.WriteLine($"aab and ab should return false => Answer: {AreStringsAnagrams("aab", "ab")}");
        //Console.WriteLine($"empty and empty should return true => Answer: {AreStringsAnagrams("", "")}");
        //Console.WriteLine($"null and test should return false => Answer: {AreStringsAnagrams(null!, "test")}");

        //// 3. Find First Non-Repeating Character
        //Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacter("swiss")}");
        //Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacter("hello")}");
        //Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacter("aabbc")}");
        //Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacter("aabb")}");
        //Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacter("")}");
        //Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacter(null!)}");

        //// 4. Find Last Non-Repeating Character
        //Console.WriteLine($"swiss should return i => Answer: {FindLastNonRepeatingCharacter("swiss")}");
        //Console.WriteLine($"hello should return o => Answer: {FindLastNonRepeatingCharacter("hello")}");
        //Console.WriteLine($"aabbc should return c => Answer: {FindLastNonRepeatingCharacter("aabbc")}");
        //Console.WriteLine($"aabb should return _ => Answer: {FindLastNonRepeatingCharacter("aabb")}");
        //Console.WriteLine($"Empty string should return _ => Answer: {FindLastNonRepeatingCharacter("")}");
        //Console.WriteLine($"Null should return _ => Answer: {FindLastNonRepeatingCharacter(null!)}");

        //// 5. Remove Consecutive Duplicate Characters
        //Console.WriteLine($"aaabbc should return abc => Answer: {RemoveConsecutiveDuplicateCharacters("aaabbc")}");
        //Console.WriteLine($"helloo should return helo => Answer: {RemoveConsecutiveDuplicateCharacters("helloo")}");
        //Console.WriteLine($"ababa should return ababa => Answer: {RemoveConsecutiveDuplicateCharacters("ababa")}");
        //Console.WriteLine($"a should return a => Answer: {RemoveConsecutiveDuplicateCharacters("a")}");
        //Console.WriteLine($"Empty string should return empty => Answer: {RemoveConsecutiveDuplicateCharacters("")}");
        //Console.WriteLine($"Null should return empty => Answer: {RemoveConsecutiveDuplicateCharacters(null!)}");

        //// 6. Optional Stretch: Count Word Occurrences
        Console.WriteLine($"hello world hello, target hello should return 2 => Answer: {CountWordOccurrences("hello world hello", "hello")}");
        Console.WriteLine($"Cyberpunk card vault, target card should return 1 => Answer: {CountWordOccurrences("Cyberpunk card vault", "card")}");
        Console.WriteLine($"one two three, target four should return 0 => Answer: {CountWordOccurrences("one two three", "four")}");
        Console.WriteLine($"HELLO hello HeLLo, target hello should return 3 => Answer: {CountWordOccurrences("HELLO hello HeLLo", "hello")}");
        Console.WriteLine($"Null sentence should return 0 => Answer: {CountWordOccurrences(null!, "hello")}");
        Console.WriteLine($"Null target should return 0 => Answer: {CountWordOccurrences("hello world", null!)}");
    }
}
