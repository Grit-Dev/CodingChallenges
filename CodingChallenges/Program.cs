using System.Text;

public class Program
{
    public static int CountWordsWithExactLength(string pInputValue, int pTargetValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word.Length == pTargetValue)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string RemoveTargetWord_Rev(string pInputValue, string pTargetValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        if (string.IsNullOrEmpty(pTargetValue))
        {
            return pInputValue;
        }

        StringBuilder newString = new();
        string[] stringSpilit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        pTargetValue = pTargetValue.ToLower();

        foreach (string word in stringSpilit)
        {
            string currentWord = word.ToLower();
            if (currentWord != pTargetValue)
            {
                newString.Append(word);
                newString.Append(' ');
            }

        }

        return newString.ToString().Trim();

    }

    public static string ReplaceTargetWord_One(string pInputValue, string pTargetValue, string pReplacementValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        if (string.IsNullOrEmpty(pTargetValue))
        {
            return pInputValue;
        }

        if (pReplacementValue == null)
        {
            pReplacementValue = "";
        }

        string[] spilitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder newString = new();
        pTargetValue = pTargetValue.ToLower();

        foreach (string word in spilitString)
        {
            string indexWord = word.ToLower();

            if (indexWord == pTargetValue)
            {
                newString.Append(pReplacementValue);
                newString.Append(' ');
            }
            else
            {
                newString.Append(word);
                newString.Append(' ');
            }
        }

        return newString.ToString().Trim();


    }

