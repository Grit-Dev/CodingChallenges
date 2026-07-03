using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    public static int CountDigitsInString(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsDigit(character))
            {
                counter++;
            }
        }

        return counter;
    }

    public static bool AreAnagramsRevisionFriday(string pInputValue, string pTarget)
    {
        if (pInputValue == null || pTarget == null)
        {
            return false;
        }

        if (pInputValue.Length != pTarget.Length)
        {
            return false;
        }

        pInputValue = pInputValue.ToLower();
        pTarget = pTarget.ToLower();
        int firstCounter = 0;
        int secondCounter = 0;

        for (int outterIndex = 0; outterIndex <= pInputValue.Length - 1; outterIndex++)
        {
            char currentChar = pInputValue[outterIndex];

            for (int innerIndex = 0; innerIndex <= pTarget.Length - 1; innerIndex++)
            {
                if (currentChar == pTarget[innerIndex])
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

    public static int CountUniqueCharacters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;
        List<char> newList = new();
        pInputValue = pInputValue.ToLower();

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

    public static string RemovePunctuationOnly(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newString = new();

        foreach (char character in pInputValue)
        {
            if (!char.IsPunctuation(character))
            {
                newString.Append(character);
            }
        }

        return newString.ToString();
    }

    public static string KeepOnlyLettersAndSpaces(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newString = new();

        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character) || char.IsWhiteSpace(character))
            {
                newString.Append(character);
            }
        }

        return newString.ToString();
    }

    public static string CountEachLetterAToZ(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        int counter = 0;
        StringBuilder passedParameterString = new();
        StringBuilder newStringFinal = new();
        List<char> newList = [];
        pInputValue = pInputValue.ToUpper();

        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character))
            {
                passedParameterString.Append(character);
            }
        }

        for (int outterIndex = 0; outterIndex <= passedParameterString.Length - 1; outterIndex++)
        {
            char currentChar = passedParameterString[outterIndex];

            if (!newList.Contains(currentChar))
            {
                foreach (char characterInIndex in passedParameterString.ToString())
                {
                    if (currentChar == characterInIndex)
                    {
                        newList.Add(currentChar);
                        counter++;
                    }
                }

                newStringFinal.Append(currentChar + ":");
                newStringFinal.Append(counter);
                newStringFinal.Append(' ');
                counter = 0;
            }
        }

        return newStringFinal.ToString();

    }

    public static void Main(string[] args)
    {
        // Optional Stretch: Count Each Letter A-Z
        // Return a formatted string showing how many times each letter appears
        // Example: "abcaba = "A: 3 b:2 C:1"
        // Ignore spaces, numbers and symbols
        Console.WriteLine(CountEachLetterAToZ("aaaaa"));            // A:5
        Console.WriteLine(CountEachLetterAToZ("abcaba"));           // A:3 B:2 C:1
        Console.WriteLine(CountEachLetterAToZ("Hello"));            // H:1 E:1 L:2 O:1
        Console.WriteLine(CountEachLetterAToZ("Mississippi"));      // M:1 I:4 S:4 P:2
        Console.WriteLine(CountEachLetterAToZ("A A A"));            // A:3
        Console.WriteLine(CountEachLetterAToZ("123ABC!"));          // A:1 B:1 C:1
        Console.WriteLine(CountEachLetterAToZ(""));                 // ""
        Console.WriteLine(CountEachLetterAToZ(null!));               // ""
        Console.WriteLine(CountEachLetterAToZ("The Quick Brown Fox")); // T:1 H:1 E:1 Q:1 U:1 ...

        // Completed:
        // Count Digits in String
        // - Return how many digits are in a string
        // - Return 0 if Null Or Empty
        // Console.WriteLine(CountDigitsInString("123"));                // 3
        // Console.WriteLine(CountDigitsInString("Hello123"));           // 3
        // Console.WriteLine(CountDigitsInString("A1B2C3"));             // 3
        // Console.WriteLine(CountDigitsInString("No Digits"));          // 0
        // Console.WriteLine(CountDigitsInString(""));                   // 0
        // Console.WriteLine(CountDigitsInString(null!));                 // 0
        // Console.WriteLine(CountDigitsInString("007"));                // 3
        // Console.WriteLine(CountDigitsInString("Room 101"));           // 3
        // Console.WriteLine(CountDigitsInString("1a2b3c4d5e"));         // 5
        // Console.WriteLine(CountDigitsInString("£100.50"));            // 5

        //  Are Anagams
        // - Return true if both string contain the same characters with the same counts. 
        // - Return false if either string is null 
        // Make it case insensitive. 
        // Example: aab , aba = true
        // Console.WriteLine(AreAnagramsRevisionFriday("aab", "aba"));           // True
        // Console.WriteLine(AreAnagramsRevisionFriday("Listen", "Silent"));     // True
        // Console.WriteLine(AreAnagramsRevisionFriday("abc", "cab"));           // True
        // Console.WriteLine(AreAnagramsRevisionFriday("aab", "abb"));           // False
        // Console.WriteLine(AreAnagramsRevisionFriday("aabc", "abcc"));         // False
        // Console.WriteLine(AreAnagramsRevisionFriday("abc", "abd"));           // False
        // Console.WriteLine(AreAnagramsRevisionFriday("", ""));                 // True
        // Console.WriteLine(AreAnagramsRevisionFriday(null!, "abc"));            // False
        // Console.WriteLine(AreAnagramsRevisionFriday("abc", null!));            // False
        // Console.WriteLine(AreAnagramsRevisionFriday("Hello", "World"));       // False
        // Console.WriteLine(AreAnagramsRevisionFriday("AaBb", "bBaA"));         // True
        // Console.WriteLine(AreAnagramsRevisionFriday("Miss", "Sims"));         // False

        // Revision Count Unique Characters Case-Insensitive
        // Return how many different characters  appear in a string 
        // Example Hello => 4
        // Console.WriteLine(CountUniqueCharacters("Hello"));        // 4
        // Console.WriteLine(CountUniqueCharacters("HELLO"));        // 4
        // Console.WriteLine(CountUniqueCharacters("Swiss"));        // 3
        // Console.WriteLine(CountUniqueCharacters("aabbcc"));       // 3
        // Console.WriteLine(CountUniqueCharacters("abcde"));        // 5
        // Console.WriteLine(CountUniqueCharacters("AAAA"));         // 1
        // Console.WriteLine(CountUniqueCharacters(""));            // 0
        // Console.WriteLine(CountUniqueCharacters(null!));          // 0
        // Console.WriteLine(CountUniqueCharacters("Mississippi")); // 4
        // Console.WriteLine(CountUniqueCharacters("AaBbCc"));      // 3

        // Remove punctuation  Characters
        // Return a new String when punctuation is removed
        // Example: Hello! = Hello
        // Console.WriteLine(RemovePunctuationOnly("Hello!"));                    // Hello
        // Console.WriteLine(RemovePunctuationOnly("Hello, World!"));             // Hello World
        // Console.WriteLine(RemovePunctuationOnly("What's up?"));                // Whats up
        // Console.WriteLine(RemovePunctuationOnly("...Hello..."));               // Hello
        // Console.WriteLine(RemovePunctuationOnly("No punctuation"));            // No punctuation
        // Console.WriteLine(RemovePunctuationOnly(""));                          // ""
        // Console.WriteLine(RemovePunctuationOnly(null!));                        // ""
        // Console.WriteLine(RemovePunctuationOnly("#CSharp!"));                  // CSharp
        // Console.WriteLine(RemovePunctuationOnly("A,B.C!D?"));                  // ABCD

        // Keep only Letters and Spaces
        // Return a new string containing only letters and spaces.
        // Example: "Hello, World! 123" = Hello World
        // Console.WriteLine(KeepOnlyLettersAndSpaces("Hello, World! 123")); // Hello World
        // Console.WriteLine(KeepOnlyLettersAndSpaces("C# Programming"));    // C Programming
        // Console.WriteLine(KeepOnlyLettersAndSpaces("12345"));             // ""
        // Console.WriteLine(KeepOnlyLettersAndSpaces("Hello World"));       // Hello World
        // Console.WriteLine(KeepOnlyLettersAndSpaces(""));                  // ""
        // Console.WriteLine(KeepOnlyLettersAndSpaces(null!));                // ""
        // Console.WriteLine(KeepOnlyLettersAndSpaces("A1 B2 C3"));          // A B C
        // Console.WriteLine(KeepOnlyLettersAndSpaces("!@#$%^"));            // ""
        // Console.WriteLine(KeepOnlyLettersAndSpaces("Johnny Silverhand"));     // Johnny Silverhand

    }
}
