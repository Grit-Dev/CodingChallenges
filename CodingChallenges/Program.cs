using System.Text;

public class Program
{
    public static int CountWordsStartingAndEndingWithSameLetter(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;
        string[] stringSpilit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSpilit)
        {
            string wordlowered = word.ToLower();

            if (wordlowered[0] == wordlowered[^1])
            {
                counter++;
            }
        }

        return counter;
    }

    public static string TitleCaseExceptSmallWords(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        pInputValue = pInputValue.ToLower();
        string[] spilitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder newStringFormed = new();
        List<string> newListSmallWords = ["and", "or", "the", "of", "in"];
        bool isFirstIndex = false;

        foreach (string word in spilitString)
        {
            string currentWord = word.ToLower();

            if (word == spilitString[0] && !isFirstIndex)
            {
                newStringFormed.Append(char.ToUpper(currentWord[0]) + currentWord.Substring(1) + ' ');
                isFirstIndex = true;
            }
            else if (newListSmallWords.Contains(currentWord))
            {
                newStringFormed.Append(currentWord + ' ');
            }
            else
            {
                newStringFormed.Append(char.ToUpper(currentWord[0]) + currentWord.Substring(1) + ' ');
            }
        }

        return newStringFormed.ToString().Trim();
    }

    public static bool AreAnagrams_One(string pInputValue, string pTargetValue)
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

    public static bool IsSentencePalindrome_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return false;
        }

        StringBuilder newFormedString = new();
        pInputValue = pInputValue.ToLower();

        foreach (char character in pInputValue)
        {
            if (char.IsLetter(character))
            {
                newFormedString.Append(character);
            }
        }

        int left = 0;
        int right = newFormedString.Length - 1;

        while (left < right)
        {
            if (newFormedString[left] != newFormedString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public static string GetWordLengthSummary_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newStringFormed = new();
        string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSplit)
        {
            newStringFormed.Append(word + ':' + word.Length + ' ');
        }

        return newStringFormed.ToString().Trim();
    }

    public static string RemoveDuplicateWordsPreserveOrder_One(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newStringFormed = new();
        List<string> newListOfString = [];
        string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSplit)
        {
            string wordIsLowered = word.ToLower();

            if (!newListOfString.Contains(wordIsLowered))
            {
                newStringFormed.Append(word + ' ');
                newListOfString.Add(wordIsLowered);
            }
        }

        return newStringFormed.ToString().Trim();
    }
    public static void Main(string[] args)
    {
        // Remove Duplicate Words Preserve Order
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello world hello"));                         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Cyberpunk card vault card"));        // True   ===> "Cyberpunk card vault"
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Apple apple APPLE banana") == "Apple banana");                 // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("one two three two one") == "one two three");                   // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Seagate factory IT factory") == "Seagate factory IT");         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("A a B b C c"));                                     // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello") == "hello");                                           // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("") == "");                                                     // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One(null!) == "");                                                   // True


        // Count Words Starting And Ending With Same Letter
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("level test radar code") == 3);        // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("Anna went to area") == 2);           // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("bob cat civic dog") == 2);           // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("apple banana orange") == 0);         // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("A b cc deed") == 4);                 // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("Test toast tent") == 3);             // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter("") == 0);                            // True
        // Console.WriteLine(CountWordsStartingAndEndingWithSameLetter(null!) == 0);                          // True

        // Revision: Title Case Except Small Words
        // Console.WriteLine(TitleCaseExceptSmallWords("the lord of the rings") == "The Lord of the Rings");                 // True
        // Console.WriteLine(TitleCaseExceptSmallWords("THE LORD OF THE RINGS") == "The Lord of the Rings");                 // True
        // Console.WriteLine(TitleCaseExceptSmallWords("cyberpunk and the card vault") == "Cyberpunk and the Card Vault");   // True
        // Console.WriteLine(TitleCaseExceptSmallWords("war of the worlds") == "War of the Worlds");                         // True
        // Console.WriteLine(TitleCaseExceptSmallWords("in the line of fire") == "In the Line of Fire");                     // True
        // Console.WriteLine(TitleCaseExceptSmallWords("hello OR goodbye") == "Hello or Goodbye");                           // True
        // Console.WriteLine(TitleCaseExceptSmallWords("a tale in the city") == "A Tale in the City");                       // True
        // Console.WriteLine(TitleCaseExceptSmallWords("") == "");                                                           // True
        // Console.WriteLine(TitleCaseExceptSmallWords(null!) == "");                                                         // True

        // Revision: Are Anagrams
        // Console.WriteLine(AreAnagrams_One("listen", "silent") == true);       // True
        // Console.WriteLine(AreAnagrams_One("aab", "aba") == true);             // True
        // Console.WriteLine(AreAnagrams_One("aab", "ab") == false);             // True
        // Console.WriteLine(AreAnagrams_One("", "") == true);                   // True
        // Console.WriteLine(AreAnagrams_One("Triangle", "Integral") == true);   // True
        // Console.WriteLine(AreAnagrams_One("Apple", "Pabble") == false);       // True
        // Console.WriteLine(AreAnagrams_One("abc", "abcd") == false);           // True
        // Console.WriteLine(AreAnagrams_One(null!, "abc") == false);             // True
        // Console.WriteLine(AreAnagrams_One("abc", null!) == false);             // True
        // Console.WriteLine(AreAnagrams_One(null!, null!) == false);              // True

        // New Challenge: Is Sentence Palindrome
        // Console.WriteLine(IsSentencePalindrome_One("never odd or even") == true);      // True
        // Console.WriteLine(IsSentencePalindrome_One("hello world") == false);           // True
        // Console.WriteLine(IsSentencePalindrome_One("nurses run") == true);             // True
        // Console.WriteLine(IsSentencePalindrome_One("Race car") == true);               // True
        // Console.WriteLine(IsSentencePalindrome_One("Was it a rat I saw") == true);     // True
        // Console.WriteLine(IsSentencePalindrome_One("step on no pets") == true);        // True
        // Console.WriteLine(IsSentencePalindrome_One("this is not one") == false);       // True
        // Console.WriteLine(IsSentencePalindrome_One("") == false);                      // True
        // Console.WriteLine(IsSentencePalindrome_One(null!) == false);                    // True

        // 5. New Challenge: Get Word Length Summary
        // Console.WriteLine(GetWordLengthSummary_One("Cyberpunk card vault") == "Cyberpunk:9 card:4 vault:5");   // True
        // Console.WriteLine(GetWordLengthSummary_One("I am Paul") == "I:1 am:2 Paul:4");                         // True
        // Console.WriteLine(GetWordLengthSummary_One("hello world") == "hello:5 world:5");                       // True
        // Console.WriteLine(GetWordLengthSummary_One("A bb ccc dddd") == "A:1 bb:2 ccc:3 dddd:4");               // True
        // Console.WriteLine(GetWordLengthSummary_One("Seagate Factory IT") == "Seagate:7 Factory:7 IT:2");       // True
        // Console.WriteLine(GetWordLengthSummary_One("One") == "One:3");                                        // True
        // Console.WriteLine(GetWordLengthSummary_One("") == "");                                                 // True
        // Console.WriteLine(GetWordLengthSummary_One(null!) == "");                                               // True

        // Remove Duplicate Words Preserve Order
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello world hello"));                         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Cyberpunk card vault card"));        // True   ===> "Cyberpunk card vault"
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Apple apple APPLE banana") == "Apple banana");                 // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("one two three two one") == "one two three");                   // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("Seagate factory IT factory") == "Seagate factory IT");         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("A a B b C c"));                                     // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("hello") == "hello");                                           // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One("") == "");                                                     // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_One(null!) == "");                                                   // True
    }
}
