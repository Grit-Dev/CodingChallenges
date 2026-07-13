using System;

namespace CodingChallenges.Challenges
{
    public class ChallengeSolutionsRunner : ChallengeSolutions
    {
        public void RunAllChallengeSolutions()
        {

            // PMG TO DO Code clean up ============================================================================

            // Next Code:
            // Find Most Frequent Character In Each Word
            Console.WriteLine(FindMostFrequentCharacterInEachWord("hello world")); // hello:l world:w
            Console.WriteLine(FindMostFrequentCharacterInEachWord("mississippi card")); // mississippi:i card:c
            Console.WriteLine(FindMostFrequentCharacterInEachWord("cat dog sun")); // cat:c dog:d sun:s
            Console.WriteLine(FindMostFrequentCharacterInEachWord("Apple banana")); // Apple:p banana:a
            Console.WriteLine(FindMostFrequentCharacterInEachWord("AaA bbB")); // AaA:A bbB:b
            Console.WriteLine(FindMostFrequentCharacterInEachWord("DOG cat")); // DOG:D cat:c
            Console.WriteLine(FindMostFrequentCharacterInEachWord("aabbcc")); // aabbcc:a
            Console.WriteLine(FindMostFrequentCharacterInEachWord("")); // ""
            Console.WriteLine(FindMostFrequentCharacterInEachWord(null!)); // ""

            // Count Words With All Unique Letters
            // Notes: Debugged this to find the solution - Needs more Revision (Est: 40 minutes)
            Console.WriteLine(CountWordsWithAllUniqueLetters("cat dog hello"));        // 2
            Console.WriteLine(CountWordsWithAllUniqueLetters("apple banana sun"));     // 1
            Console.WriteLine(CountWordsWithAllUniqueLetters("book moon tree"));       // 0
            Console.WriteLine(CountWordsWithAllUniqueLetters("Cat DOG hello"));        // 2
            Console.WriteLine(CountWordsWithAllUniqueLetters(""));                     // 0
            Console.WriteLine(CountWordsWithAllUniqueLetters(null!));                   // 0

            // Count Words With Repeated Letters
            Console.WriteLine(CountWordsWithRepeatedLetters("hello world cat"));       // 1
            Console.WriteLine(CountWordsWithRepeatedLetters("apple banana dog"));      // 2
            Console.WriteLine(CountWordsWithRepeatedLetters("cat dog sun"));           // 0
            Console.WriteLine(CountWordsWithRepeatedLetters("book moon tree"));        // 3
            Console.WriteLine(CountWordsWithRepeatedLetters("HELLO Cat DOG"));         // 1
            Console.WriteLine(CountWordsWithRepeatedLetters(""));                      // 0
            Console.WriteLine(CountWordsWithRepeatedLetters(null!));                    // 0

            // Remove Duplicate Words Preserve Order
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder("Hello world HELLO")); // Hello world
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder("Cyberpunk card vault CARD card"));// Cyberpunk card vault
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder("Apple apple APPLE banana")); // Apple banana
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder("cat dog cat sun DOG"));// cat dog sun
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder("")); // ""
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder(null!)); // ""

            // Find Word With Most Unique Characters
            Console.WriteLine(FindWordWithMostUniqueCharacters("apple banana card")); // apple
            Console.WriteLine(FindWordWithMostUniqueCharacters("cat dog sun"));       // cat
            Console.WriteLine(FindWordWithMostUniqueCharacters("HELLO CyberPunk world")); // CyberPunk
            Console.WriteLine(FindWordWithMostUniqueCharacters(""));                  // ""
            Console.WriteLine(FindWordWithMostUniqueCharacters(null!));               // ""

            // Find Most Common Word Length
            Console.WriteLine(FindMostCommonWordLength("cat dog sun elephant")); // 3
            Console.WriteLine(FindMostCommonWordLength("I am Paul John"));       // 4
            Console.WriteLine(FindMostCommonWordLength("cat dog apple house"));  // 3
            Console.WriteLine(FindMostCommonWordLength("a bb ccc dddd"));        // 1
            Console.WriteLine(FindMostCommonWordLength("a bb c dd"));             // 1
            Console.WriteLine(FindMostCommonWordLength("aa b cc d"));             // 2
            Console.WriteLine(FindMostCommonWordLength("hello"));                 // 5
            Console.WriteLine(FindMostCommonWordLength(""));                      // 0
            Console.WriteLine(FindMostCommonWordLength(null!));                   // 0

            // Find Most Frequent Character In Each Word
            Console.WriteLine(FindMostFrequentCharacterInEachWord("hello world") == "hello:l world:w");                 // True
            Console.WriteLine(FindMostFrequentCharacterInEachWord("mississippi card") == "mississippi:i card:c");       // True
            Console.WriteLine(FindMostFrequentCharacterInEachWord("apple banana") == "apple:p banana:a");               // True
            Console.WriteLine(FindMostFrequentCharacterInEachWord("cat dog sun") == "cat:c dog:d sun:s");               // True
            Console.WriteLine(FindMostFrequentCharacterInEachWord("Hello World") == "Hello:l World:W");                 // True
            Console.WriteLine(FindMostFrequentCharacterInEachWord("") == "");                                           // True                                     

            // Count Words With Repeated Letters
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("hello world cat") == 1);              // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("apple banana dog") == 2);             // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("cat dog sun") == 0);                  // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("book moon tree") == 3);               // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("Apple BANANA dog") == 2);             // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("abc def ghi") == 0);                  // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("mississippi card vault") == 1);       // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("aa bb cc") == 3);                     // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two("") == 0);                             // True
            Console.WriteLine(CountWordsWithRepeatedLetters_Two(null!) == 0);                          // True

            // Is Sentence Palindrome
            Console.WriteLine(IsSentencePalindrome("never odd or even") == true);                  // True
            Console.WriteLine(IsSentencePalindrome("Race car") == true);                           // True
            Console.WriteLine(IsSentencePalindrome("hello world") == false);                       // True
            Console.WriteLine(IsSentencePalindrome("nurses run") == true);                         // True
            Console.WriteLine(IsSentencePalindrome("Was it a rat I saw") == true);                 // True
            Console.WriteLine(IsSentencePalindrome("step on no pets") == true);                    // True
            Console.WriteLine(IsSentencePalindrome("madam") == true);                              // True
            Console.WriteLine(IsSentencePalindrome("not a palindrome") == false);                  // True
            Console.WriteLine(IsSentencePalindrome("") == false);                                  // True
            Console.WriteLine(IsSentencePalindrome(null!) == false);                               // True

            // Remove Duplicate Words Preserve Order
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Hello world HELLO") == "Hello world");                         // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Cyberpunk card vault CARD card") == "Cyberpunk card vault");   // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("hello world hello") == "hello world");                         // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("one two three two one") == "one two three");                   // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Apple apple APPLE banana") == "Apple banana");                 // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("A a B b C c") == "A B C");                                     // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Seagate factory IT factory") == "Seagate factory IT");         // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("hello") == "hello");                                           // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("") == "");                                                     // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two(null!) == "");                                                  // True

            // Find First Repeated Word
            Console.WriteLine(FindFirstRepeatedWord("hello world hello") == "hello");                    // True
            Console.WriteLine(FindFirstRepeatedWord("one two three two one") == "two");                  // True
            Console.WriteLine(FindFirstRepeatedWord("Cyberpunk card vault CARD") == "card");             // True
            Console.WriteLine(FindFirstRepeatedWord("Apple banana APPLE") == "Apple");                   // True
            Console.WriteLine(FindFirstRepeatedWord("red blue green BLUE red") == "blue");               // True
            Console.WriteLine(FindFirstRepeatedWord("cat dog bird dog") == "dog");                       // True
            Console.WriteLine(FindFirstRepeatedWord("Seagate factory IT factory") == "factory");         // True
            Console.WriteLine(FindFirstRepeatedWord("Same same same") == "Same");                        // True
            Console.WriteLine(FindFirstRepeatedWord("car bike train bus") == "");                        // True
            Console.WriteLine(FindFirstRepeatedWord("Cyberpunk card vault") == "");                      // True
            Console.WriteLine(FindFirstRepeatedWord("") == "");                                          // True
            Console.WriteLine(FindFirstRepeatedWord(null!) == "");                                        // True

            // Find First Word With Duplicate Letters
            Console.WriteLine(FindFirstWordWithDuplicateLetters("cat hello world") == "hello");                // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("dog apple banana") == "apple");               // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("cat dog sun") == "");                         // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("Cyberpunk card vault") == "");                 // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("one two book moon") == "book");               // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("ABC def Gg") == "Gg");                        // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("Tree apple banana") == "Tree");               // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("a bb cc") == "bb");                           // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters("") == "");                                    // True
            Console.WriteLine(FindFirstWordWithDuplicateLetters(null!) == "");                                 // True


            // Remove Duplicate Words Preserve Order
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello world hello"));
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Cyberpunk card vault card"));
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Apple apple APPLE banana") == "Apple banana");               
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("one two three two one") == "one two three");                  
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Seagate factory IT factory") == "Seagate factory IT");        
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("A a B b C c"));
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello") == "hello");
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("") == "");
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One(null!) == "");


            // Count Words Starting And Ending With Same Letter
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("level test radar code") == 3);        // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("Anna went to area") == 2);           // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("bob cat civic dog") == 2);           // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("apple banana orange") == 0);         // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("A b cc deed") == 4);                 // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("Test toast tent") == 3);             // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("") == 0);                            // True
            Console.WriteLine(CountWordsStartingAndEndingWithSameLetter(null!) == 0);                          // True

            // Revision: Title Case Except Small Words
            Console.WriteLine(TitleCaseExceptSmallWords_Two("the lord of the rings") == "The Lord of the Rings");                 // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("THE LORD OF THE RINGS") == "The Lord of the Rings");                 // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("cyberpunk and the card vault") == "Cyberpunk and the Card Vault");   // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("war of the worlds") == "War of the Worlds");                         // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("in the line of fire") == "In the Line of Fire");                     // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("hello OR goodbye") == "Hello or Goodbye");                           // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("a tale in the city") == "A Tale in the City");                       // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two("") == "");                                                           // True
            Console.WriteLine(TitleCaseExceptSmallWords_Two(null!) == "");                                                        // True

            // Revision: Are Anagrams
            Console.WriteLine(AreAnagrams_One("listen", "silent") == true);       // True
            Console.WriteLine(AreAnagrams_One("aab", "aba") == true);             // True
            Console.WriteLine(AreAnagrams_One("aab", "ab") == false);             // True
            Console.WriteLine(AreAnagrams_One("", "") == true);                   // True
            Console.WriteLine(AreAnagrams_One("Triangle", "Integral") == true);   // True
            Console.WriteLine(AreAnagrams_One("Apple", "Pabble") == false);       // True
            Console.WriteLine(AreAnagrams_One("abc", "abcd") == false);           // True
            Console.WriteLine(AreAnagrams_One(null!, "abc") == false);             // True
            Console.WriteLine(AreAnagrams_One("abc", null!) == false);             // True
            Console.WriteLine(AreAnagrams_One(null!, null!) == false);              // True

            // New Challenge: Is Sentence Palindrome
            Console.WriteLine(IsSentencePalindrome_One("never odd or even") == true);      // True
            Console.WriteLine(IsSentencePalindrome_One("hello world") == false);           // True
            Console.WriteLine(IsSentencePalindrome_One("nurses run") == true);             // True
            Console.WriteLine(IsSentencePalindrome_One("Race car") == true);               // True
            Console.WriteLine(IsSentencePalindrome_One("Was it a rat I saw") == true);     // True
            Console.WriteLine(IsSentencePalindrome_One("step on no pets") == true);        // True
            Console.WriteLine(IsSentencePalindrome_One("this is not one") == false);       // True
            Console.WriteLine(IsSentencePalindrome_One("") == false);                      // True
            Console.WriteLine(IsSentencePalindrome_One(null!) == false);                    // True

            // 5. New Challenge: Get Word Length Summary
            Console.WriteLine(GetWordLengthSummary_One("Cyberpunk card vault") == "Cyberpunk:9 card:4 vault:5");   // True
            Console.WriteLine(GetWordLengthSummary_One("I am Paul") == "I:1 am:2 Paul:4");                         // True
            Console.WriteLine(GetWordLengthSummary_One("hello world") == "hello:5 world:5");                       // True
            Console.WriteLine(GetWordLengthSummary_One("A bb ccc dddd") == "A:1 bb:2 ccc:3 dddd:4");               // True
            Console.WriteLine(GetWordLengthSummary_One("Seagate Factory IT") == "Seagate:7 Factory:7 IT:2");       // True
            Console.WriteLine(GetWordLengthSummary_One("One") == "One:3");                                        // True
            Console.WriteLine(GetWordLengthSummary_One("") == "");                                                 // True
            Console.WriteLine(GetWordLengthSummary_One(null!) == "");                                               // True

            // Remove Duplicate Words Preserve Order
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello world hello"));                         // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Cyberpunk card vault card"));        // True   ===> "Cyberpunk card vault"
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Apple apple APPLE banana") == "Apple banana");                 // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("one two three two one") == "one two three");                   // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Seagate factory IT factory") == "Seagate factory IT");         // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("A a B b C c"));                                     // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello") == "hello");                                           // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("") == "");                                                     // True
            Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One(null!) == "");                                                   // True

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

            // ======= Completed: ===============================================================

            // Count Words With Exact Length
            Console.WriteLine(CountWordsExactLength("Cyberpunk card Vault", 4));
            Console.WriteLine(CountWordsExactLength("I am Paul", 2));
            Console.WriteLine(CountWordsExactLength("Cyberpunk card Vault", 0));
            Console.WriteLine(CountWordsExactLength(null!, 4));

            // Remove Target Word
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

            // Replace Target Word
            Console.WriteLine(ReplaceTargetWordRev("hello world hello", "hello", "hi") == "hi world hi");
            Console.WriteLine(ReplaceTargetWordRev("Cyberpunk card vault", "card", "deck") == "Cyberpunk deck vault");
            Console.WriteLine(ReplaceTargetWordRev("HELLO world hello", "hello", "hi") == "hi world hi");
            Console.WriteLine(ReplaceTargetWordRev("Paul plays games", "plays", "writes") == "Paul writes games");
            Console.WriteLine(ReplaceTargetWordRev("Card card CARD vault", "card", "deck") == "deck deck deck vault");
            Console.WriteLine(ReplaceTargetWordRev("Cyberpunk vault", "card", "deck") == "Cyberpunk vault");
            Console.WriteLine(ReplaceTargetWordRev("", "hello", "hi") == "");
            Console.WriteLine(ReplaceTargetWordRev(null!, "hello", "hi") == "");
            Console.WriteLine(ReplaceTargetWordRev("hello world", "", "hi") == "hello world");
            Console.WriteLine(ReplaceTargetWordRev("hello world", null!, "hi") == "hello world");
            Console.WriteLine(ReplaceTargetWordRev("hello world", "world", null!) == "hello");
            Console.WriteLine(ReplaceTargetWordRev("   hello   world   hello   ", "hello", "hi") == "hi world hi");

            // Capitalise First Letter Of Each Word
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("hello world") == "Hello World");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("paul mcginley") == "Paul Mcginley");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("CYBERPUNK vault") == "CYBERPUNK Vault");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("single") == "Single");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("a b c") == "A B C");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("   hello   world   ") == "Hello World");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord("") == "");
            Console.WriteLine(CapitaliseFirstLetterOfEachWord(null!) == "");

            // Lowercase All Words Except First Letter
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("hello world") == "Hello World");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("pAUL mCKINLEY") == "Paul Mckinley");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("CYBERPUNK VAULT") == "Cyberpunk Vault");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("single") == "Single");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("a b c") == "A B C");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("   hELLO   wORLD   ") == "Hello World");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter("") == "");
            Console.WriteLine(LowercaseAllWordsExceptFirstLetter(null!) == "");

            // Title Case Except Small Words
            Console.WriteLine(TitleCaseExceptSmallWords("the lord of the rings"));
            Console.WriteLine(TitleCaseExceptSmallWords("cyberpunk and the card vault") == "Cyberpunk and the Card Vault");
            Console.WriteLine(TitleCaseExceptSmallWords("war of the worlds"));
            Console.WriteLine(TitleCaseExceptSmallWords("in the name of the king"));
            Console.WriteLine(TitleCaseExceptSmallWords("paul and the cyberpunk vault"));
            Console.WriteLine(TitleCaseExceptSmallWords("THE LORD OF THE RINGS"));
            Console.WriteLine(TitleCaseExceptSmallWords("   the   lord   of   the   rings   "));
            Console.WriteLine(TitleCaseExceptSmallWords("") == "");
            Console.WriteLine(TitleCaseExceptSmallWords(null!) == "");

            // Count Words Containing Letter
            Console.WriteLine(CountWordsContainingLetter("Cyberpunk card vault", 'a')); // 2
            Console.WriteLine(CountWordsContainingLetter("Paul plays games", 'p'));      // 2
            Console.WriteLine(CountWordsContainingLetter("Paul plays games", 'P'));      // 2
            Console.WriteLine(CountWordsContainingLetter("dog cat rat", 't'));           // 2
            Console.WriteLine(CountWordsContainingLetter("APPLE banana", 'a'));          // 2
            Console.WriteLine(CountWordsContainingLetter("hello", 'z'));                 // 0
            Console.WriteLine(CountWordsContainingLetter("", 'a'));                      // 0
            Console.WriteLine(CountWordsContainingLetter(null!, 'a'));                    // 0
            Console.WriteLine(CountWordsContainingLetter("   ", 'a'));                   // 0

            // Find Shortest Word
            Console.WriteLine(FindShortestWord("Cyberpunk card vault")); // card
            Console.WriteLine(FindShortestWord("I am Paul"));            // I
            Console.WriteLine(FindShortestWord("dog cat rat"));          // dog
            Console.WriteLine(FindShortestWord("one two three"));        // one
            Console.WriteLine(FindShortestWord("apple"));                // apple
            Console.WriteLine(FindShortestWord("a bb ccc"));             // a
            Console.WriteLine(FindShortestWord(""));                     // ""
            Console.WriteLine(FindShortestWord(null!));                   // ""

            // Are Anagrams
            Console.WriteLine(AreAnagramsTuesdayRevision_One("listen", "silent"));      // True
            Console.WriteLine(AreAnagramsTuesdayRevision_One("aab", "aba"));            // True
            Console.WriteLine(AreAnagramsTuesdayRevision_One("triangle", "integral"));  // True
            Console.WriteLine(AreAnagramsTuesdayRevision_One("evil", "vile"));          // True
            Console.WriteLine(AreAnagramsTuesdayRevision_One("aab", "ab"));            // False
            Console.WriteLine(AreAnagramsTuesdayRevision_One("hello", "helo"));        // False
            Console.WriteLine(AreAnagramsTuesdayRevision_One("abc", "abd"));           // False
            Console.WriteLine(AreAnagramsTuesdayRevision_One("", ""));                  // True
            Console.WriteLine(AreAnagramsTuesdayRevision_One(null!, "abc"));            // False
            Console.WriteLine(AreAnagramsTuesdayRevision_One("abc", null!));            // False
            Console.WriteLine(AreAnagramsTuesdayRevision_One("LISTEN", "silent"));      // True
            Console.WriteLine(AreAnagramsTuesdayRevision_One("AAB", "aba"));            // True

            // Find Longest Word              
            Console.WriteLine(FindLongestWordRevision_One("Cyberpunk card vault")); // Cyberpunk
            Console.WriteLine(FindLongestWordRevision_One("I am Paul"));            // Paul
            Console.WriteLine(FindLongestWordRevision_One("dog cat elephant"));     // elephant
            Console.WriteLine(FindLongestWordRevision_One("one three five"));       // three
            Console.WriteLine(FindLongestWordRevision_One("apple"));                // apple
            Console.WriteLine(FindLongestWordRevision_One(""));                     // ""
            Console.WriteLine(FindLongestWordRevision_One(null!));                   // ""

            // Remove Target Word.
            Console.WriteLine(RemoveTargetWord_One("hello world hello", "hello")); // world
            Console.WriteLine(RemoveTargetWord_One("Cyberpunk card vault card", "card")); // Cyberpunk vault
            Console.WriteLine(RemoveTargetWord_One("Paul plays games", "plays")); // Paul games
            Console.WriteLine(RemoveTargetWord_One("HELLO world hello", "hello")); // world
            Console.WriteLine(RemoveTargetWord_One("", "hello")); // "" // ""
            Console.WriteLine(RemoveTargetWord_One("hello world", "")); // hello world
            Console.WriteLine(RemoveTargetWord_One("hello world", null!)); // hello world

            // Find Shortest Word
            Console.WriteLine(FindShortestWord("Cyber punk card Vault")); // punk
            Console.WriteLine(FindShortestWord("I am Paul"));             // I
            Console.WriteLine(FindShortestWord("dog cat rat"));           // dog
            Console.WriteLine(FindShortestWord("one two three"));         // one
            Console.WriteLine(FindShortestWord("apple"));                 // apple
            Console.WriteLine(FindShortestWord(""));                      // ""
            Console.WriteLine(FindShortestWord(null!));                    // null

            // Count Words Ending with Letter
            Console.WriteLine(CountWordsEndingWithLetter("Cyberpunk card vault", 'd'));     // 1
            Console.WriteLine(CountWordsEndingWithLetter("Paul plays games", 's'));          // 2
            Console.WriteLine(CountWordsEndingWithLetter("dog cat rat", 't'));               // 2
            Console.WriteLine(CountWordsEndingWithLetter("Dog Cat Rat", 't'));               // 2
            Console.WriteLine(CountWordsEndingWithLetter("apple banana orange", 'e'));       // 2
            Console.WriteLine(CountWordsEndingWithLetter("hello", 'o'));                     // 1
            Console.WriteLine(CountWordsEndingWithLetter("", 'a'));                          // 0
            Console.WriteLine(CountWordsEndingWithLetter(null!, 'a'));                        // 0
            Console.WriteLine(CountWordsEndingWithLetter("   ", 'a'));                       // 0

            // Remove Words longer than Target 
            Console.WriteLine(RemoveWordsLongerThanTarget("Cyberpunk card Vault", 4));   // card
            Console.WriteLine(RemoveWordsLongerThanTarget("I am Paul", 4));              // I am Paul
            Console.WriteLine(RemoveWordsLongerThanTarget("dog cat elephant", 3));       // dog cat
            Console.WriteLine(RemoveWordsLongerThanTarget("apple pear plum", 4));        // pear plum
            Console.WriteLine(RemoveWordsLongerThanTarget("one two three four", 3));     // one two
            Console.WriteLine(RemoveWordsLongerThanTarget("", 5));                       // ""
            Console.WriteLine(RemoveWordsLongerThanTarget(null!, 5));                     // null or ""

            // Find Shortest Word
            Console.WriteLine(FindShortestWord("Cyber punk card Vault")); // punk
            Console.WriteLine(FindShortestWord("I am Paul"));             // I
            Console.WriteLine(FindShortestWord("dog cat rat"));           // dog
            Console.WriteLine(FindShortestWord("one two three"));         // one
            Console.WriteLine(FindShortestWord("apple"));                 // apple
            Console.WriteLine(FindShortestWord(""));                      // ""
            Console.WriteLine(FindShortestWord(null!));                    // null

            Console.WriteLine(ReverseEachWordInSentence(",Hell,o World"));
            Console.WriteLine(ReverseEachWordInSentence("Hello World"));        // olleH dlroW
            Console.WriteLine(ReverseEachWordInSentence("Cyberpunk vault"));    // knuprebyC tluav
            Console.WriteLine(ReverseEachWordInSentence("I am Paul"));          // I ma luaP
            Console.WriteLine(ReverseEachWordInSentence("dog cat"));            // god tac
            Console.WriteLine(ReverseEachWordInSentence("a"));                  // a
            Console.WriteLine(ReverseEachWordInSentence(""));                   // ""
            Console.WriteLine(ReverseEachWordInSentence(null!));                 // ""

            // Find Most Frequent Word
            Console.WriteLine(FindMostFrequentWord("hello world hello"));
            Console.WriteLine(FindMostFrequentWord("one two two three"));
            Console.WriteLine(FindMostFrequentWord("one one two two three"));
            Console.WriteLine(FindMostFrequentWord(""));
            Console.WriteLine(FindMostFrequentWord(null!));


            // Count Each Letter A to Z Revision
            Console.WriteLine(CountEachLetterAToZRevision("abcaba"));
            Console.WriteLine(CountEachLetterAToZRevision("Hello"));
            Console.WriteLine(CountEachLetterAToZRevision("aaaaa"));
            Console.WriteLine(CountEachLetterAToZRevision(""));


            // Count Words Longer than Target:
            Console.WriteLine(CountWordsLongerThanTarget("Cyberpunk card vault", 4));
            Console.WriteLine(CountWordsLongerThanTarget("I am Paul", 2));
            Console.WriteLine(CountWordsLongerThanTarget("Cyberpunk card vault", 3));
            Console.WriteLine(CountWordsLongerThanTarget("", 3));
            Console.WriteLine(CountWordsLongerThanTarget(null!, 3));

            // Count Letters Case-Insensitive
            Console.WriteLine(CountLettersCaseInsensitive("abc1234"));
            Console.WriteLine(CountLettersCaseInsensitive("Cyberpunk 2077"));
            Console.WriteLine(CountLettersCaseInsensitive("12345"));
            Console.WriteLine(CountLettersCaseInsensitive(null!));

            // Are Anagrams
            Console.WriteLine(AreAnagramsRevisionSat("aab", "aba"));           // True
            Console.WriteLine(AreAnagramsRevisionSat("Listen", "Silent"));     // True
            Console.WriteLine(AreAnagramsRevisionSat("abc", "cab"));           // True
            Console.WriteLine(AreAnagramsRevisionSat("aab", "abb"));           // False
            Console.WriteLine(AreAnagramsRevisionSat("aabc", "abcc"));         // False
            Console.WriteLine(AreAnagramsRevisionSat("abc", "abd"));           // False
            Console.WriteLine(AreAnagramsRevisionSat("", ""));                 // True
            Console.WriteLine(AreAnagramsRevisionSat(null!, "abc"));            // False
            Console.WriteLine(AreAnagramsRevisionSat("abc", null!));            // False
            Console.WriteLine(AreAnagramsRevisionSat("Hello", "World"));       // False
            Console.WriteLine(AreAnagramsRevisionSat("AaBb", "bBaA"));         // True
            Console.WriteLine(AreAnagramsRevisionSat("Miss", "Sims"));         // False

            // Remove Punctation and Symbols
            Console.WriteLine(RemovePunctationAndSymbols("C# costs £10!"));
            Console.WriteLine(RemovePunctationAndSymbols("He#llo Wo#rld!"));
            Console.WriteLine(RemovePunctationAndSymbols("Hell#o Wo!rld!"));
            Console.WriteLine(RemovePunctationAndSymbols(""));
            Console.WriteLine(RemovePunctationAndSymbols(null!));

            // Optional Stretch: Count Each Letter A-Z
            Console.WriteLine(CountEachLetterAToZ("aaaaa"));            // A:5
            Console.WriteLine(CountEachLetterAToZ("abcaba"));           // A:3 B:2 C:1
            Console.WriteLine(CountEachLetterAToZ("Hello"));            // H:1 E:1 L:2 O:1
            Console.WriteLine(CountEachLetterAToZ("Mississippi"));      // M:1 I:4 S:4 P:2
            Console.WriteLine(CountEachLetterAToZ("A A A"));            // A:3
            Console.WriteLine(CountEachLetterAToZ("123ABC!"));          // A:1 B:1 C:1
            Console.WriteLine(CountEachLetterAToZ(""));                 // ""
            Console.WriteLine(CountEachLetterAToZ(null!));               // ""
            Console.WriteLine(CountEachLetterAToZ("The Quick Brown Fox")); // T:1 H:1 E:1 Q:1 U:1 ...

            // Count Digits in String
            Console.WriteLine(CountDigitsInString("123"));                // 3
            Console.WriteLine(CountDigitsInString("Hello123"));           // 3
            Console.WriteLine(CountDigitsInString("A1B2C3"));             // 3
            Console.WriteLine(CountDigitsInString("No Digits"));          // 0
            Console.WriteLine(CountDigitsInString(""));                   // 0
            Console.WriteLine(CountDigitsInString(null!));                 // 0
            Console.WriteLine(CountDigitsInString("007"));                // 3
            Console.WriteLine(CountDigitsInString("Room 101"));           // 3
            Console.WriteLine(CountDigitsInString("1a2b3c4d5e"));         // 5
            Console.WriteLine(CountDigitsInString("£100.50"));            // 5

            //  Are Anagams
            // - Return true if both string contain the same characters with the same counts. 
            // - Return false if either string is null 
            // Make it case insensitive. 
            // Example: aab , aba = true
            Console.WriteLine(AreAnagramsRevisionFriday("aab", "aba"));           // True
            Console.WriteLine(AreAnagramsRevisionFriday("Listen", "Silent"));     // True
            Console.WriteLine(AreAnagramsRevisionFriday("abc", "cab"));           // True
            Console.WriteLine(AreAnagramsRevisionFriday("aab", "abb"));           // False
            Console.WriteLine(AreAnagramsRevisionFriday("aabc", "abcc"));         // False
            Console.WriteLine(AreAnagramsRevisionFriday("abc", "abd"));           // False
            Console.WriteLine(AreAnagramsRevisionFriday("", ""));                 // True
            Console.WriteLine(AreAnagramsRevisionFriday(null!, "abc"));            // False
            Console.WriteLine(AreAnagramsRevisionFriday("abc", null!));            // False
            Console.WriteLine(AreAnagramsRevisionFriday("Hello", "World"));       // False
            Console.WriteLine(AreAnagramsRevisionFriday("AaBb", "bBaA"));         // True
            Console.WriteLine(AreAnagramsRevisionFriday("Miss", "Sims"));         // False

            // Revision Count Unique Characters Case-Insensitive
            // Return how many different characters  appear in a string 
            // Example Hello => 4
            Console.WriteLine(CountUniqueCharacters("Hello"));        // 4
            Console.WriteLine(CountUniqueCharacters("HELLO"));        // 4
            Console.WriteLine(CountUniqueCharacters("Swiss"));        // 3
            Console.WriteLine(CountUniqueCharacters("aabbcc"));       // 3
            Console.WriteLine(CountUniqueCharacters("abcde"));        // 5
            Console.WriteLine(CountUniqueCharacters("AAAA"));         // 1
            Console.WriteLine(CountUniqueCharacters(""));            // 0
            Console.WriteLine(CountUniqueCharacters(null!));          // 0
            Console.WriteLine(CountUniqueCharacters("Mississippi")); // 4
            Console.WriteLine(CountUniqueCharacters("AaBbCc"));      // 3

            // Remove punctuation  Characters
            // Return a new String when punctuation is removed
            // Example: Hello! = Hello
            Console.WriteLine(RemovePunctuationOnly("Hello!"));                    // Hello
            Console.WriteLine(RemovePunctuationOnly("Hello, World!"));             // Hello World
            Console.WriteLine(RemovePunctuationOnly("What's up?"));                // Whats up
            Console.WriteLine(RemovePunctuationOnly("...Hello..."));               // Hello
            Console.WriteLine(RemovePunctuationOnly("No punctuation"));            // No punctuation
            Console.WriteLine(RemovePunctuationOnly(""));                          // ""
            Console.WriteLine(RemovePunctuationOnly(null!));                        // ""
            Console.WriteLine(RemovePunctuationOnly("#CSharp!"));                  // CSharp
            Console.WriteLine(RemovePunctuationOnly("A,B.C!D?"));                  // ABCD

            // Keep only Letters and Spaces
            // Return a new string containing only letters and spaces.
            // Example: "Hello, World! 123" = Hello World
            Console.WriteLine(KeepOnlyLettersAndSpaces("C# Programming"));    // C Programming
            Console.WriteLine(KeepOnlyLettersAndSpaces("12345"));             // ""
            Console.WriteLine(KeepOnlyLettersAndSpaces("Hello World"));       // Hello World
            Console.WriteLine(KeepOnlyLettersAndSpaces(""));                  // ""
            Console.WriteLine(KeepOnlyLettersAndSpaces(null!));                // ""
            Console.WriteLine(KeepOnlyLettersAndSpaces("A1 B2 C3"));          // A B C
            Console.WriteLine(KeepOnlyLettersAndSpaces("!@#$%^"));            // ""
            Console.WriteLine(KeepOnlyLettersAndSpaces("Johnny Silverhand"));     // Johnny Silverhand

            //  Count Unique characters
            // Return how many different characters appear in a string. 
            Console.WriteLine(CountUniqueCharacters("Hello"));         // 4
            Console.WriteLine(CountUniqueCharacters("aabbcc"));        // 3
            Console.WriteLine(CountUniqueCharacters("Swiss"));         // 3
            Console.WriteLine(CountUniqueCharacters("abcde"));         // 5
            Console.WriteLine(CountUniqueCharacters("aaaa"));          // 1
            Console.WriteLine(CountUniqueCharacters(""));             // 0
            Console.WriteLine(CountUniqueCharacters(null!));           // 0
            Console.WriteLine(CountUniqueCharacters("Mississippi"));  // 4
            Console.WriteLine(CountUniqueCharacters("112233"));       // 3
            Console.WriteLine(CountUniqueCharacters("CSharp"));       // 6

            // Get Last letters of each word.
            // Return a string made from the first letter of each word
            Console.WriteLine(GetLastLetters("Hello World"));                     // od
            Console.WriteLine(GetLastLetters("Paul McGinley"));                   // ly
            Console.WriteLine(GetLastLetters("John Ronald Reuel Tolkien"));       //
            Console.WriteLine(GetLastLetters("Single"));                          // e
            Console.WriteLine(GetLastLetters(""));                                // ""
            Console.WriteLine(GetLastLetters(null!));                              // ""
            Console.WriteLine(GetLastLetters("   Hello    World   "));            // od
            Console.WriteLine(GetLastLetters("The Quick Brown Fox"));             // eknx
            Console.WriteLine(GetLastLetters("One Two Three Four Five"));         // eoere
            Console.WriteLine(GetLastLetters("A B C D"));                         // abcd
            Console.WriteLine(GetLastLetters("Programming Challenges"));          // gs
            Console.WriteLine(GetLastLetters("Red Green Blue"));                  // den
            Console.WriteLine(GetLastLetters("Test"));                            // t

            // Get First Letters of Each word
            //Return a string made from the first letter of each word
            Console.WriteLine(GetFirstLetters("Hello World"));                     // hw
            Console.WriteLine(GetFirstLetters("Paul McGinley"));                   // pm
            Console.WriteLine(GetFirstLetters("John Ronald Reuel Tolkien"));       // jrrt
            Console.WriteLine(GetFirstLetters("Single"));                          // s
            Console.WriteLine(GetFirstLetters(""));                                // ""
            Console.WriteLine(GetFirstLetters(null!));                              // ""
            Console.WriteLine(GetFirstLetters("   Hello    World   "));            // hw
            Console.WriteLine(GetFirstLetters("The Quick Brown Fox"));             // tqbf
            Console.WriteLine(GetFirstLetters("One Two Three Four Five"));         // ottff

            // Count Symbols:
            // Return how many sysmbols characters are in a string. 
            // Note: I added punctation into mix
            Console.WriteLine(CountSymbols("C# costs £10"));
            Console.WriteLine(CountSymbols("Hello World"));
            Console.WriteLine(CountSymbols("$100"));
            Console.WriteLine(CountSymbols("@#$"));
            Console.WriteLine(CountSymbols("! Hello ?"));
            Console.WriteLine(CountSymbols(""));
            Console.WriteLine(CountSymbols(null!));
            Console.WriteLine(CountSymbols("12345"));
            Console.WriteLine(CountSymbols("C# & .NET"));
            Console.WriteLine(CountSymbols("50% off!"));

            // Revision Count character groups
            // Return how many consecutive character groups are in a string
            Console.WriteLine(CountCharacterGroupsConsecutively("aaabc"));
            Console.WriteLine(CountCharacterGroupsConsecutively("Helloo"));
            Console.WriteLine(CountCharacterGroupsConsecutively("a"));
            Console.WriteLine(CountCharacterGroupsConsecutively("aaaa"));
            Console.WriteLine(CountCharacterGroupsConsecutively("ababa"));
            Console.WriteLine(CountCharacterGroupsConsecutively(""));
            Console.WriteLine(CountCharacterGroupsConsecutively(null!));
            Console.WriteLine(CountCharacterGroupsConsecutively("Mississippi"));
            Console.WriteLine(CountCharacterGroupsConsecutively("112233"));
            Console.WriteLine(CountCharacterGroupsConsecutively("bookkeeper"));

            //  Revision are anagrams
            // Return true if both string contain the same character with the same counts
            //  Case-insensitive: null = false
            Console.WriteLine(AreAnagrams("Listen", "Silent"));           // True
            Console.WriteLine(AreAnagrams("aab", "ab"));                 // False
            Console.WriteLine(AreAnagrams("Debit Card", "Bad Credit"));  // True
            Console.WriteLine(AreAnagrams("Triangle", "Integral"));      // True
            Console.WriteLine(AreAnagrams("Hello", "World"));            // False
            Console.WriteLine(AreAnagrams("", ""));                      // True
            Console.WriteLine(AreAnagrams(null!, "abc"));                // False
            Console.WriteLine(AreAnagrams("abc", null!));                // False
            Console.WriteLine(AreAnagrams("abc", "cab"));               // True
            Console.WriteLine(AreAnagrams("aabbcc", "abcabc"));         // True


            // Is Panagram
            // - Return true if senetence contains ecer letter: a-z atleast once.
            // - Example "The quick  brown fox jumps over the lazy dog" - > true
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog")); // True
            Console.WriteLine(IsPangram("Hello World"));                                 // False
            Console.WriteLine(IsPangram("Pack my box with five dozen liquor jugs"));     // True
            Console.WriteLine(IsPangram("Sphinx of black quartz, judge my vow"));        // True
            Console.WriteLine(IsPangram("abcdefghijklmnopqrstuvwxyz"));                  // True
            Console.WriteLine(IsPangram("abcdefghijklmnopqrstuvwxy"));                   // False
            Console.WriteLine(IsPangram(""));                                            // False
            Console.WriteLine(IsPangram(null!));                                         // False
            Console.WriteLine(IsPangram("The five boxing wizards jump quickly"));        // True
            Console.WriteLine(IsPangram("A quick movement of the enemy will jeopardize five gunboats")); // false

            // Get initals From name
            // - Return the initals of the full name
            Console.WriteLine(GetInitials("Paul Kinley"));                      // PK
            Console.WriteLine(GetInitials("John Ronald Reuel Tolkien"));        // JRRT
            Console.WriteLine(GetInitials("Paul"));                             // P
            Console.WriteLine(GetInitials("bob smith"));                        // BS
            Console.WriteLine(GetInitials("mary jane watson parker"));          // MJWP
            Console.WriteLine(GetInitials(""));                                 // ""
            Console.WriteLine(GetInitials(null!));                               // ""
            Console.WriteLine(GetInitials("   John    Smith   "));              // JS
            Console.WriteLine(GetInitials("Jean-Luc Picard"));                  // JP
            Console.WriteLine(GetInitials("Bilbo Baggins"));                    // BB

            // Warm Up: Count Punctuation Characters 
            Console.WriteLine(CountPunctuationCharacters("Wait...What?") == 4);      // 4
            Console.WriteLine(CountPunctuationCharacters("Hello, World!") == 2);     // 2
            Console.WriteLine(CountPunctuationCharacters("No punctuation") == 0);    // 0
            Console.WriteLine(CountPunctuationCharacters("C# is great.") == 2);      // 2
            Console.WriteLine(CountPunctuationCharacters("") == 0);                  // 0
            Console.WriteLine(CountPunctuationCharacters(null!) == 0);                // 0
            Console.WriteLine(CountPunctuationCharacters("...") == 3);               // 3
            Console.WriteLine(CountPunctuationCharacters("???") == 3);               // 3
            Console.WriteLine(CountPunctuationCharacters("One.Two,Three!") == 3);    // 3

            // Remove Consecutive Duplicate Characters
            // - Return a string where consecutive duplicate characters are 
            // - reduced to one.
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aaabbc"));        // abc
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("a"));             // a
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aaaaa"));         // a
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("ababa"));         // ababa
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aabbcc"));        // abc
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("aaAAaa"));        // aAAa
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters(""));              // ""         
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("112233"));        // 123
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("111223311"));     // 1231
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("Hellooo!!!"));    // Helo!
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("   hello   "));   // " hello "
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("AABBCC"));        // ABC
            Console.WriteLine(RemoveConsecutiveDuplicateCharacters("Mississippi"));   // Misisipi

            // Count character Groups: 
            // - Return how many consecutive character groups are in a string
            Console.WriteLine(CountCharacterGroups("aabbc"));          // 3
            Console.WriteLine(CountCharacterGroups("helo"));           // 4
            Console.WriteLine(CountCharacterGroups("aaabbbccc"));      // 3
            Console.WriteLine(CountCharacterGroups("aaaa"));           // 1
            Console.WriteLine(CountCharacterGroups("ababa"));          // 5
            Console.WriteLine(CountCharacterGroups(""));               // 0
            Console.WriteLine(CountCharacterGroups(null!));             // 0
            Console.WriteLine(CountCharacterGroups("a"));              // 1
            Console.WriteLine(CountCharacterGroups("mississippi"));    // 8

            // Are Strings anagrams
            // - Return trus if both string contain same characters with same counts 
            Console.WriteLine(AreAnagramsRevision("Listen", "Silent"));          // True
            Console.WriteLine(AreAnagramsRevision("Triangle", "Integral"));      // True
            Console.WriteLine(AreAnagramsRevision("Debit Card", "Bad Credit"));  // True
            Console.WriteLine(AreAnagramsRevision("Dormitory", "DirtyRoom"));   // True
            Console.WriteLine(AreAnagramsRevision("Hello", "World"));            // False
            Console.WriteLine(AreAnagramsRevision("Apple", "Papel"));            // True
            Console.WriteLine(AreAnagramsRevision("Apple", "Appeal"));           // False
            Console.WriteLine(AreAnagramsRevision("Rat", "Car"));               // False

            // Count Characters Except Spaces
            Console.WriteLine($"Hello World should return 10 => Answer: {CountCharactersExceptSpaces("Hello World") == 10}");
            Console.WriteLine($" Cyberpunk Vault  should return 14 => Answer: {CountCharactersExceptSpaces(" Cyberpunk Vault ") == 14}");
            Console.WriteLine($"Paul should return 4 => Answer: {CountCharactersExceptSpaces("Paul") == 4}");
            Console.WriteLine($"Empty string should return 0 => Answer: {CountCharactersExceptSpaces("") == 0}");
            Console.WriteLine($"Null should return 0 => Answer: {CountCharactersExceptSpaces(null!) == 0}");

            // Are Strings Anagrams
            Console.WriteLine($"listen and silent should return true => Answer: {AreStringsAnagrams("listen", "silent")}");
            Console.WriteLine($"triangle and integral should return true => Answer: {AreStringsAnagrams("triangle", "integral")}");
            Console.WriteLine($"hello and world should return false => Answer: {AreStringsAnagrams("hello", "world")}");
            Console.WriteLine($"aab and aba should return true => Answer: {AreStringsAnagrams("aab", "aba")}");
            Console.WriteLine($"aab and ab should return false => Answer: {AreStringsAnagrams("aab", "ab")}");
            Console.WriteLine($"empty and empty should return true => Answer: {AreStringsAnagrams("", "")}");
            Console.WriteLine($"null and test should return false => Answer: {AreStringsAnagrams(null!, "test")}");

            // Find First Non-Repeating Character
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacter("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacter("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacter("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacter("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacter("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacter(null!)}");

            // Find Last Non - Repeating Character
            Console.WriteLine($"swiss should return i => Answer: {FindLastNonRepeatingCharacter("swiss")}");
            Console.WriteLine($"hello should return o => Answer: {FindLastNonRepeatingCharacter("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindLastNonRepeatingCharacter("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindLastNonRepeatingCharacter("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindLastNonRepeatingCharacter("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindLastNonRepeatingCharacter(null!)}");

            // Optional Stretch: Count Word Occurrences
            Console.WriteLine($"hello world hello, target hello should return 2 => Answer: {CountWordOccurrences("hello world hello", "hello")}");
            Console.WriteLine($"Cyberpunk card vault, target card should return 1 => Answer: {CountWordOccurrences("Cyberpunk card vault", "card")}");
            Console.WriteLine($"one two three, target four should return 0 => Answer: {CountWordOccurrences("one two three", "four")}");
            Console.WriteLine($"HELLO hello HeLLo, target hello should return 3 => Answer: {CountWordOccurrences("HELLO hello HeLLo", "hello")}");
            Console.WriteLine($"Null sentence should return 0 => Answer: {CountWordOccurrences(null!, "hello")}");
            Console.WriteLine($"Null target should return 0 => Answer: {CountWordOccurrences("hello world", null!)}");

            // Compress Consecutive Repeated Characters
            Console.WriteLine($"aaabbc should return a3b2c1 => Answer: {CompressConsecutiveRepeatedCharacters("aaabbc") == "a3b2c1"}");
            Console.WriteLine($"hello should return h1e1l2o1 => Answer: {CompressConsecutiveRepeatedCharacters("hello") == "h1e1l2o1"}");
            Console.WriteLine($"ababa should return a1b1a1b1a1 => Answer: {CompressConsecutiveRepeatedCharacters("ababa") == "a1b1a1b1a1"}");
            Console.WriteLine($"a should return a1 => Answer: {CompressConsecutiveRepeatedCharacters("a")}" == "a");
            Console.WriteLine($"Empty string should return empty => Answer: {CompressConsecutiveRepeatedCharacters("") == ""}");
            Console.WriteLine($"Null should return empty => Answer: {CompressConsecutiveRepeatedCharacters(null!) == ""}");


            // New Challenge: Find Longest Word
            Console.WriteLine($"Cyberpunk card vault should return Cyberpunk => Answer: {FindLongestWord("Cyberpunk card vault")}");
            Console.WriteLine($"I am Paul should return Paul => Answer: {FindLongestWord("I am Paul")}");
            Console.WriteLine($"one three seven should return three => Answer: {FindLongestWord("one three seven")}");
            Console.WriteLine($"hello should return hello => Answer: {FindLongestWord("hello")}");
            Console.WriteLine($"Empty string should return empty => Answer: {FindLongestWord("")}");
            Console.WriteLine($"Null should return empty => Answer: {FindLongestWord(null!)}");


            // Remove Duplicate Characters Preserve Order
            Console.WriteLine($"hello should return helo => Answer: {RemoveDuplicateCharactersPreserveOrder("hello")}");
            Console.WriteLine($"swiss should return swi => Answer: {RemoveDuplicateCharactersPreserveOrder("swiss")}");
            Console.WriteLine($"Cyberpunk should return Cyberpunk => Answer: {RemoveDuplicateCharactersPreserveOrder("Cyberpunk")}");
            Console.WriteLine($"aabbcc should return abc => Answer: {RemoveDuplicateCharactersPreserveOrder("aabbcc")}");
            Console.WriteLine($"Empty string should return empty => Answer: {RemoveDuplicateCharactersPreserveOrder("")}");
            Console.WriteLine($"Null should return empty => Answer: {RemoveDuplicateCharactersPreserveOrder(null!)}");

            // Count Letters Only
            Console.WriteLine($"abc123! should return 3 => Answer: {CountLettersOnly("abc123!")}");
            Console.WriteLine($"Cyberpunk 2077 should return 9 => Answer: {CountLettersOnly("Cyberpunk 2077")}");
            Console.WriteLine($"12345 should return 0 => Answer: {CountLettersOnly("12345")}");
            Console.WriteLine($"Empty string should return 0 => Answer: {CountLettersOnly("")}");
            Console.WriteLine($"Null should return 0 => Answer: {CountLettersOnly(null!)}");

            //First Non-Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacter("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacter("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacter("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacter("aabb")}");
            Console.WriteLine($"Cyberpunk should return c or C depending on your casing rule => Answer: {FindFirstNonRepeatingCharacter("Cyberpunk")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacter("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacter(null!)}");

            // Compress Repeated Characters:
            Console.WriteLine(CompressRepeatedCharacter("aaabbc"));
            Console.WriteLine(CompressRepeatedCharacter("hello"));
            Console.WriteLine(CompressRepeatedCharacter("a"));
            Console.WriteLine(CompressRepeatedCharacter("a1"));
            Console.WriteLine(CompressRepeatedCharacter(""));
            Console.WriteLine(CompressRepeatedCharacter(null!));

            // Find the longest word
            Console.WriteLine(FindLongestWordLength("Cyberpunk card vault") == 9);
            Console.WriteLine(FindLongestWordLength("dog cat mouse") == 5);
            Console.WriteLine(FindLongestWordLength("hello") == 5);
            Console.WriteLine(FindLongestWordLength("") == 0);
            Console.WriteLine(FindLongestWordLength("a ab abc abcd") == 4);

            // Count even numbers (Sum)
            Console.WriteLine(SumEvenNumbersRev([1, 2, 3, 4, 5, 6]));
            Console.WriteLine(SumEvenNumbersRev([2, 4, 6, 8]));
            Console.WriteLine(SumEvenNumbersRev([1, 3, 5]));
            Console.WriteLine(SumEvenNumbersRev([]));

            // Replace target with value 
            Console.WriteLine(string.Join(",", ReplaceTarget([1, 5, 10, 5], 5, 99)));
            Console.WriteLine(string.Join(",", ReplaceTarget([5, 5, 5], 5, 0)));
            Console.WriteLine(string.Join(",", ReplaceTarget([1, 2, 3], 9, 100)));

            // Split positive and negative numbers: 
            Console.WriteLine(string.Join(",", SplitPosNeg([1, -2, 3, -4, 0])));
            Console.WriteLine(string.Join(",", SplitPosNeg([-1, -2, -3])));
            Console.WriteLine(string.Join(",", SplitPosNeg([1, 2, 3])));
            Console.WriteLine(string.Join(",", SplitPosNeg([0, 0, 0])));

            // Count Matching Numbers
            Console.WriteLine(CountMatching([1, 2, 2, 3, 2], 2));
            Console.WriteLine(CountMatching([5, 5, 5, 5], 5));
            Console.WriteLine(CountMatching([1, 2, 3], 9));

            // Remove Target  From array
            Console.WriteLine(string.Join(",", RemoveTarget([1, 2, 3, 2, 4], 2)));
            Console.WriteLine(string.Join(",", RemoveTarget([5, 5, 5], 5)));
            Console.WriteLine(string.Join(",", RemoveTarget([1, 2, 3], 9)));

            // Move Target to the end 
            Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3, 2, 4], 2)));
            Console.WriteLine(string.Join(",", MoveTargetToEnd([5, 1, 5, 2], 5)));
            Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3], 9)));

            // Replace Target With Value
            Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 99 should return [1, 99, 5, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 0, 5, 0], 0, 99))}]");
            Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 0 should return [1, 0, 5, 0] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 0, 5, 0], 0, 0))}]");
            Console.WriteLine($"[1, 5, 10, 5], target 5, replacement 99 should return [1, 99, 10, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 5, 10, 5], 5, 99))}]");
            Console.WriteLine($"[3, 4, 5], target 9, replacement 0 should return [3, 4, 5] => Answer: [{string.Join(", ", ReplaceTargetWithValue([3, 4, 5], 9, 0))}]");
            Console.WriteLine($"[7], target 7, replacement 1 should return [1] => Answer: [{string.Join(", ", ReplaceTargetWithValue([7], 7, 1))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue([], 5, 99))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue(null!, 5, 99))}]");

            // Split Positive And Negative Numbers
            Console.WriteLine($"[1, -2, 3, -4, 0] should return [1, 3, -2, -4] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([1, -2, 3, -4, 0]))}]");
            Console.WriteLine($"[-1, -2, 5] should return [5, -1, -2] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([-1, -2, 5]))}]");
            Console.WriteLine($"[0, 0] should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([0, 0]))}]");
            Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([1, 2, 3]))}]");
            Console.WriteLine($"[-1, -2, -3] should return [-1, -2, -3] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([-1, -2, -3]))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([]))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers(null!))}]");

            // Sum Positive Numbers
            Console.WriteLine(SumPositiveNumbersRev2([1, 2, 4]));
            Console.WriteLine(SumPositiveNumbersRev2([0, 0, 0, 5]));
            Console.WriteLine(SumPositiveNumbersRev2([-1, -2, -3, 5]));
            Console.WriteLine(SumPositiveNumbersRev2([1]));
            Console.WriteLine(SumPositiveNumbersRev2([]));
            Console.WriteLine(SumPositiveNumbersRev2(null!));

            // Merge Arrays(Duplicates allowed)
            Console.WriteLine($"[1, 2], [3, 4] should return [1, 2, 3, 4] => Answer: [{string.Join(", ", MergeArrays([1, 2], [3, 4]))}]");
            Console.WriteLine($"[1, 2], [2, 3] should return [1, 2, 2, 3] => Answer: [{string.Join(", ", MergeArrays([1, 2], [2, 3]))}]");
            Console.WriteLine($"[], [1, 2] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([], [1, 2]))}]");
            Console.WriteLine($"[1, 2], [] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([1, 2], []))}]");
            Console.WriteLine($"null, [1, 2] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays(null!, [1, 2]))}]");
            Console.WriteLine($"[1, 2], null should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([1, 2], null!))}]");
            Console.WriteLine($"null, null should return [] => Answer: [{string.Join(", ", MergeArrays(null!, null!))}]");
            Console.WriteLine($"[], [] should return [] => Answer: [{string.Join(", ", MergeArrays([], []))}]");

            // Find Last Index of Target
            Console.WriteLine($"[1, 5, 10, 5], target 5 should return 3 => Answer: {FindLastIndexOfTarget([1, 5, 10, 5], 5)}");
            Console.WriteLine($"[3, 4, 5], target 9 should return -1 => Answer: {FindLastIndexOfTarget([3, 4, 5], 9)}");
            Console.WriteLine($"[7], target 7 should return 0 => Answer: {FindLastIndexOfTarget([7], 7)}");
            Console.WriteLine($"[5, 5, 5], target 5 should return 2 => Answer: {FindLastIndexOfTarget([5, 5, 5], 5)}");
            Console.WriteLine($"Empty array, target 1 should return -1 => Answer: {FindLastIndexOfTarget([], 1)}");
            Console.WriteLine($"Null, target 1 should return -1 => Answer: {FindLastIndexOfTarget(null!, 1)}");

            // Remove Duplicate numbers:
            Console.WriteLine($"[1, 2, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([1, 2, 2, 3]))}]");
            Console.WriteLine($"[5, 5, 5] should return [5] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([5, 5, 5]))}]");
            Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([1, 2, 3]))}]");
            Console.WriteLine($"[4, 1, 4, 2, 1] should return [4, 1, 2] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([4, 1, 4, 2, 1]))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([]))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(null!))}]");

            // Find missing number: You are given numbers from 1 to n, but one number is missing.
            Console.WriteLine($"[1, 2, 4, 5] should return 3 => Answer: {FindMissingNumber([1, 2, 4, 5])}");
            Console.WriteLine($"[1, 3, 4, 5] should return 2 => Answer: {FindMissingNumber([1, 3, 4, 5])}");
            Console.WriteLine($"[2, 3, 4, 5] should return 1 => Answer: {FindMissingNumber([2, 3, 4, 5])}");
            Console.WriteLine($"[1, 2, 3, 4] should return 5 => Answer: {FindMissingNumber([1, 2, 3, 4])}");
            Console.WriteLine($"[1, 2, 3, 5, 6] should return 4 => Answer: {FindMissingNumber([1, 2, 3, 5, 6])}");
            Console.WriteLine($"Empty array should return 0 => Answer: {FindMissingNumber([])}");
            Console.WriteLine($"Null should return 0 => Answer: {FindMissingNumber(null!)}");

            // Two Sum Revision:
            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision([2, 7, 11, 15], 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision([4, 5], 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRevision([3, 2, 4], 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision([3, 3], 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRevision([1, 8, 10, 2], 10))}]");

            // Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacterRev("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacterRev("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacterRev("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacterRev("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacterRev("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacterRev(null!)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacterRev("Cyberpunk")}");

            // Count Negative Numbers: 
            Console.WriteLine(CountNegativeNumbers([1, -2, 3, -4, 5]));
            Console.WriteLine(CountNegativeNumbers([-1, -2, -3]));
            Console.WriteLine(CountNegativeNumbers([0, 0, 0]));
            Console.WriteLine(CountNegativeNumbers([10]));
            Console.WriteLine(CountNegativeNumbers([]));
            Console.WriteLine(CountNegativeNumbers(null!));

            // Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacter("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacter("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacter("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacter("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacter("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacter(null!)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacter("Cyberpunk")}");

            // Find First Repeated Numbers
            Console.WriteLine($"[1, 2, 3, 2] should return 2 => Answer: {FindFirstRepeatedNumber([1, 2, 3, 2])}");
            Console.WriteLine($"[5, 1, 5, 2] should return 5 => Answer: {FindFirstRepeatedNumber([5, 1, 5, 2])}");
            Console.WriteLine($"[4, 4, 4] should return 4 => Answer: {FindFirstRepeatedNumber([4, 4, 4])}");
            Console.WriteLine($"[1, 2, 3] should return 0 => Answer: {FindFirstRepeatedNumber([1, 2, 3])}");
            Console.WriteLine($"Empty array should return 0 => Answer: {FindFirstRepeatedNumber([])}");
            Console.WriteLine($"Null should return 0 => Answer: {FindFirstRepeatedNumber(null!)}");

            // Count Positive Numbers
            Console.WriteLine(CountPositiveNumbers([1, -2, 3, 0, 5]));
            Console.WriteLine(CountPositiveNumbers([-1, -2, -3]));
            Console.WriteLine(CountPositiveNumbers([0, 0, 0]));
            Console.WriteLine(CountPositiveNumbers([10]));
            Console.WriteLine(CountPositiveNumbers(null!));
            Console.WriteLine(CountPositiveNumbers([]));

            // TwoSumRev
            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev([2, 7, 11, 15], 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev([4, 5], 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRev([3, 2, 4], 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev([3, 3], 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRev([1, 8, 10, 2], 10))}]");

            // CountingWordsRev
            Console.WriteLine($"Should be 1. Result: {CountingWordsRev(" One ")}");
            Console.WriteLine($"Should be 1. Result: {CountingWordsRev("One ")}");
            Console.WriteLine($"Should be 2. Result: {CountingWordsRev(" Hello World ")}");
            Console.WriteLine($"Should be 6. Result: {CountingWordsRev(" I went for a walk today ")}");

            // Counting Vowels
            Console.WriteLine($"Hello vowels are: {CountingVowels("Hello")}");
            Console.WriteLine($"Cyberpunk vowels are: {CountingVowels("Cyberpunk")}");
            Console.WriteLine($"APPLE vowels are: {CountingVowels("APPLE")}");
            Console.WriteLine($" \"\" vowels are: {CountingVowels("")}");
            Console.WriteLine($" Why vowels are: {CountingVowels("why")}");

            //Palindrome: 
            Console.WriteLine($"RaceCar outcome for Palindrome: {IsPalindrome("RaceCar")}");

            //// Counting Digits:
            Console.WriteLine($"Count Digits From string should be 3 => Answer: {CountDigitsFromString("abc123")}");

            // ReverseString:
            Console.WriteLine($"Reverse String => olleh Answer: {ReverseString("Hello")}");

            // Find the Largest number: 
            Console.WriteLine($"Largest number => [100, 1, 99 ] Answer: {LargestNumber([100, 1, 99])}");

            // Sum of Even Numbers
            Console.WriteLine($"Sum of Even Numbers  => [1, 2, 3, 4, 5] Answer = 6: {SumEvenNumbers([1, 2, 3, 4,])}");

            // CountSpaces
            Console.WriteLine($"Should be 7. Result: {CountingSpaces("       ")}");
            Console.WriteLine($"Should be 3. Result: {CountingSpaces(" Hello World ")}");
            Console.WriteLine($"Should be 0. Result: {CountingSpaces("")}");
            Console.WriteLine($"Should be 1. Result: {CountingSpaces(" ")}");

            // Counting Capitals:
            Console.WriteLine($"Should be 1. Result: {CountingCapitalLetters(" One ")}");
            Console.WriteLine($"Should be 1. Result: {CountingCapitalLetters("One ")}");
            Console.WriteLine($"Should be 2. Result: {CountingCapitalLetters(" Hello World ")}");
            Console.WriteLine($"Should be 9. Result: {CountingCapitalLetters(" I WENT for a WALK today ")}");

            // Counting Words: 
            Console.WriteLine($"Should be 1. Result: {CountingWords(" One ")}");
            Console.WriteLine($"Should be 1. Result: {CountingWords("One ")}");
            Console.WriteLine($"Should be 2. Result: {CountingWords(" Hello World ")}");
            Console.WriteLine($"Should be 6. Result: {CountingWords(" I went for a walk today ")}");

            // Smallest Number
            Console.WriteLine($"Smallest number should be 1 => Answer: {SmallestNumber([1, 5, 3, 9, 2])}");
            Console.WriteLine($"Smallest number should be -10 => Answer: {SmallestNumber([-5, -2, -10])}");
            Console.WriteLine($"Smallest number should be 100 => Answer: {SmallestNumber([100])}");
            Console.WriteLine($"Smallest number should be 4 => Answer: {SmallestNumber([4, 4, 4])}");
            Console.WriteLine($"Smallest number should be -100 => Answer: {SmallestNumber([50, 20, -100, 3])}");
            Console.WriteLine($"Smallest number should be 0 => Answer: {SmallestNumber([])}");
            Console.WriteLine($"Smallest number should be 0 => Answer: {SmallestNumber(null)}");

            // Counting Vowels and Consonants
            Console.WriteLine($"hello should be vowels: 2, consonants: 3 => Answer: {CountVowelsAndConsonants("hello")}");
            Console.WriteLine($"APPLE should be vowels: 2, consonants: 3 => Answer: {CountVowelsAndConsonants("APPLE")}");
            Console.WriteLine($"Cyberpunk 2077 should be vowels: 2, consonants: 7 => Answer: {CountVowelsAndConsonants("Cyberpunk 2077")}");
            Console.WriteLine($"Empty string should be vowels: 0, consonants: 0 => Answer: {CountVowelsAndConsonants("")}");
            Console.WriteLine($"Null should be vowels: 0, consonants: 0 => Answer: {CountVowelsAndConsonants(null!)}");
            Console.WriteLine($"Why should be vowels: 0, consonants: 3 => Answer: {CountVowelsAndConsonants("Why")}");

            // Counting Character Occurrences
            Console.WriteLine(CharacterOccurrences("hello", 'l'));
            Console.WriteLine(CharacterOccurrences("Cyberpunk", 'y'));
            Console.WriteLine(CharacterOccurrences("APPLE", 'p'));
            Console.WriteLine(CharacterOccurrences("aaaa", 'a'));
            Console.WriteLine(CharacterOccurrences("", 'a'));
            Console.WriteLine(CharacterOccurrences("null", 'a'));

            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSum([2, 7, 11, 15], 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSum([4, 5], 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSum([3, 2, 4], 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSum([3, 3], 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSum([1, 8, 10, 2], 10))}]");

            // IsArray Ascending - Return True if the array is sorted From Smallest to Largest: 
            Console.WriteLine(IsSortedArrayAscending([1, 2, 3, 4]));
            Console.WriteLine(IsSortedArrayAscending([1, 1, 2, 3]));
            Console.WriteLine(IsSortedArrayAscending([1, 3, 2, 4]));
            Console.WriteLine(IsSortedArrayAscending([5, 4, 3, 2]));
            Console.WriteLine(IsSortedArrayAscending([10]));
            Console.WriteLine(IsSortedArrayAscending([]));
            Console.WriteLine(IsSortedArrayAscending([2, 2, 2, 2]));
            Console.WriteLine(IsSortedArrayAscending(null!));

            // Find Second Largest Number
            Console.WriteLine(FindTheSecondLargestNumber([1, 2, 4, 5]));
            Console.WriteLine(FindTheSecondLargestNumber([1, 3, 4, 5]));
            Console.WriteLine(FindTheSecondLargestNumber([2, 3, 4, 5]));
            Console.WriteLine(FindTheSecondLargestNumber([1, 2, 3, 4]));
            Console.WriteLine(FindTheSecondLargestNumber([]));
            Console.WriteLine(FindTheSecondLargestNumber(null!));

            // Find Missing Number: 
            Console.WriteLine(FindMissingNumber([1, 2, 4, 5]));
            Console.WriteLine(FindMissingNumber([1, 3, 4, 5]));
            Console.WriteLine(FindMissingNumber([2, 3, 4, 5]));
            Console.WriteLine(FindMissingNumber([1, 2, 3, 4]));
            Console.WriteLine(FindMissingNumber([]));
            Console.WriteLine(FindMissingNumber(null!));

            // Sum Positive Numbers 
            Console.WriteLine(SumPositiveNumbers([1, 2, 4]));
            Console.WriteLine(SumPositiveNumbers([0, 0, 0, 5]));
            Console.WriteLine(SumPositiveNumbers([-1, -2, -3, 5]));
            Console.WriteLine(SumPositiveNumbers([1]));
            Console.WriteLine(SumPositiveNumbers([]));
            Console.WriteLine(SumPositiveNumbers(null!));

            // Find Second Largest number:             
            Console.WriteLine(CountSecondLargestNumberRev([-1, 6, 3, 9, 2]));
            Console.WriteLine(CountSecondLargestNumberRev([10, 20, 30,]));
            Console.WriteLine(CountSecondLargestNumberRev([30, 20, 10]));
            Console.WriteLine(CountSecondLargestNumberRev([0 - 5, -2, -1, -10]));
            Console.WriteLine(CountSecondLargestNumberRev([]));
            Console.WriteLine(CountSecondLargestNumberRev(null!));

            // Merged Arrays: 
            Console.WriteLine(string.Join(",", MergeArraysRev([1, 2, 3], [4, 5, 6])));
            Console.WriteLine(string.Join(",", MergeArraysRev([], [1, 2])));
            Console.WriteLine(string.Join(",", MergeArraysRev([7, 8], [])));
            Console.WriteLine(string.Join(",", MergeArraysRev([-1, -2], [0, 1])));
            Console.WriteLine(string.Join(",", MergeArraysRev([], [])));

            // Find index of Target:  
            Console.WriteLine(FindIndexOfTarget(null!, 5));
            Console.WriteLine(FindIndexOfTarget([], 5));
            Console.WriteLine(FindIndexOfTarget([1, 2, 3], 2));
            Console.WriteLine(FindIndexOfTarget([1, 2, 3], 4));
            Console.WriteLine(FindIndexOfTarget([5, 5, 5], 5));
            Console.WriteLine(FindIndexOfTarget([9], 9));
            Console.WriteLine(FindIndexOfTarget([9], 1));

            // Count Numbers In Range
            Console.WriteLine(CountNumbersInRange(Array.Empty<int>(), 1, 5));
            Console.WriteLine(CountNumbersInRange([1, 5, 10, 15], 5, 10));
            Console.WriteLine(CountNumbersInRange([3, 6, 9], 1, 5));
            Console.WriteLine(CountNumbersInRange([2, 4, 6, 8], 4, 8));
            Console.WriteLine(CountNumbersInRange([10, 20, 30], 5, 9));
            Console.WriteLine(CountNumbersInRange([5, 5, 5], 5, 5));
            Console.WriteLine(CountNumbersInRange([-5, 0, 5], -5, 0));

            // Filter Numbers Between Range
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange(null!, 1, 5)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([], 1, 5)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([1, 5, 10, 15], 5, 10)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([3, 6, 9], 1, 5)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([2, 4, 6, 8], 4, 8)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([10, 20, 30], 1, 5)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([5, 5, 5], 5, 5)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([-5, 0, 5], -5, 0)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([1, 2, 3, 4, 5], 2, 4)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([7], 7, 7)));
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([7], 1, 5)));
        }
    }
}