using System.Diagnostics.Metrics;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {

        // Find Most Frequent Word
        Console.WriteLine(FindMostFrequentWord("hello world hello"));
        Console.WriteLine(FindMostFrequentWord("one two two three"));
        Console.WriteLine(FindMostFrequentWord("one one two two three"));
        Console.WriteLine(FindMostFrequentWord(""));
        Console.WriteLine(FindMostFrequentWord(null!));


        // Count Each Letter A to Z Revision
        //Console.WriteLine(CountEachLetterAToZRevision("abcaba"));
        //Console.WriteLine(CountEachLetterAToZRevision("Hello"));
        //Console.WriteLine(CountEachLetterAToZRevision("aaaaa"));
        //Console.WriteLine(CountEachLetterAToZRevision(""));


        // Count Words Longer than Target:
        //Console.WriteLine(CountWordsLongerThanTarget("Cyberpunk card vault", 4));
        //Console.WriteLine(CountWordsLongerThanTarget("I am Paul", 2));
        //Console.WriteLine(CountWordsLongerThanTarget("Cyberpunk card vault", 3));
        //Console.WriteLine(CountWordsLongerThanTarget("", 3));
        //Console.WriteLine(CountWordsLongerThanTarget(null!, 3));

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
    }
}
