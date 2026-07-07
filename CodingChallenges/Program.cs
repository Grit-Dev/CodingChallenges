using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text;

public class Program
{
    public static int CountWordsExactLength(string pInputValue, int pTargetLength)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;
        string[] spilitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in spilitString)
        {
            if (word.Length == pTargetLength)
            { 
                counter++;
            }
        }

        return counter;
    }

    public static string RemoveTargetWord(string pInputValue, string pTargetWord)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        if (string.IsNullOrEmpty(pTargetWord))
        {
            return pInputValue;
        }

        StringBuilder newStringFormed = new StringBuilder();
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word.ToLower() != pTargetWord.ToLower())
            {
                newStringFormed.Append(word);
                newStringFormed.Append(' ');
            }
        }

        return newStringFormed.ToString().Trim();
    }

    public static string ReplaceTargetWord(string pInputValue, string pTargetWord, string pReplacement)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        if (string.IsNullOrEmpty(pTargetWord))
        {
            return pInputValue;
        }

        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder newStringFormed = new();

        foreach (string word in splitString)
        {
            if (word.ToLower() == pTargetWord.ToLower())
            {
                newStringFormed.Append(pReplacement);
            }
            else
            {
                newStringFormed.Append(word);
            }

            newStringFormed.Append(' ');
        }

        return newStringFormed.ToString().Trim();
    }

    public static string CapitaliseFirstLetterOfEachWord(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string[] spilitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder newStringFormed = new();

        foreach (string word in spilitString)
        {
            char characterHolder = char.ToUpper(word[0]);

            newStringFormed.Append(characterHolder).Append(word.Substring(1));
            newStringFormed.Append(' ');
        }

        return newStringFormed.ToString().Trim();
    }

    public static void Main(string[] args)
    {
        // 4.New Challenge: Capitalise First Letter Of Each Word
        /*        *Return a sentence where each word starts with an uppercase letter.
                    *Example: "hello world"-> "Hello World"
                    * Example: "paul mcginley"-> "Paul Mcginley"
                    * Example: "CYBERPUNK vault"-> "CYBERPUNK Vault"
                    * Return "" for null or empty.
                    * Split is allowed.
                    * Use StringBuilder.*/
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("hello world") == "Hello World");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("paul mcginley") == "Paul Mcginley");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("CYBERPUNK vault") == "CYBERPUNK Vault");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("single") == "Single");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("a b c") == "A B C");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("   hello   world   ") == "Hello World");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord("") == "");
        Console.WriteLine(CapitaliseFirstLetterOfEachWord(null!) == "");


        //1.Warm - up: Count Words With Exact Length
        //Console.WriteLine(CountWordsExactLength("Cyberpunk card Vault", 4));
        //Console.WriteLine(CountWordsExactLength("I am Paul", 2));
        //Console.WriteLine(CountWordsExactLength("Cyberpunk card Vault", 0));
        //Console.WriteLine(CountWordsExactLength(null!, 4));

        // 2.Revision: Remove Target Word
        //Console.WriteLine(RemoveTargetWord("hello world hello", "hello"));
        //Console.WriteLine(RemoveTargetWord("Cyberpunk card vault card", "card") == "Cyberpunk vault");
        //Console.WriteLine(RemoveTargetWord("Paul plays games", "plays") == "Paul games");
        //Console.WriteLine(RemoveTargetWord("HELLO world hello", "hello") == "world");
        //Console.WriteLine(RemoveTargetWord("Card card CARD vault", "card") == "vault");
        //Console.WriteLine(RemoveTargetWord("Cyberpunk vault", "card") == "Cyberpunk vault");
        //Console.WriteLine(RemoveTargetWord("", "hello") == "");
        //Console.WriteLine(RemoveTargetWord(null!, "hello") == "");
        //Console.WriteLine(RemoveTargetWord("hello world", "") == "hello world");
        //Console.WriteLine(RemoveTargetWord("hello world", null!) == "hello world");
        //Console.WriteLine(RemoveTargetWord("   hello   world   hello   ", "hello") == "world");

        // 3.Revision: Replace Target Word
        //Console.WriteLine(ReplaceTargetWord("hello world hello", "hello", "hi") == "hi world hi");
        //Console.WriteLine(ReplaceTargetWord("Cyberpunk card vault", "card", "deck") == "Cyberpunk deck vault");
        //Console.WriteLine(ReplaceTargetWord("HELLO world hello", "hello", "hi") == "hi world hi");
        //Console.WriteLine(ReplaceTargetWord("Paul plays games", "plays", "writes") == "Paul writes games");
        //Console.WriteLine(ReplaceTargetWord("Card card CARD vault", "card", "deck") == "deck deck deck vault");
        //Console.WriteLine(ReplaceTargetWord("Cyberpunk vault", "card", "deck") == "Cyberpunk vault");
        //Console.WriteLine(ReplaceTargetWord("", "hello", "hi") == "");
        //Console.WriteLine(ReplaceTargetWord(null!, "hello", "hi") == "");
        //Console.WriteLine(ReplaceTargetWord("hello world", "", "hi") == "hello world");
        //Console.WriteLine(ReplaceTargetWord("hello world", null!, "hi") == "hello world");
        //Console.WriteLine(ReplaceTargetWord("hello world", "world", null!) == "hello");
        //Console.WriteLine(ReplaceTargetWord("   hello   world   hello   ", "hello", "hi") == "hi world hi");


        /*
            NEXT CHALLENGES

            4. New Challenge: Capitalise First Letter Of Each Word

            * Return a sentence where each word starts with an uppercase letter.
            * Example: "hello world" -> "Hello World"
            * Example: "paul mcginley" -> "Paul Mcginley"
            * Example: "CYBERPUNK vault" -> "CYBERPUNK Vault"
            * Return "" for null or empty.
            * Split is allowed.
            * Use StringBuilder.

            5. New Challenge: Lowercase All Words Except First Letter

            * Return a sentence where each word is capitalised properly.
            * Example: "hello world" -> "Hello World"
            * Example: "pAUL mCGINLEY" -> "Paul Mcginley"
            * Example: "CYBERPUNK VAULT" -> "Cyberpunk Vault"
            * Return "" for null or empty.
            * Split is allowed.
            * Use StringBuilder.

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
    }
}
