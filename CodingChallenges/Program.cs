using Microsoft.VisualBasic;
using System.Text;

public class Program
{
    private static string RemoveVowels(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        var newStringInput = new StringBuilder();
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        pInputValue = pInputValue.ToLower();


        foreach (char character in pInputValue)
        {
            if (!vowels.Contains(character))
            {
                newStringInput.Append(character);
            }
        }

        return newStringInput.ToString();
    }

    private static string CountVowelsAndConsonants(string pInputvalue)
    {
        if (string.IsNullOrEmpty(pInputvalue))
        {
            return "Vowels: 0, Consonants: 0";

        }

        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        char[] consonants =
        [
            'b', 'c', 'd', 'f', 'g',
                'h', 'j', 'k', 'l', 'm',
                'n', 'p', 'q', 'r', 's',
                't', 'v', 'w', 'x', 'y',
                'z'
        ];

        pInputvalue = pInputvalue.ToLower();

        int vowelsCounter = 0;
        int consonantsCounter = 0;

        foreach (char character in pInputvalue)
        {
            if (vowels.Contains(character))
            {
                vowelsCounter++;
            }
            else if (consonants.Contains(character))
            {
                consonantsCounter++;
            }
        }

        return $"Vowels: {vowelsCounter}, Consonants: {consonantsCounter}";

    }

    public static int CountLowerCaseLetters(string pInputVale)
    {
        if (string.IsNullOrEmpty(pInputVale))
        {
            return 0;
        }

        int counter = 0;

        foreach (char character in pInputVale)
        {
            if (char.IsLower(character))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountWords(string pInputVale)
    {
        if (string.IsNullOrEmpty(pInputVale))
        {
            return 0;
        }

        bool isInsideWord = false;
        int counter = 0;

        foreach (char character in pInputVale)
        {
            if (!char.IsWhiteSpace(character))
            {
                if (isInsideWord == false)
                {
                    counter++;
                    isInsideWord = true;

                }
            }
            else
            {
                isInsideWord = false;
            }
        }

        return counter;
    }

    public static int FindLongestWordLength(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int longestLengthTotal = 0;
        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                counter++;
            }
            else
            {
                if (counter > longestLengthTotal)
                {
                    longestLengthTotal = counter;
                }

                counter = 0;
            }
        }

        if (counter > longestLengthTotal)
        {
            longestLengthTotal = counter;
        }

        return longestLengthTotal;
    }

    public static bool IsPalindromeIgnoringSpaces(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return false;
        }

        StringBuilder newString = new StringBuilder();

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                newString.Append(character);
            }
        }

        int left = 0;
        int right = newString.Length - 1;

        while (left <= right)
        {
            if (newString[left] != newString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public static int FindLongestWordLengthAnotherGo(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int longestStringCounter = 0;
        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                counter++;
            }
            else
            {
                if (counter > longestStringCounter)
                {
                    longestStringCounter = counter;
                }
            }
        }

        if (counter > longestStringCounter)
        {
            longestStringCounter = counter;
        }

        return longestStringCounter;
    }

    public static void Main(string[] args)
    {

    /*        Minimum:
                1.Remove Vowels Preserve Casing
                2.Is Palindrome Ignoring Spaces And Case
                3.Count Vowels and Consonants revision

                Good:
                        4.Count Specific Character
                5.Remove Specific Character

            Stretch:
                6.First Non - Repeating Character revision
    */

        // Find the longest word
        // - Return the length of the longest word in a string 
        // - Example: Cyberpunk card vault => 9 for Cyberpunk
        Console.WriteLine(FindLongestWordLength("Cyberpunk card vault") == 9); // 9
        Console.WriteLine(FindLongestWordLength("dog cat mouse") == 5); // 5
        Console.WriteLine(FindLongestWordLength("hello") == 5); // 5
        Console.WriteLine(FindLongestWordLength("") == 0); // 0
        Console.WriteLine(FindLongestWordLength("a ab abc abcd") == 4); //4

        // Is Palindrome ignoring spaces
        // - Return true if the string is a palinfrome while ignoring spaces
        // -- racecar  = true || race car == True
        // --- hello ==> false 
        // ---- Return false for null or empty 
        // Console.WriteLine(IsPalindromeIgnoringSpaces("racecar") == true);
        // Console.WriteLine(IsPalindromeIgnoringSpaces("race car") == true);
        // Console.WriteLine(IsPalindromeIgnoringSpaces("never odd or even") == true);
        // Console.WriteLine(IsPalindromeIgnoringSpaces("hello") == false);
        // Console.WriteLine(IsPalindromeIgnoringSpaces("") == false);
        // Console.WriteLine(IsPalindromeIgnoringSpaces(null) == false);


        // Count Lower Case Letters
        // Console.WriteLine(CountLowerCaseLetters("hello") == 5);
        // Console.WriteLine(CountLowerCaseLetters("Hello World") == 8);
        // Console.WriteLine(CountLowerCaseLetters("ABC") == 0);
        // Console.WriteLine(CountLowerCaseLetters("aBc123!") == 2);
        // Console.WriteLine(CountLowerCaseLetters("") == 0);


        // Count Words Revision
        // - Return how many words are in the a string 
        // - isInsider Word
        // Console.WriteLine(CountWords("Hello World") == 2);
        // Console.WriteLine(CountWords("One Two Three Four") == 4);
        // Console.WriteLine(CountWords("Cyberpunk") == 1);
        // Console.WriteLine(CountWords("") == 0);
        // Console.WriteLine(CountWords("   ") == 0);
        // Console.WriteLine(CountWords("  Hello   World  ") == 2);

        // COunt Vowels and Consonants 
        // -Return a string showing vowels and consonants 
        // Console.WriteLine(CountVowelsAndConsonants("hello") == "Vowels: 2, Consonants: 3");
        // Console.WriteLine(CountVowelsAndConsonants("aeiou") == "Vowels: 5, Consonants: 0");
        // Console.WriteLine(CountVowelsAndConsonants("bcdfg") == "Vowels: 0, Consonants: 5");
        // Console.WriteLine(CountVowelsAndConsonants("A1B2C3") == "Vowels: 1, Consonants: 2");
        // Console.WriteLine(CountVowelsAndConsonants("") == "Vowels: 0, Consonants: 0");


        // Remove vowels From a string
        //- return a string with all vowels removed
        // Console.WriteLine(RemoveVowels("hello") == "hll");
        // Console.WriteLine(RemoveVowels("AEIOU") == "");
        // Console.WriteLine(RemoveVowels("Cyberpunk") == "cybrpnk");
        // Console.WriteLine(RemoveVowels("Programming") == "prgrmmng");
        // Console.WriteLine(RemoveVowels("") == "");
     
    }
}
