using System.Diagnostics.Metrics;
using System.Text;

public class Program
{
    public static int CountWordsContainingLetter(string pInputValue, char pTarget)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;
        pInputValue = pInputValue.ToLower();
        pTarget = char.ToLower(pTarget);
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word.Contains(pTarget))
            {
                counter++;
            }
        }

        return counter;


    }

    public static string FindShortestWord(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string shortestWord = "";
        int shortestWordCounter = int.MaxValue;
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string currentWord in splitString)
        {
            if (currentWord.Length < shortestWordCounter)
            {
                shortestWord = currentWord;
                shortestWordCounter = currentWord.Length;
            }
        }

        return shortestWord;

    }

    public static bool AreAnagramsTuesdayRevision_One(string pInputValue, string pTargetValue)
    {
        if (pInputValue == null || pTargetValue == null)
        {
            return false;
        }

        if (pInputValue.Length != pTargetValue.Length)
        {
            return false;
        }

        int counterOne = 0;
        int counterTwo = 0;

        pInputValue = pInputValue.ToLower();
        pTargetValue = pTargetValue.ToLower();

        for (int outterIndex = 0; outterIndex <= pInputValue.Length - 1; outterIndex++)
        {
            char currentChar = pInputValue[outterIndex];

            for (int innerIndex = 0; innerIndex <= pTargetValue.Length - 1; innerIndex++)
            {
                if (currentChar == pTargetValue[innerIndex])
                {
                    counterOne++;
                }

                if (pInputValue[innerIndex] == currentChar)
                {
                    counterTwo++;
                }
            }

            if (counterOne != counterTwo)
            {
                return false;
            }

            counterOne = 0;
            counterTwo = 0;
        }

        return true;
    }

    public static string FindLongestWordRevision_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        int longestCounter = int.MinValue;
        string longestWordDetermined = "";
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word.Length > longestCounter)
            {
                longestWordDetermined = word;
                longestCounter = word.Length;
            }
        }

        return longestWordDetermined;
    }

    public static string RemoveTargetWord_One(string pInputValue, string pTarget)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        if (string.IsNullOrEmpty(pTarget))
        {
            return pInputValue;
        }

        pInputValue = pInputValue.ToLower();
        pTarget = pTarget.ToLower();
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        StringBuilder newStringFromParameter = new();

        foreach (string word in splitString)
        {
            if (word != pTarget)
            {
                newStringFromParameter.Append(word);
                newStringFromParameter.Append(' ');
            }
        }

        return newStringFromParameter.ToString().Trim();

    }

    public static string ReplaceTargetWord(string pInputValue, string pTarget, string pReplacement)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        if (string.IsNullOrEmpty(pTarget))
        {
            return pInputValue;
        }

        if (pReplacement == null)
        {
            pReplacement = "";
        }

        pInputValue = pInputValue.ToLower();
        pTarget = pTarget.ToLower();
        pReplacement = pReplacement.ToLower();
        StringBuilder newString = new();

        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word == pTarget)
            {
                newString.Append(pReplacement);
            }
            else
            {
                newString.Append(word);
            }

            newString.Append(' ');
        }

        return newString.ToString();

    }

    public static void Main(string[] args)
    {
        // 6. Replace Target Word
        // Return a sentence where every matching target word is replaced.
        // Example: "hello world hello", target "hello", replacement "hi" -> "hi world hi"
        // Example: "Cyberpunk card vault", target "card", replacement "deck" -> "Cyberpunk deck vault"
        // Return "" for null or empty input.
        // Return original sentence if target is null or empty.
        // If replacement is null, use "".
        // Case-insensitive comparison.
        // Split is allowed.
        // Use StringBuilder.

        // Console.WriteLine(ReplaceTargetWord("hello world hello", "hello", "hi")); // hi world hi
        // Console.WriteLine(ReplaceTargetWord("Cyberpunk card vault", "card", "deck")); // Cyberpunk deck vault
        // Console.WriteLine(ReplaceTargetWord("HELLO world hello", "hello", "hi")); // hi world hi
        // Console.WriteLine(ReplaceTargetWord("Paul plays games", "plays", "writes")); // Paul writes games
        // Console.WriteLine(ReplaceTargetWord("", "hello", "hi")); // ""
        // Console.WriteLine(ReplaceTargetWord(null, "hello", "hi")); // ""
        // Console.WriteLine(ReplaceTargetWord("hello world", "", "hi")); // hello world
        // Console.WriteLine(ReplaceTargetWord("hello world", null, "hi")); // hello world
        Console.WriteLine(ReplaceTargetWord("hello world", "world", null)); // hello

        /*


            6. Optional Stretch: Replace Target Word
        */

        // ======= Completed: ===============================================================
        // ======= Completed: ===============================================================

        // 1. Count Words Containing Letter
        // Return how many words contain a target letter.
        // Example: "Cyberpunk card vault", target 'a' -> 2
        // Example: "Paul plays games", target 'p' -> 2
        // Return 0 for null or empty.
        // Case-insensitive.
        // Split is allowed
        // Console.WriteLine(CountWordsContainingLetter("Cyberpunk card vault", 'a')); // 2
        // Console.WriteLine(CountWordsContainingLetter("Paul plays games", 'p'));      // 2
        // Console.WriteLine(CountWordsContainingLetter("Paul plays games", 'P'));      // 2
        // Console.WriteLine(CountWordsContainingLetter("dog cat rat", 't'));           // 2
        // Console.WriteLine(CountWordsContainingLetter("APPLE banana", 'a'));          // 2
        // Console.WriteLine(CountWordsContainingLetter("hello", 'z'));                 // 0
        // Console.WriteLine(CountWordsContainingLetter("", 'a'));                      // 0
        // Console.WriteLine(CountWordsContainingLetter(null, 'a'));                    // 0
        // Console.WriteLine(CountWordsContainingLetter("   ", 'a'));                   // 0

        // 2. Find Shortest Word
        // Return the shortest word in a sentence.
        // Example: "Cyberpunk card vault" -> "card"
        // Example: "I am Paul" -> "I"
        // If tied, return the first shortest word.
        // Return "" for null or empty.
        // Split is allowed.
        // Console.WriteLine(FindShortestWord("Cyberpunk card vault")); // card
        // Console.WriteLine(FindShortestWord("I am Paul"));            // I
        // Console.WriteLine(FindShortestWord("dog cat rat"));          // dog
        // Console.WriteLine(FindShortestWord("one two three"));        // one
        // Console.WriteLine(FindShortestWord("apple"));                // apple
        // Console.WriteLine(FindShortestWord("a bb ccc"));             // a
        // Console.WriteLine(FindShortestWord(""));                     // ""
        // Console.WriteLine(FindShortestWord(null));                   // ""

        // 3. Are Anagrams     
        // Return true if both strings contain the same characters with the same counts.
        // Example: "listen", "silent" -> true
        // Example: "aab", "aba" -> true
        // Example: "aab", "ab" -> false
        // Example: "", "" -> true
        // Return false if either is null.
        // Case-insensitive.
        // No Sort, LINQ, Dictionary, or HashSet.
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("listen", "silent"));      // True
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("aab", "aba"));            // True
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("triangle", "integral"));  // True
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("evil", "vile"));          // True
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("aab", "ab"));            // False
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("hello", "helo"));        // False
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("abc", "abd"));           // False
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("", ""));                  // True
        // Console.WriteLine(AreAnagramsTuesdayRevision_One(null!, "abc"));            // False
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("abc", null!));            // False
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("LISTEN", "silent"));      // True
        // Console.WriteLine(AreAnagramsTuesdayRevision_One("AAB", "aba"));            // True

        // 4. Find Longest Word              
        // Return the longest word in a sentence.
        // Example: "Cyberpunk card vault" -> "Cyberpunk"
        // Example: "I am Paul" -> "Paul"
        // If tied, return the first longest word.
        // Return "" for null or empty.
        // Split is allowed.
        // Console.WriteLine(FindLongestWordRevision_One("Cyberpunk card vault")); // Cyberpunk
        // Console.WriteLine(FindLongestWordRevision_One("I am Paul"));            // Paul
        // Console.WriteLine(FindLongestWordRevision_One("dog cat elephant"));     // elephant
        // Console.WriteLine(FindLongestWordRevision_One("one three five"));       // three
        // Console.WriteLine(FindLongestWordRevision_One("apple"));                // apple
        // Console.WriteLine(FindLongestWordRevision_One(""));                     // ""
        // Console.WriteLine(FindLongestWordRevision_One(null));                   // ""

        // 5. Remove Target Word
        // Return a sentence with all matching target words removed.
        // Example: "hello world hello", target "hello" -> "world"
        // Example: "Cyberpunk card vault card", target "card" -> "Cyberpunk vault"
        // Return "" for null or empty input.
        // Return original sentence if target is null or empty.
        // Case-insensitive comparison.
        // Console.WriteLine(RemoveTargetWord_One("hello world hello", "hello")); // world
        // Console.WriteLine(RemoveTargetWord_One("Cyberpunk card vault card", "card")); // Cyberpunk vault
        // Console.WriteLine(RemoveTargetWord_One("Paul plays games", "plays")); // Paul games
        // Console.WriteLine(RemoveTargetWord_One("HELLO world hello", "hello")); // world
        // Console.WriteLine(RemoveTargetWord_One("", "hello")); // "" // ""
        // Console.WriteLine(RemoveTargetWord_One("hello world", "")); // hello world
        // Console.WriteLine(RemoveTargetWord_One("hello world", null!)); // hello world

        /*
            NEXT CHALLENGES

            1. Warm-up: Count Words Containing Letter

            * Return how many words contain a target letter.
            * Example: "Cyberpunk card vault", target 'a' -> 2
            * Example: "Paul plays games", target 'p' -> 2
            * Return 0 for null or empty.
            * Case-insensitive.
            * Split is allowed.

            2. Revision: Find Shortest Word

            * Return the shortest word in a sentence.
            * Example: "Cyberpunk card vault" -> "card"
            * Example: "I am Paul" -> "I"
            * If tied, return the first shortest word.
            * Return "" for null or empty.
            * Split is allowed.

            3. Revision: Are Anagrams

            * Return true if both strings contain the same characters with the same counts.
            * Example: "listen", "silent" -> true
            * Example: "aab", "aba" -> true
            * Example: "aab", "ab" -> false
            * Example: "", "" -> true
            * Return false if either is null.
            * Case-insensitive.
            * No Sort, LINQ, Dictionary, or HashSet.

            4. New Challenge: Find Longest Word

            * Return the longest word in a sentence.
            * Example: "Cyberpunk card vault" -> "Cyberpunk"
            * Example: "I am Paul" -> "Paul"
            * If tied, return the first longest word.
            * Return "" for null or empty.
            * Split is allowed.

            5. New Challenge: Remove Target Word

            * Return a sentence with all matching target words removed.
            * Example: "hello world hello", target "hello" -> "world"
            * Example: "Cyberpunk card vault card", target "card" -> "Cyberpunk vault"
            * Return "" for null or empty input.
            * Return original sentence if target is null or empty.
            * Case-insensitive comparison.
            * Split is allowed.
            * Use StringBuilder.

            6. Optional Stretch: Replace Target Word

            * Return a sentence where every matching target word is replaced.
            * Example: "hello world hello", target "hello", replacement "hi" -> "hi world hi"
            * Example: "Cyberpunk card vault", target "card", replacement "deck" -> "Cyberpunk deck vault"
            * Return "" for null or empty input.
            * Return original sentence if target is null or empty.
            * If replacement is null, use "".
            * Case-insensitive comparison.
            * Split is allowed.
            * Use StringBuilder.
        */
    }
}
