using System.Text;

public class Program
{
    public static int CountWordsWithRepeatedLetters_Two(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;

        pInputValue = pInputValue.ToLower();
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            bool isRepeatedLetter = false;

            for (int outterIndex = 0; outterIndex < word.Length - 1; outterIndex++)
            {
                char innerChar = word[outterIndex];

                for (int innerIndex = outterIndex + 1; innerIndex <= word.Length - 1; innerIndex++)
                {
                    if (innerChar == word[innerIndex])
                    {
                        isRepeatedLetter = true;
                        break;
                    }
                }

                if (isRepeatedLetter)
                {
                    break;
                }
            }

            if (isRepeatedLetter)
            {
                counter++;
            }
        }


        return counter;
    }

    public static bool IsSentencePalindrome(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return false;
        }

        pInputValue = pInputValue.ToLower();
        StringBuilder newStringFormed = new();

        foreach (char Character in pInputValue)
        {
            if (!char.IsWhiteSpace(Character))
            {
                newStringFormed.Append(Character);
            }
        }

        int left = 0;
        int right = newStringFormed.Length - 1;

        while (left < right)
        {
            if (newStringFormed[left] != newStringFormed[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;

    }

    public static string RemoveDuplicateWordsPreserveOrder_Two(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> newListOfString = [];
        StringBuilder newStringFormed = new();

        foreach (string word in splitString)
        {
            string wordLowered = word.ToLower();

            if (!newListOfString.Contains(wordLowered))
            {
                newListOfString.Add(wordLowered);
                newStringFormed.Append(word + ' ');
            }
        }

        return newStringFormed.ToString().Trim();
    }

    public static string FindFirstRepeatedWord(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        List<string> newStringListLowered = [];
        List<string> originalStringList = [];
        string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            string wordLowered = word.ToLower();

            if (!newStringListLowered.Contains(wordLowered))
            {
                newStringListLowered.Add(wordLowered);
                originalStringList.Add(word);
            }
            else
            {
                for (int outterIndex = 0; outterIndex <= newStringListLowered.Count - 1; outterIndex++)
                {
                    if (wordLowered == newStringListLowered[outterIndex])
                    {
                        return originalStringList[outterIndex];
                    }
                }
            }
        }

        return "";
    }

    public static string FindFirstWordWithDuplicateLetters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordinSplit in stringSplit)
        {
            for (int outterIndex = 0; outterIndex <= wordinSplit.Length - 1; outterIndex++)
            {
                for (int innerIndex = outterIndex + 1; innerIndex <= wordinSplit.Length - 1; innerIndex++)
                {
                    if (wordinSplit.ToLower()[outterIndex] == wordinSplit.ToLower()[innerIndex])
                    {
                        return wordinSplit;
                    }
                }
            }
        }

        return "";
    }

    public static string FindMostFrequentCharacterInEachWord(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder newStringBuilderFormatted = new();

        string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in stringSplit)
        {
            string loweredWord = word.ToLower();

            char characterHolder = word[0];
            int highestFrequencyCounter = 0;

            for (int outterIndex = 0; outterIndex < word.Length; outterIndex++)
            {
                int counter = 0;

                for (int innerIndex = 0; innerIndex < word.Length; innerIndex++)
                {
                    if (loweredWord[outterIndex] == loweredWord[innerIndex])
                    {
                        counter++;
                    }
                }

                if (counter > highestFrequencyCounter)
                {
                    highestFrequencyCounter = counter;
                    characterHolder = word[outterIndex];
                }
            }

            newStringBuilderFormatted.Append(word);
            newStringBuilderFormatted.Append(':');
            newStringBuilderFormatted.Append(characterHolder);
            newStringBuilderFormatted.Append(' ');
        }

        return newStringBuilderFormatted.ToString().Trim();
    }
    public static void Main(string[] args)
    {
        // Optional Stretch: Find Most Frequent Character In Each Word
        Console.WriteLine(FindMostFrequentCharacterInEachWord("hello world") == "hello:l world:w");                 // True
        Console.WriteLine(FindMostFrequentCharacterInEachWord("mississippi card") == "mississippi:i card:c");       // True
        Console.WriteLine(FindMostFrequentCharacterInEachWord("apple banana") == "apple:p banana:a");               // True
        Console.WriteLine(FindMostFrequentCharacterInEachWord("cat dog sun") == "cat:c dog:d sun:s");               // True
        Console.WriteLine(FindMostFrequentCharacterInEachWord("Hello World") == "Hello:l World:W");                 // True
        Console.WriteLine(FindMostFrequentCharacterInEachWord("") == "");                                           // True                                               // True

        // Count Words With Repeated Letters
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("hello world cat") == 1);              // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("apple banana dog") == 2);             // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("cat dog sun") == 0);                  // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("book moon tree") == 3);               // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("Apple BANANA dog") == 2);             // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("abc def ghi") == 0);                  // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("mississippi card vault") == 1);        // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("aa bb cc") == 3);                     // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two("") == 0);                             // True
        // Console.WriteLine(CountWordsWithRepeatedLetters_Two(null!) == 0);                           // True

        // Revision: Is Sentence Palindrome
        // Console.WriteLine(IsSentencePalindrome("never odd or even") == true);                  // True
        // Console.WriteLine(IsSentencePalindrome("Race car") == true);                           // True
        // Console.WriteLine(IsSentencePalindrome("hello world") == false);                       // True
        // Console.WriteLine(IsSentencePalindrome("nurses run") == true);                         // True
        // Console.WriteLine(IsSentencePalindrome("Was it a rat I saw") == true);                 // True
        // Console.WriteLine(IsSentencePalindrome("step on no pets") == true);                    // True
        // Console.WriteLine(IsSentencePalindrome("madam") == true);                              // True
        // Console.WriteLine(IsSentencePalindrome("not a palindrome") == false);                  // True
        // Console.WriteLine(IsSentencePalindrome("") == false);                                  // True
        // Console.WriteLine(IsSentencePalindrome(null!) == false);                                // True

        // Revision: Remove Duplicate Words Preserve Order
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Hello world HELLO") == "Hello world");                         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Cyberpunk card vault CARD card") == "Cyberpunk card vault");   // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("hello world hello") == "hello world");                         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("one two three two one") == "one two three");                   // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Apple apple APPLE banana") == "Apple banana");                 // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("A a B b C c") == "A B C");                                     // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("Seagate factory IT factory") == "Seagate factory IT");         // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("hello") == "hello");                                           // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two("") == "");                                                     // True
        // Console.WriteLine(RemoveDuplicateWordsPreserveOrder_Two(null!) == "");                                                   // True

        // Find First Repeated Word
        // Console.WriteLine(FindFirstRepeatedWord("hello world hello") == "hello");                    // True
        // Console.WriteLine(FindFirstRepeatedWord("one two three two one") == "two");                  // True
        // Console.WriteLine(FindFirstRepeatedWord("Cyberpunk card vault CARD") == "card");             // True
        // Console.WriteLine(FindFirstRepeatedWord("Apple banana APPLE") == "Apple");                   // True
        // Console.WriteLine(FindFirstRepeatedWord("red blue green BLUE red") == "blue");               // True
        // Console.WriteLine(FindFirstRepeatedWord("cat dog bird dog") == "dog");                       // True
        // Console.WriteLine(FindFirstRepeatedWord("Seagate factory IT factory") == "factory");         // True
        // Console.WriteLine(FindFirstRepeatedWord("Same same same") == "Same");                        // True
        // Console.WriteLine(FindFirstRepeatedWord("car bike train bus") == "");                        // True
        // Console.WriteLine(FindFirstRepeatedWord("Cyberpunk card vault") == "");                      // True
        // Console.WriteLine(FindFirstRepeatedWord("") == "");                                          // True
        // Console.WriteLine(FindFirstRepeatedWord(null) == "");                                        // True

        // Find First Word With Duplicate Letters
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("cat hello world") == "hello");                // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("dog apple banana") == "apple");               // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("cat dog sun") == "");                         // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("Cyberpunk card vault") == "");       // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("one two book moon") == "book");               // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("ABC def Gg") == "Gg");                        // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("Tree apple banana") == "Tree");               // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("a bb cc") == "bb");                           // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters("") == "");                                    // True
        // Console.WriteLine(FindFirstWordWithDuplicateLetters(null!) == "");                                  // True

    }
}
