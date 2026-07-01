using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        // Is Panagram
        // - Return true if senetence contains ecer letter: a-z atleast once.
        // - Example "The quick  brown fox jumps over the lazy dog" - > true
        // -   string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // - Example Hello world - False. 
        Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog")); // True
        Console.WriteLine(IsPangram("Hello World"));                                 // False
        Console.WriteLine(IsPangram("Pack my box with five dozen liquor jugs"));     // True
        Console.WriteLine(IsPangram("Sphinx of black quartz, judge my vow"));        // True
        Console.WriteLine(IsPangram("abcdefghijklmnopqrstuvwxyz"));                  // True
        Console.WriteLine(IsPangram("abcdefghijklmnopqrstuvwxy"));                   // False
        Console.WriteLine(IsPangram(""));                                            // False
        Console.WriteLine(IsPangram(null));                                          // False
        Console.WriteLine(IsPangram("The five boxing wizards jump quickly"));        // True
        Console.WriteLine(IsPangram("A quick movement of the enemy will jeopardize five gunboats")); // false

        // Complete:

        // Get initals From name
        // - Return the initals of the full name
        // - Paul Kinley => PK
        // - John Ronanld Reuel Tolkien -> JRRT
        // Console.WriteLine(GetInitials("Paul Kinley"));                      // PK
        // Console.WriteLine(GetInitials("John Ronald Reuel Tolkien"));        // JRRT
        // Console.WriteLine(GetInitials("Paul"));                             // P
        // Console.WriteLine(GetInitials("bob smith"));                        // BS
        // Console.WriteLine(GetInitials("mary jane watson parker"));          // MJWP
        // Console.WriteLine(GetInitials(""));                                 // ""
        // Console.WriteLine(GetInitials(null));                               // ""
        // Console.WriteLine(GetInitials("   John    Smith   "));              // JS
        // Console.WriteLine(GetInitials("Jean-Luc Picard"));                  // JP
        // Console.WriteLine(GetInitials("Bilbo Baggins"));                    // BB


        // Warm Up: Count Punctuation Characters 
        // - Return how many punctuation characters are in a string.  
        // - Example: "Wait...What?" => 4
        // Console.WriteLine(CountPunctuationCharacters("Wait...What?") == 4);      // 4
        // Console.WriteLine(CountPunctuationCharacters("Hello, World!") == 2);     // 2
        // Console.WriteLine(CountPunctuationCharacters("No punctuation") == 0);    // 0
        // Console.WriteLine(CountPunctuationCharacters("C# is great.") == 2);      // 2
        // Console.WriteLine(CountPunctuationCharacters("") == 0);                  // 0
        // Console.WriteLine(CountPunctuationCharacters(null)== 0);                // 0
        // Console.WriteLine(CountPunctuationCharacters("...") == 3);               // 3
        // Console.WriteLine(CountPunctuationCharacters("???")== 3);               // 3
        // Console.WriteLine(CountPunctuationCharacters("One.Two,Three!") == 3);    // 3

        // Remove Consecutive Duplicate Characters
        // - Return a string where consecutive duplicate characters are 
        // - reduced to one.
        // Example: "aaabbc" -> abc
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aaabbc"));        // abc
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("a"));             // a
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aaaaa"));         // a
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("ababa"));         // ababa
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aabbcc"));        // abc
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aaAAaa"));        // aAAa
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters(""));              // ""           // ""
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("112233"));        // 123
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("111223311"));     // 1231
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("Hellooo!!!"));    // Helo!
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("   hello   "));   // " hello "
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("AABBCC"));        // ABC
        // Console.WriteLine(RemoveConsecutiveDuplicateCharacters("Mississippi"));   // Misisipi

        // Count character Groups: 
        // - Return how many consecutive character groups are in a string
        // - "aabbc" -> 3 || "helo" -> 4 because h, e, ll, oo,
        // Console.WriteLine(CountCharacterGroups("aabbc"));          // 3
        // Console.WriteLine(CountCharacterGroups("helo"));           // 4
        // Console.WriteLine(CountCharacterGroups("aaabbbccc"));      // 3
        // Console.WriteLine(CountCharacterGroups("aaaa"));           // 1
        // Console.WriteLine(CountCharacterGroups("ababa"));          // 5
        // Console.WriteLine(CountCharacterGroups(""));               // 0
        // Console.WriteLine(CountCharacterGroups(null!));             // 0
        // Console.WriteLine(CountCharacterGroups("a"));              // 1
        // Console.WriteLine(CountCharacterGroups("mississippi"));    // 8

        // Are Strings anagrams
        // - Return trus if both string contain same characters with same counts 
        // - "Listen, Silent" => True
        // Console.WriteLine(AreAnagramsRevision("Listen", "Silent"));          // True
        // Console.WriteLine(AreAnagramsRevision("Triangle", "Integral"));      // True
        // Console.WriteLine(AreAnagramsRevision("Debit Card", "Bad Credit"));  // True
        // Console.WriteLine(AreAnagramsRevision("Dormitory", "DirtyRoom"));   // True

        // Console.WriteLine(AreAnagramsRevision("Hello", "World"));            // False
        // Console.WriteLine(AreAnagramsRevision("Apple", "Papel"));            // True
        // Console.WriteLine(AreAnagramsRevision("Apple", "Appeal"));           // False
        // Console.WriteLine(AreAnagramsRevision("Rat", "Car"));               // False
    }
}
