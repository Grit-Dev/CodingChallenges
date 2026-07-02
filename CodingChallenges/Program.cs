using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    public static int CountSymbols(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsSymbol(character) || char.IsPunctuation(character))
            {
                counter++;
            }
        }

        return counter;
    }

    // ChatGpt: We need to add this into the next phase please as missed a 
    // lot in this one.
    public static bool AreAnagrams(string pInputValue, string pTargetValue)
    {
        if (pInputValue == null && pTargetValue == null)
        {
            return false;
        }

        if (pInputValue == "" || pTargetValue == "")
        {
            return true;
        }

        if (pInputValue.Length != pTargetValue.Length)
        {
            return false;
        }

        int firstCounter = 0;
        int secondCounter = 0;

        pInputValue = pInputValue.ToLower();
        pTargetValue = pTargetValue.ToLower();

        for (int outterIndex = 0; outterIndex <= pInputValue.Length - 1; outterIndex++)
        {
            char currentChar = pInputValue[outterIndex];

            for (int innerIndex = 0; innerIndex <= pTargetValue.Length - 1; innerIndex++)
            {
                if (currentChar == pTargetValue[innerIndex])
                {
                    firstCounter++;
                }

                if (pInputValue[innerIndex] == currentChar)
                {
                    secondCounter++;
                }
            }

            if (firstCounter != secondCounter)
            {
                return false;
            }

            firstCounter = 0;
            secondCounter = 0;
        }

        return true;
    }

    public static int CountCharacterGroupsConsecutively(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 1;
        char previousCharacter = pInputValue[0];

        foreach (char character in pInputValue)
        {
            if (previousCharacter != character)
            {
                counter++;
            }

            previousCharacter = character;
        }

        return counter;
    }

    public static string GetFirstLetters(string pinputValue)
    {
        if (string.IsNullOrEmpty(pinputValue))
        {
            return "";
        }

        StringBuilder newStringBuilder = new();
        string[] stringSplit = pinputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSplit)
        {
            newStringBuilder.Append(word[0]);
        }

        return newStringBuilder.ToString();
    }

    public static string GetLastLetters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newStringBuilder = new();
        string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSplit)
        {
            newStringBuilder.Append(word[^1]);
        }

        return newStringBuilder.ToString();


    }

    public static int CountUniqueCharacters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        List<char> newList = [];
        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (!newList.Contains(character))
            {
                newList.Add(character);
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        //  Count Unique characters
        // Return how many different characters appear in a string. 
        // Example Hello => h,e,l,o => 4
        // Example aabbcc > 3
        // Example Swiss => 3 s,w,i
        Console.WriteLine(CountUniqueCharacters("Hello"));         // 4
        Console.WriteLine(CountUniqueCharacters("aabbcc"));        // 3
        Console.WriteLine(CountUniqueCharacters("Swiss"));         // 3
        Console.WriteLine(CountUniqueCharacters("abcde"));         // 5
        Console.WriteLine(CountUniqueCharacters("aaaa"));          // 1
        Console.WriteLine(CountUniqueCharacters(""));             // 0
        Console.WriteLine(CountUniqueCharacters(null));           // 0
        Console.WriteLine(CountUniqueCharacters("Mississippi"));  // 4
        Console.WriteLine(CountUniqueCharacters("112233"));       // 3
        Console.WriteLine(CountUniqueCharacters("CSharp"));       // 6

        // Completed ==================================================================

        // Get Last letters of each word.
        // Return a string made from the first letter of each word
        // Example:  Hello World => hw
        // Return "" for null or empty
        // Console.WriteLine(GetLastLetters("Hello World"));                     // od
        // Console.WriteLine(GetLastLetters("Paul McGinley"));                   // ly
        // Console.WriteLine(GetLastLetters("John Ronald Reuel Tolkien"));       //
        // Console.WriteLine(GetLastLetters("Single"));                          // e
        // Console.WriteLine(GetLastLetters(""));                                // ""
        // Console.WriteLine(GetLastLetters(null!));                              // ""
        // Console.WriteLine(GetLastLetters("   Hello    World   "));            // od
        // Console.WriteLine(GetLastLetters("The Quick Brown Fox"));             // eknx
        // Console.WriteLine(GetLastLetters("One Two Three Four Five"));         // eoere
        // Console.WriteLine(GetLastLetters("A B C D"));                         // abcd
        // Console.WriteLine(GetLastLetters("Programming Challenges"));          // gs
        // Console.WriteLine(GetLastLetters("Red Green Blue"));                  // den
        // Console.WriteLine(GetLastLetters("Test"));                            // t

        // Get First Letters of Each word
        // Return a string made from the first letter of each word
        // Example:  Hello World => hw
        //Return "" for null or empty
        // Console.WriteLine(GetFirstLetters("Hello World"));                     // hw
        // Console.WriteLine(GetFirstLetters("Paul McGinley"));                   // pm
        // Console.WriteLine(GetFirstLetters("John Ronald Reuel Tolkien"));       // jrrt
        // Console.WriteLine(GetFirstLetters("Single"));                          // s
        // Console.WriteLine(GetFirstLetters(""));                                // ""
        // Console.WriteLine(GetFirstLetters(null!));                              // ""
        // Console.WriteLine(GetFirstLetters("   Hello    World   "));            // hw
        // Console.WriteLine(GetFirstLetters("The Quick Brown Fox"));             // tqbf
        // Console.WriteLine(GetFirstLetters("One Two Three Four Five"));         // ottff

        // Warm Up: Count Symbols:
        // - Return how many sysmbols characters are in a string. 
        // -  "C# costs £10" -> 2 depending on symbol handling. 
        // - Return 0 for null or empty.

        // Note: I added punctation into mix
        // Console.WriteLine(CountSymbols("C# costs £10"));          // 2
        // Console.WriteLine(CountSymbols("Hello World"));           // 0
        // Console.WriteLine(CountSymbols("$100"));                 // 1
        // Console.WriteLine(CountSymbols("@#$"));                  // 3
        // Console.WriteLine(CountSymbols("! Hello ?"));            // 2
        // Console.WriteLine(CountSymbols(""));                     // 0
        // Console.WriteLine(CountSymbols(null!));                   // 0
        // Console.WriteLine(CountSymbols("12345"));                // 0
        // Console.WriteLine(CountSymbols("C# & .NET"));            // 3
        // Console.WriteLine(CountSymbols("50% off!"));             // 2

        // Revision Count character groups
        // Return how many consecutive character groups are in a string
        // Example: "aaabc" => 3
        // Example: "Helloo" => 4
        // Console.WriteLine(CountCharacterGroupsConsecutively("aaabc"));          // 3
        // Console.WriteLine(CountCharacterGroupsConsecutively("Helloo"));         // 4
        // Console.WriteLine(CountCharacterGroupsConsecutively("a"));              // 1
        // Console.WriteLine(CountCharacterGroupsConsecutively("aaaa"));           // 1
        // Console.WriteLine(CountCharacterGroupsConsecutively("ababa"));          // 5
        // Console.WriteLine(CountCharacterGroupsConsecutively(""));              // 0
        // Console.WriteLine(CountCharacterGroupsConsecutively(null));            // 0
        // Console.WriteLine(CountCharacterGroupsConsecutively("Mississippi"));   // 8
        // Console.WriteLine(CountCharacterGroupsConsecutively("112233"));        // 6
        // Console.WriteLine(CountCharacterGroupsConsecutively("bookkeeper"));    // 8

        //  Revision are anagrams
        // Return true if both string contain the same character with the same counts
        //  Case-insensitive: null = false
        // Example:  Listen, silent = True
        // Example:  aab, ab false

        // Console.WriteLine(AreAnagrams("Listen", "Silent"));           // True
        // Console.WriteLine(AreAnagrams("aab", "ab"));                 // False
        // Console.WriteLine(AreAnagrams("Debit Card", "Bad Credit"));  // True
        // Console.WriteLine(AreAnagrams("Triangle", "Integral"));      // True
        // Console.WriteLine(AreAnagrams("Hello", "World"));            // False
        // Console.WriteLine(AreAnagrams("", ""));                      // True
        // Console.WriteLine(AreAnagrams(null, "abc"));                // False
        // Console.WriteLine(AreAnagrams("abc", null));                // False
        // Console.WriteLine(AreAnagrams("abc", "cab"));               // True
        // Console.WriteLine(AreAnagrams("aabbcc", "abcabc"));         // True


        // ============================ Thursday ==============================
        //=====================================================================

        /*
            NEXT CHALLENGES

            1. Warm-up: Count Symbols

            * Return how many symbol characters are in a string.
            * Use char.IsSymbol(character).
            * Example: "C# costs £10" -> 2 depending on symbol handling: # and £
            * Example: "hello!" -> 0 because ! is punctuation, not symbol.
            * Return 0 for null or empty.

            2. Revision: Are Anagrams

            * Return true if both strings contain the same characters with the same counts.
            * Example: "listen", "silent" -> true
            * Example: "aab", "aba" -> true
            * Example: "aab", "ab" -> false
            * "" and "" -> true.
            * null -> false.
            * Case-insensitive.
            * Do not use Sort, LINQ, Dictionary, or HashSet.

            3. Revision: Count Character Groups

            * Return how many consecutive character groups are in a string.
            * Example: "aaabbc" -> 3
            * Example: "helloo" -> 4
            * Example: "ababa" -> 5
            * Example: "aaaa" -> 1
            * Return 0 for null or empty.

            4. New Challenge: Get First Letters Of Each Word

            * Return a string made from the first letter of each word.
            * Example: "Cyberpunk Card Vault" -> "CCV"
            * Example: "paul mcginley" -> "pm"
            * Example: "  hello   world  " -> "hw"
            * Return "" for null or empty.
            * Split is allowed.

            5. New Challenge: Get Last Letters Of Each Word

            * Return a string made from the last letter of each word.
            * Example: "Cyberpunk Card Vault" -> "kdt"
            * Example: "paul mcginley" -> "ly"
            * Example: "  hello   world  " -> "od"
            * Return "" for null or empty.
            * Split is allowed.

            6. Optional Stretch: Count Unique Characters

            * Return how many different characters appear in a string.
            * Example: "hello" -> 4 because h, e, l, o
            * Example: "swiss" -> 3 because s, w, i
            * Example: "aabbcc" -> 3
            * Return 0 for null or empty.
            * You may use List<char>.Contains() for now.
        */

    }
}