    public static string CapitaliseFirstLetterOfEachWord_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newString = new();
        string[] stringSpilit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSpilit)
        {
            char currentChar = char.ToUpper(word[0]);

            newString.Append(currentChar + word.Substring(1) + ' ');
        }

        return newString.ToString().Trim();
    }

    public static string LowercaseAllWordsExceptFirstLetter_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        // pInputValue = pInputValue.ToLower();
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder newString = new();

        foreach (string word in splitString)
        {
            char currentChar = char.ToUpper(word[0]);
            newString.Append(currentChar + word.Substring(1).ToLower() + ' ');
        }

        return newString.ToString().Trim();
    }

    // Needs improvement
    public static string TitleCaseExceptSmallWords_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string[] stringSpilit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> newListOfExludedWOrds = ["and", "or", "the", "of", "in"];
        StringBuilder newString = new();
        bool isFirstWord = false;

        foreach (string word in stringSpilit)
        {
            if (word == stringSpilit[0] && !isFirstWord)
            {
                newString.Append(char.ToUpper(word[0]) + word.Substring(1) + ' ');
                isFirstWord = true;
            }
            else if (newListOfExludedWOrds.Contains(word.ToLower()))
            {
                string exludedListedWord = word.ToLower();

                newString.Append(exludedListedWord + ' ');
            }
            else
            {
                newString.Append(char.ToUpper(word[0]) + word.Substring(1) + ' ');
            }
        }

        return newString.ToString().Trim();
    }
    public static void Main(string[] args)
    {
        // Title Case Except Small Words
        Console.WriteLine(TitleCaseExceptSmallWords_One("the lord of the rings")); // The Lord of the Rings
        Console.WriteLine(TitleCaseExceptSmallWords_One("cyberpunk and the card vault")); // Cyberpunk and the Card Vault
        Console.WriteLine(TitleCaseExceptSmallWords_One("war of the worlds")); // War of the Worlds
        Console.WriteLine(TitleCaseExceptSmallWords_One("the rise and fall of empires")); // The Rise and Fall of Empires
        Console.WriteLine(TitleCaseExceptSmallWords_One("in the heat of the night")); // In the Heat of the Night
        Console.WriteLine(TitleCaseExceptSmallWords_One("the the the")); // The the the
        Console.WriteLine(TitleCaseExceptSmallWords_One("")); // ""
        Console.WriteLine(TitleCaseExceptSmallWords_One(null!)); // ""               
        /*
            6. Optional Stretch: Title Case Except Small Words

            * Capitalise each word except small words: "and", "or", "the", "of", "in".
            * Always capitalise the first word.
            * Example: "the lord of the rings" -> "The Lord of the Rings"
            * Example: "cyberpunk and the card vault" -> "Cyberpunk and the Card Vault"
            * Return "" for null or empty.
            * Case-insensitive comparison.
            * Split is allowed.
            * No LINQ or Dictionary.
        */

        // =============== Completed: 

        // Count Words With Exact Length
        // Console.WriteLine(CountWordsWithExactLength("Cyberpunk card vault", 4)); // 1
        // Console.WriteLine(CountWordsWithExactLength("I am Paul", 2)); // 1
        // Console.WriteLine(CountWordsWithExactLength("dog cat rat", 3)); // 3
        // Console.WriteLine(CountWordsWithExactLength("one two three", 3)); // 2
        // Console.WriteLine(CountWordsWithExactLength("apple", 5)); // 1
        // Console.WriteLine(CountWordsWithExactLength("", 4)); // 0
        // Console.WriteLine(CountWordsWithExactLength(null!, 4)); // 0

        // Remove Target Word
        // Console.WriteLine(RemoveTargetWord_Rev("hello world hello", "hello")); // world
        // Console.WriteLine(RemoveTargetWord_Rev("Cyberpunk card vault card", "card")); // Cyberpunk vault
        // Console.WriteLine(RemoveTargetWord_Rev("HELLO world hello", "hello")); // world
        // Console.WriteLine(RemoveTargetWord_Rev("Paul Plays Games", "plays")); // Paul Games
        // Console.WriteLine(RemoveTargetWord_Rev("card card card", "card")); // ""
        // Console.WriteLine(RemoveTargetWord_Rev("card test card test", "card")); // test test
        // Console.WriteLine(RemoveTargetWord_Rev("", "card")); // ""
        // Console.WriteLine(RemoveTargetWord_Rev(null, "card")); // ""
        // Console.WriteLine(RemoveTargetWord_Rev("hello world", "")); // hello world
        // Console.WriteLine(RemoveTargetWord_Rev("hello world", null)); // hello world

        // Replace Target Word
        // Console.WriteLine(ReplaceTargetWord_One("hello world hello", "hello", "hi")); // hi world hi
        // Console.WriteLine(ReplaceTargetWord_One("Cyberpunk card vault", "card", "deck")); // Cyberpunk deck vault
        // Console.WriteLine(ReplaceTargetWord_One("HELLO world hello", "hello", "hi")); // hi world hi
        // Console.WriteLine(ReplaceTargetWord_One("card card card", "card", "deck")); // deck deck deck
        // Console.WriteLine(ReplaceTargetWord_One("card test card", "card", "deck")); // deck test deck
        // Console.WriteLine(ReplaceTargetWord_One("hello world", "world", null)); // hello
        // Console.WriteLine(ReplaceTargetWord_One("", "world", "planet")); // ""
        // Console.WriteLine(ReplaceTargetWord_One(null, "world", "planet")); // ""
        // Console.WriteLine(ReplaceTargetWord_One("hello world", "", "test")); // hello world
        // Console.WriteLine(ReplaceTargetWord_One("hello world", null, "test")); // hello world

        // Capitalise First Letter Of Each Word
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One("hello world")); // Hello World
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One("paul mcginley")); // Paul Mcginley
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One("CYBERPUNK vault")); // CYBERPUNK Vault
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One("a b c")); // A B C
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One("hello    world")); // Hello World
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One("")); // ""
        // Console.WriteLine(CapitaliseFirstLetterOfEachWord_One(null!)); // ""

        // Lowercase All Words Except First Letter
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One("hello world")); // Hello World
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One("pAUL mCGINLEY")); // Paul Mcginley
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One("CYBERPUNK VAULT")); // Cyberpunk Vault
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One("hELLO WoRLD")); // Hello World
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One("a b c")); // A B C
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One("")); // ""
        // Console.WriteLine(LowercaseAllWordsExceptFirstLetter_One(null!)); // ""


    }
}
