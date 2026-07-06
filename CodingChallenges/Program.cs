using System.Diagnostics.Metrics;
using System.Text;

public class Program
{
    public static int CountWordsEndingWithLetter(string pInputValue, char pTarget)
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
            if (word[^1] == pTarget)
            {
                counter++;
            }
        }

        return counter;
    }

    public static bool AreAnagramsRevisionAgain(string pInputValue, string pTarget)
    {
        if (pInputValue == null || pTarget == null)
        {
            return false;
        }

        if (pInputValue.Length != pTarget.Length)
        {
            return false;
        }

        int firstCounter = 0;
        int secondCounter = 0;

        pInputValue = pInputValue.ToLower();
        pTarget = pTarget.ToLower();

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

    public static string CountLettersRevisionFormat(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newStringFromParameter = new();
        StringBuilder finalNewStringForReturn = new();
        List<char> NewListChecker = [];
        int counter = 0;
        pInputValue = pInputValue.ToUpper();

        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character))
            {
                newStringFromParameter.Append(character);
            }
        }

        for (int outterIndex = 0; outterIndex <= newStringFromParameter.Length - 1; outterIndex++)
        {
            char currentChar = newStringFromParameter[outterIndex];

            if (!NewListChecker.Contains(currentChar))
            {
                foreach (char characterInForEach in newStringFromParameter.ToString())
                {
                    if (currentChar == characterInForEach)
                    {
                        counter++;
                    }
                }

                NewListChecker.Add(currentChar);

                finalNewStringForReturn.Append(currentChar);
                finalNewStringForReturn.Append(':');
                finalNewStringForReturn.Append(counter);
                finalNewStringForReturn.Append(' ');
            }

            counter = 0;
        }

        return finalNewStringForReturn.ToString().Trim();
    }

    public static string RemoveWordsLongerThanTarget(string pInputValue, int pTarget)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string[] newStringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder newString = new();

        foreach (string word in newStringSplit)
        {
            if (word.Length > pTarget)
            {
                continue;
            }

            newString.Append(word);
            newString.Append(' ');
        }

        return newString.ToString().Trim();
    }

    public static string ReverseEachWordInSentence(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder cleanedString = new();
        StringBuilder newString = new();

        // Made an assumption here: If Interviewing I would if they explicity 
        // Wanted to ignore digits and punctuation.
        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character) || char.IsWhiteSpace(character))
            {
                cleanedString.Append(character);
            }
        }

        pInputValue = cleanedString.ToString();

        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            for (int innerIndex = word.Length - 1; innerIndex >= 0; innerIndex--)
            {
                newString.Append(word[innerIndex]);
            }

            newString.Append(' ');
        }

        return newString.ToString().Trim();

    }

    public static string FindShortestWord(string pInputvalue)
    {
        if (string.IsNullOrEmpty(pInputvalue))
        {
            return "";
        }

        string shortestWord = "";
        int charCounterInWord = int.MaxValue;
        string[] stringSplit = pInputvalue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSplit)
        {
            if (word.Length < charCounterInWord)
            {
                charCounterInWord = word.Length;
                shortestWord = word;
            }
        }

        return shortestWord;

    }

    public static void Main(string[] args)
    {
        // Find Shortest Word
        // - Return the first shortest word in a sentence. 
        // - Example: Cyber punk card Vault ->  card
        // - Example: I am Paul -> I
        // Find Shortest Word
        Console.WriteLine(FindShortestWord("Cyber punk card Vault")); // punk
        Console.WriteLine(FindShortestWord("I am Paul"));             // I
        Console.WriteLine(FindShortestWord("dog cat rat"));           // dog
        Console.WriteLine(FindShortestWord("one two three"));         // one
        Console.WriteLine(FindShortestWord("apple"));                 // apple
        Console.WriteLine(FindShortestWord(""));                      // ""
        Console.WriteLine(FindShortestWord(null!));                    // null

        //
        // == Completed
        //

        // Warm-up:  Count Words Ending with Letter
        // - Return how many words end with a target Letter
        // - Example: Cyberpunk card vault - Target:  d = 1
        // - Example: Paul plays games - Target s = 2
        // Return 0 for null or empty
        // Count Words Ending with Letter
        // Console.WriteLine(CountWordsEndingWithLetter("Cyberpunk card vault", 'd'));     // 1
        // Console.WriteLine(CountWordsEndingWithLetter("Paul plays games", 's'));          // 2
        // Console.WriteLine(CountWordsEndingWithLetter("dog cat rat", 't'));               // 2
        // Console.WriteLine(CountWordsEndingWithLetter("Dog Cat Rat", 't'));               // 2
        // Console.WriteLine(CountWordsEndingWithLetter("apple banana orange", 'e'));       // 2
        // Console.WriteLine(CountWordsEndingWithLetter("hello", 'o'));                     // 1
        // Console.WriteLine(CountWordsEndingWithLetter("", 'a'));                          // 0
        // Console.WriteLine(CountWordsEndingWithLetter(null!, 'a'));                        // 0
        // Console.WriteLine(CountWordsEndingWithLetter("   ", 'a'));                       // 0

        // Revision Are Anagrams
        // Return true if both Strings contain the same characters with the same counts 
        // - Example: Listen, silent -> True
        // - Example aab,  aba -> true
        // Return false if either is null
        // Are Anagrams
        // Console.WriteLine(AreAnagramsRevisionAgain("listen", "silent"));      // True
        // Console.WriteLine(AreAnagramsRevisionAgain("aab", "aba"));            // True
        // Console.WriteLine(AreAnagramsRevisionAgain("triangle", "integral")); // True
        // Console.WriteLine(AreAnagramsRevisionAgain("evil", "vile"));          // True
        // Console.WriteLine(AreAnagramsRevisionAgain("abc", "abd"));            // False
        // Console.WriteLine(AreAnagramsRevisionAgain("aab", "abb"));            // False
        // Console.WriteLine(AreAnagramsRevisionAgain("hello", "helo"));         // False
        // Console.WriteLine(AreAnagramsRevisionAgain("", ""));                  // True
        // Console.WriteLine(AreAnagramsRevisionAgain(null!, "abc"));             // False
        // Console.WriteLine(AreAnagramsRevisionAgain("abc", null!));             // False

        // Revision each letter A to Z: 
        // - Return formatted string showing how many times each letter appears.
        // - Ignore Spaces, Numbers,  and symbols 
        // - Example: abcaba => a:3 B:2 C1
        // - Hello -> H:1 E:1 L:2 O:1
        // - Avoid trailing spaces 
        // Count Each Letter A-Z
        // Console.WriteLine(CountLettersRevisionFormat("abcaba"));                  // A:3 B:2 C:1
        // Console.WriteLine(CountLettersRevisionFormat("Hello"));                   // H:1 E:1 L:2 O:1
        // Console.WriteLine(CountLettersRevisionFormat("aaaaa"));                   // A:5
        // Console.WriteLine(CountLettersRevisionFormat("AaAa"));                    // A:4
        // Console.WriteLine(CountLettersRevisionFormat("C# Rocks!"));               // C:2 R:1 O:1 K:1 S:1
        // Console.WriteLine(CountLettersRevisionFormat("123abc456"));              // A:1 B:1 C:1
        // Console.WriteLine(CountLettersRevisionFormat("!@#$%^"));                 // ""
        // Console.WriteLine(CountLettersRevisionFormat(""));                       // ""
        // Console.WriteLine(CountLettersRevisionFormat(null!));                     // ""

        // Remove Words longer than Target 
        // - Return a sentence with the words removed if they are longer than the target Length.
        // Keep words less than or equal to Target. 
        // - Example: Cyberpunk card Vault - Target 4 -> Card - Ans: Cyberpunk Vault
        // Remove Words Longer Than Target
        // Console.WriteLine(RemoveWordsLongerThanTarget("Cyberpunk card Vault", 4));   // card
        // Console.WriteLine(RemoveWordsLongerThanTarget("I am Paul", 4));              // I am Paul
        // Console.WriteLine(RemoveWordsLongerThanTarget("dog cat elephant", 3));       // dog cat
        // Console.WriteLine(RemoveWordsLongerThanTarget("apple pear plum", 4));        // pear plum
        // Console.WriteLine(RemoveWordsLongerThanTarget("one two three four", 3));     // one two
        // Console.WriteLine(RemoveWordsLongerThanTarget("", 5));                       // ""
        // Console.WriteLine(RemoveWordsLongerThanTarget(null, 5));                     // null or ""

        // Stretch: Reverse Each Word in Sentence
        // - Reverse each word but keep the word order the same.
        // - Example: Hello World -> "olleh dlrow"
        // - Example: Cyberpunk vault -> knuprebyc tault
        // - Return null or Empty 
        // Reverse Each Word in Sentence
        // Console.WriteLine(ReverseEachWord("Hello World"));        // olleH dlroW
        // Console.WriteLine(ReverseEachWord("Cyberpunk vault"));    // knuprebyC tluav
        // Console.WriteLine(ReverseEachWord("I am Paul"));          // I ma luaP
        // Console.WriteLine(ReverseEachWord("dog cat"));            // god tac
        // Console.WriteLine(ReverseEachWord("a"));                  // a
        // Console.WriteLine(ReverseEachWord(""));                   // ""
        // Console.WriteLine(ReverseEachWord(null));                 // null

        // Stretch: Reverse Each Word in Sentence
        // - Reverse each word but keep the word order the same.
        // - Example: Hello World -> "olleh dlrow"
        // - Example: Cyberpunk vault -> knuprebyc tault
        // - Return null or Empty 
        // Reverse Each Word in Sentence
        Console.WriteLine(ReverseEachWordInSentence(",Hell,o World"));
        Console.WriteLine(ReverseEachWordInSentence("Hello World"));        // olleH dlroW
        Console.WriteLine(ReverseEachWordInSentence("Cyberpunk vault"));    // knuprebyC tluav
        Console.WriteLine(ReverseEachWordInSentence("I am Paul"));          // I ma luaP
        Console.WriteLine(ReverseEachWordInSentence("dog cat"));            // god tac
        Console.WriteLine(ReverseEachWordInSentence("a"));                  // a
        Console.WriteLine(ReverseEachWordInSentence(""));                   // ""
        Console.WriteLine(ReverseEachWordInSentence(null!));                 // ""

        /*
            NEXT CHALLENGES

            1. Warm-up: Count Words Ending With Letter

            * Return how many words end with a target letter.
            * Example: "Cyberpunk card vault", target 'd' -> 1
            * Example: "Paul plays games", target 's' -> 2
            * Return 0 for null or empty.
            * Case-insensitive.
            * Split is allowed.

            2. Revision: Are Anagrams

            * Redo from memory.
            * Return true if both strings contain the same characters with the same counts.
            * Example: "listen", "silent" -> true
            * Example: "aab", "aba" -> true
            * Example: "aab", "ab" -> false
            * Example: "", "" -> true
            * Return false if either is null.
            * Case-insensitive.
            * No Sort, LINQ, Dictionary, or HashSet.

            3. Revision: Count Each Letter A-Z

            * Return a formatted string showing how many times each letter appears.
            * Ignore spaces, numbers, and symbols.
            * Case-insensitive.
            * Example: "abcaba" -> "A:3 B:2 C:1"
            * Example: "Hello" -> "H:1 E:1 L:2 O:1"
            * Example: "aaaaa" -> "A:5"
            * Return "" for null or empty.
            * Avoid trailing spaces.

            4. New Challenge: Remove Words Longer Than Target

            * Return a sentence with words removed if they are longer than the target length.
            * Example: "Cyberpunk card vault", target 4 -> "card"
            * Example: "I am Paul", target 2 -> "I am"
            * Return "" for null or empty.
            * Split is allowed.
            * Use StringBuilder.

            5. New Challenge: Find Shortest Word

            * Return the shortest word in a sentence.
            * Example: "Cyberpunk card vault" -> "card"
            * Example: "I am Paul" -> "I"
            * If tied, return the first shortest word.
            * Return "" for null or empty.
            * Split is allowed.

            6. Optional Stretch: Reverse Each Word In Sentence

            * Reverse each word but keep the word order the same.
            * Example: "Hello World" -> "olleH dlroW"
            * Example: "Cyberpunk Vault" -> "knuprebyC tluaV"
            * Return "" for null or empty.
            * Split is allowed.
            * StringBuilder is allowed.
        */

    }
}
