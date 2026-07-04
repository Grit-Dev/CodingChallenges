using System.Text;

public class Program
{
    public static int CountLettersCaseInsensitive(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character))
            {
                count++;
            }
        }

        return count;
    }

    public static bool AreAnagramsRevisionSat(string pInputValue, string pTarget)
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

        for (int outterIndex = 0; outterIndex < pInputValue.Length; outterIndex++)
        {
            char currentChar = pInputValue[outterIndex];

            for (int innerIndex = 0; innerIndex < pInputValue.Length; innerIndex++)
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

    public static string RemovePunctationAndSymbols(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newSring = new();

        foreach (char character in pInputValue)
        {
            if (char.IsLetterOrDigit(character) || char.IsWhiteSpace(character))
            {
                newSring.Append(character);
            }
        }

        return newSring.ToString();
    }

    public static int CountWordsLongerThanTarget(string pInputValue, int pTarget)
    { 
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word.Length > pTarget)
            {
                count++;
            }
        }

        return count;
    }
    public static void Main(string[] args)
    {

        // Count Words Longer than Target:
        Console.WriteLine(CountWordsLongerThanTarget("Cyberpunk card vault", 4));
        Console.WriteLine(CountWordsLongerThanTarget("I am Paul", 2));
        Console.WriteLine(CountWordsLongerThanTarget("Cyberpunk card vault", 3));
        Console.WriteLine(CountWordsLongerThanTarget("", 3));
        Console.WriteLine(CountWordsLongerThanTarget(null!, 3));

        // Count Letters Case-Insensitive
        //Console.WriteLine(CountLettersCaseInsensitive("abc1234"));
        //Console.WriteLine(CountLettersCaseInsensitive("Cyberpunk 2077"));
        //Console.WriteLine(CountLettersCaseInsensitive("12345")); 
        //Console.WriteLine(CountLettersCaseInsensitive(null!));

        // Are Anagrams
        //Console.WriteLine(AreAnagramsRevisionSat("aab", "aba"));           // True
        //Console.WriteLine(AreAnagramsRevisionSat("Listen", "Silent"));     // True
        //Console.WriteLine(AreAnagramsRevisionSat("abc", "cab"));           // True
        //Console.WriteLine(AreAnagramsRevisionSat("aab", "abb"));           // False
        //Console.WriteLine(AreAnagramsRevisionSat("aabc", "abcc"));         // False
        //Console.WriteLine(AreAnagramsRevisionSat("abc", "abd"));           // False
        //Console.WriteLine(AreAnagramsRevisionSat("", ""));                 // True
        //Console.WriteLine(AreAnagramsRevisionSat(null!, "abc"));            // False
        //Console.WriteLine(AreAnagramsRevisionSat("abc", null!));            // False
        //Console.WriteLine(AreAnagramsRevisionSat("Hello", "World"));       // False
        //Console.WriteLine(AreAnagramsRevisionSat("AaBb", "bBaA"));         // True
        //Console.WriteLine(AreAnagramsRevisionSat("Miss", "Sims"));         // False

        // Remove Punctation and Symbols
        // Keep letters, digits, and spaces.
        // Return "" for Null or Empty
        //Console.WriteLine(RemovePunctationAndSymbols("C# costs £10!"));
        //Console.WriteLine(RemovePunctationAndSymbols("He#llo Wo#rld!"));
        //Console.WriteLine(RemovePunctationAndSymbols("Hell#o Wo!rld!"));
        //Console.WriteLine(RemovePunctationAndSymbols(""));
        //Console.WriteLine(RemovePunctationAndSymbols(null!));



        /*
            NEXT CHALLENGES

            3. Revision: Count Each Letter A-Z

            * Return a formatted string showing how many times each letter appears.
            * Ignore spaces, numbers, and symbols.
            * Case-insensitive.
            * Example: "abcaba" -> "A:3 B:2 C:1"
            * Example: "Hello" -> "H:1 E:1 L:2 O:1"
            * Example: "aaaaa" -> "A:5"
            * Return "" for null or empty.
            * Try to avoid a trailing space if you can.

            5. New Challenge: Count Words Longer Than Target

            * Return how many words are longer than a target length.
            * Example: "Cyberpunk card vault", target 4 -> 2
            * Example: "I am Paul", target 2 -> 1
            * Return 0 for null or empty.
            * Split is allowed.

            6. Optional Stretch: Find Most Frequent Word

            * Return the word that appears most often.
            * Example: "hello world hello" -> "hello"
            * Example: "one two two three" -> "two"
            * If tied, return the word that appears first.
            * Return "" for null or empty.
            * Case-insensitive.
            * Split is allowed.
            * No Dictionary or LINQ.
        */
    }
}
