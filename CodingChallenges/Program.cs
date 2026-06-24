using System.Text;

public class Program
{
    private static string CountVowelsAndConsonants(string pInputvalue)
    {
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        char[] consonants =
        [
            'b', 'c', 'd', 'f', 'g',
                'h', 'j', 'k', 'l', 'm',
                'n', 'p', 'q', 'r', 's',
                't', 'v', 'w', 'x', 'y',
                'z'
        ];

        if (string.IsNullOrEmpty(pInputvalue))
        {
            return "Value was empty";
        }

        int vowelsCounter = 0;
        int consantsCounter = 0;

        pInputvalue = pInputvalue.ToLower();

        foreach (char character in pInputvalue)
        {
            if (vowels.Contains(character))
            {
                vowelsCounter++;
            }
            else if (consonants.Contains(character))
            {
                consantsCounter++;
            }
        }

        return $"Total Vowels: {vowelsCounter} || Total Consonants: {consantsCounter}";

    }

    public static int[] RemoveLastOccurrenceRevision(int[] pInputValue, int pTarget)
    {

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        List<int> newList = [];
        int lastIndex = -1;

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            if (pInputValue[counter] == pTarget)
            {
                lastIndex = counter;
            }
        }

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            if (counter != lastIndex)
            {
                newList.Add(pInputValue[counter]);
            }
        }

        return newList.ToArray();
    }

    public static string CountUpperCaseLetters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "String is empty";
        }

        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsUpper(character))
            {
                counter++;
            }
        }

        return $"Total upper case letters for {pInputValue} is: {counter}";
    }

    public static string CapitaliseFirstLetter(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "String is empty";
        }

        char capitalLetter = char.ToUpper(pInputValue[0]);
        string newString = capitalLetter + pInputValue.Substring(1);

        return newString;
    }

    public static int CountWords(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return -1;
        }

        bool isInsideWord = true;
        int wordCount = 0;

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                if (isInsideWord == true)
                {
                    wordCount++;
                    isInsideWord = false;
                }
            }
            else
            {
                isInsideWord = true;
            }
        }

        return wordCount;
    }

    public static string CapitaliseEachWord(string pInputVale)
    {
        if (string.IsNullOrEmpty(pInputVale))
        {
            return "String is empty";
        }

        var split = pInputVale.Split(" ");
        StringBuilder newString = new();

        foreach (string character in split)
        {
            char characterHolder = character[0];
            characterHolder = char.ToUpper(characterHolder);

            newString.Append(characterHolder).Append(character.Substring(1));
            newString.Append(' ');
        }

        return newString.ToString().Trim();
    }

    public static void Main(string[] args)
    {
        // Capitalise Each Word == "Hello World" -- String
        Console.WriteLine(CapitaliseEachWord("hello world"));               // Hello World
        Console.WriteLine(CapitaliseEachWord("c# is awesome"));             // C# Is Awesome
        Console.WriteLine(CapitaliseEachWord("one two three four"));        // One Two Three Four
        Console.WriteLine(CapitaliseEachWord("hello"));                     // Hello
        Console.WriteLine(CapitaliseEachWord(""));                          // (empty)
                                                                            // Console.WriteLine(CountUpperCaseLetters("123!@#"));     // 0
                                                                            // Console.WriteLine(CountWords("   "));                   // edge case
                                                                            // Console.WriteLine(CapitaliseFirstLetter("a"));          // A
                                                                            // Console.WriteLine(CapitaliseEachWord("a b c"));         // A B C
                                                                            // Console.WriteLine(CountVowelsAndConsonants("WHY"));     // Vowels: 0, Consonants: 3


        // Capitalise First Letter === Return the same string but with the first character uppercase
        // Console.WriteLine(CapitaliseFirstLetter("hello"));          // Hello
        // Console.WriteLine(CapitaliseFirstLetter("world"));          // World
        // Console.WriteLine(CapitaliseFirstLetter("hello world"));    // Hello world
        // Console.WriteLine(CapitaliseFirstLetter("Hello"));          // Hello
        // Console.WriteLine(CapitaliseFirstLetter(""));               // (empty)






        // Count UpperCase Letters -- string - return string 
        // Console.WriteLine(CountUpperCaseLetters("Hello World"));     // 2
        // Console.WriteLine(CountUpperCaseLetters("HELLO"));           // 5
        // Console.WriteLine(CountUpperCaseLetters("hello"));           // 0
        // Console.WriteLine(CountUpperCaseLetters("HeLLo WoRLD"));     // 7
        // Console.WriteLine(CountUpperCaseLetters(""));                // 0


        // Count Words, -- IsInsider word? String 
        // Console.WriteLine(CountWords("Hello World"));                    // 2
        // Console.WriteLine(CountWords("One Two Three Four"));             // 4
        // Console.WriteLine(CountWords("Single"));                         // 1
        // Console.WriteLine(CountWords(""));                               // 0
        // Console.WriteLine(CountWords("C# is fun"));                      // 3

        // Remove last Occurrence Revision --  array with target - [1, 5, 10, 5] - target 5 = [1,5,10]
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([1, 5, 10, 5], 5))); // 1,5,10
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([5, 1, 5, 5], 5)));  // 5,1,5
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([1, 2, 3], 9)));     // 1,2,3
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([5], 5)));           // (empty)
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([5, 5, 5], 5)));     // 5,5



        // Count Vowels and Consonants Revision  -- Case Insenseitivity - Treay y as a consant
        // Console.WriteLine(CountVowelsAndConsonants("Hello"));       // Vowels: 2, Consonants: 3
        // Console.WriteLine(CountVowelsAndConsonants("AEIOU"));       // Vowels: 5, Consonants: 0
        // Console.WriteLine(CountVowelsAndConsonants("xyz"));         // Vowels: 0, Consonants: 3
        // Console.WriteLine(CountVowelsAndConsonants("Seagate"));     // Vowels: 4, Consonants: 3
        // Console.WriteLine(CountVowelsAndConsonants(""));            // Vowels: 0, Consonants: 0



    }
}
