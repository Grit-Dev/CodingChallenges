using System;

namespace CodingChallenges.Challenges
{
    public class ChallengeSolutionsRunner : ChallengeSolutions
    {
        public void RunAllChallengeSolutions()
        {

            // PMG TO DO Code clean up ============================================================================
            // PMG TO DO Code clean up ============================================================================
            // PMG TO DO Code clean up ============================================================================


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
            Console.WriteLine(IsPangram(null!));                                         // False
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


            // PMG TO DO Code clean up ============================================================================
            // PMG TO DO Code clean up ============================================================================
            // PMG TO DO Code clean up ============================================================================



            // 1.Count Characters Except Spaces
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

            // 1. Count even numbers (Sum)
            Console.WriteLine(SumEvenNumbersRev([1, 2, 3, 4, 5, 6]));
            Console.WriteLine(SumEvenNumbersRev([2, 4, 6, 8]));
            Console.WriteLine(SumEvenNumbersRev([1, 3, 5]));
            Console.WriteLine(SumEvenNumbersRev([]));

            //  2. Replace target with value 
            Console.WriteLine(string.Join(",", ReplaceTarget([1, 5, 10, 5], 5, 99)));
            Console.WriteLine(string.Join(",", ReplaceTarget([5, 5, 5], 5, 0)));
            Console.WriteLine(string.Join(",", ReplaceTarget([1, 2, 3], 9, 100)));

            // 3. Split positive and negative numbers: 
            Console.WriteLine(string.Join(",", SplitPosNeg([1, -2, 3, -4, 0])));
            Console.WriteLine(string.Join(",", SplitPosNeg([-1, -2, -3])));
            Console.WriteLine(string.Join(",", SplitPosNeg([1, 2, 3])));
            Console.WriteLine(string.Join(",", SplitPosNeg([0, 0, 0])));

            // 4. Count Matching Numbers
            Console.WriteLine(CountMatching([1, 2, 2, 3, 2], 2));
            Console.WriteLine(CountMatching([5, 5, 5, 5], 5));
            Console.WriteLine(CountMatching([1, 2, 3], 9));

            // 5. Remove Target  From array
            Console.WriteLine(string.Join(",", RemoveTarget([1, 2, 3, 2, 4], 2)));
            Console.WriteLine(string.Join(",", RemoveTarget([5, 5, 5], 5)));
            Console.WriteLine(string.Join(",", RemoveTarget([1, 2, 3], 9)));

            // 6. Move Target to the end 
            Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3, 2, 4], 2)));
            Console.WriteLine(string.Join(",", MoveTargetToEnd([5, 1, 5, 2], 5)));
            Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3], 9)));

            // New Challenge: Replace Target With Value
            Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 99 should return [1, 99, 5, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 0, 5, 0], 0, 99))}]");
            Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 0 should return [1, 0, 5, 0] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 0, 5, 0], 0, 0))}]");
            Console.WriteLine($"[1, 5, 10, 5], target 5, replacement 99 should return [1, 99, 10, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 5, 10, 5], 5, 99))}]");
            Console.WriteLine($"[3, 4, 5], target 9, replacement 0 should return [3, 4, 5] => Answer: [{string.Join(", ", ReplaceTargetWithValue([3, 4, 5], 9, 0))}]");
            Console.WriteLine($"[7], target 7, replacement 1 should return [1] => Answer: [{string.Join(", ", ReplaceTargetWithValue([7], 7, 1))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue([], 5, 99))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue(null!, 5, 99))}]");

            //  Split Positive And Negative Numbers
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

            //// Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacterRev("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacterRev("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacterRev("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacterRev("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacterRev("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacterRev(null!)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacterRev("Cyberpunk")}");

            //// Count Negative Numbers: 
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

            //CountSpaces
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

            Console.WriteLine(CountNumbersInRange(Array.Empty<int>(), 1, 5));
            Console.WriteLine(CountNumbersInRange([1, 5, 10, 15], 5, 10));
            Console.WriteLine(CountNumbersInRange([3, 6, 9], 1, 5));
            Console.WriteLine(CountNumbersInRange([2, 4, 6, 8], 4, 8));
            Console.WriteLine(CountNumbersInRange([10, 20, 30], 5, 9));
            Console.WriteLine(CountNumbersInRange([5, 5, 5], 5, 5));
            Console.WriteLine(CountNumbersInRange([-5, 0, 5], -5, 0));

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