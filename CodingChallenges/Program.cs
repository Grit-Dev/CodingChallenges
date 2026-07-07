using System.Diagnostics.Metrics;
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

    public static void Main(string[] args)
    {
        //1.Warm - up: Count Words With Exact Length
        Console.WriteLine(CountWordsExactLength("Cyberpunk card Vault", 4));
        Console.WriteLine(CountWordsExactLength("I am Paul", 2));
        Console.WriteLine(CountWordsExactLength("Cyberpunk card Vault", 0));
        Console.WriteLine(CountWordsExactLength(null!, 4));

        // 2.Revision: Remove Target Word
        Console.WriteLine(RemoveTargetWord("hello world hello", "hello"));
        Console.WriteLine(RemoveTargetWord("Cyberpunk card vault card", "card") == "Cyberpunk vault");
        Console.WriteLine(RemoveTargetWord("Paul plays games", "plays") == "Paul games");
        Console.WriteLine(RemoveTargetWord("HELLO world hello", "hello") == "world");
        Console.WriteLine(RemoveTargetWord("Card card CARD vault", "card") == "vault");
        Console.WriteLine(RemoveTargetWord("Cyberpunk vault", "card") == "Cyberpunk vault");
        Console.WriteLine(RemoveTargetWord("", "hello") == "");
        Console.WriteLine(RemoveTargetWord(null!, "hello") == "");
        Console.WriteLine(RemoveTargetWord("hello world", "") == "hello world");
        Console.WriteLine(RemoveTargetWord("hello world", null!) == "hello world");
        Console.WriteLine(RemoveTargetWord("   hello   world   hello   ", "hello") == "world");


        /*
            NEXT CHALLENGES
            2. Revision: Remove Target Word

            * Return a sentence with all matching target words removed.
            * Example: "hello world hello", target "hello" -> "world"
            * Example: "Cyberpunk card vault card", target "card" -> "Cyberpunk vault"
            * Return "" for null or empty input.
            * Return original sentence if target is null or empty.
            * Case-insensitive comparison.
            * Preserve original casing in the returned sentence.
            * Split is allowed.
            * Use StringBuilder.

            3. Revision: Replace Target Word

            * Return a sentence where every matching target word is replaced.
            * Example: "hello world hello", target "hello", replacement "hi" -> "hi world hi"
            * Example: "Cyberpunk card vault", target "card", replacement "deck" -> "Cyberpunk deck vault"
            * Return "" for null or empty input.
            * Return original sentence if target is null or empty.
            * If replacement is null, use "".
            * Case-insensitive comparison.
            * Preserve original casing for non-replaced words.
            * Split is allowed.
            * Use StringBuilder.

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
