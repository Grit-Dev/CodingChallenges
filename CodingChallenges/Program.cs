using System.Text;

public class Program
{
    public static int CountOddNumbersRevisionOne(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int value in pInputValue)
        {
            if (value % 2 != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int MostFrequentNumberRevisionOne(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int mostFrequentNumber = 0;
        int highestCounter = 0;

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            int value = pInputValue[counter];
            int countFrequency = 0;

            for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
            {
                if (value == pInputValue[counterTwo])
                {
                    countFrequency++;
                }
            }

            if (countFrequency > highestCounter)
            {
                highestCounter = countFrequency;
                mostFrequentNumber = value;
            }
        }

        return mostFrequentNumber;
    }

    public static int[] RemoveLastOccurrenceRevisionOne(int[] pInputValue, int? pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        if (!pTarget.HasValue)
        {
            return [];
        }

        List<int> newList = [];
        bool isTrue = false;

        if (pInputValue.Length == 1)
        {
            if (pTarget == pInputValue[0])
            {
                return [];
            }
            else
            {
                newList.Add(pInputValue[0]);
                return newList.ToArray();
            }
        }

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            if (pTarget == pInputValue[counter] && isTrue == false)
            {
                newList.Add(pInputValue[counter]);
                isTrue = true;
            }
            else if (pTarget != pInputValue[counter])
            {
                newList.Add(pInputValue[counter]);
            }
        }

        return newList.ToArray();
    }

    public static void CountVowelsAndConsonantsRevisionOne(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            Console.WriteLine("Input cannot be null or empty                                                                                                                                                                                                          ");
        }

        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        char[] consonants =
        [
            'b','c','d','f','g','h','j','k','l','m',
                'n','p','q','r','s','t','v','w','x','y','z'
        ];
        int vowelsCounter = 0;
        int consonantsCounter = 0;

        pInputValue = pInputValue.ToLower();

        foreach (char counter in pInputValue)
        {
            if (vowels.Contains(counter))
            {
                vowelsCounter++;
            }
            else if (consonants.Contains(counter))
            {
                consonantsCounter++;
            }
        }

        Console.WriteLine("vowels: " + vowelsCounter);
        Console.WriteLine("Other" + consonantsCounter);
    }

    public static string RemoveSpaces(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        string newWord = "";

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                newWord = newWord + character;
            }
        }

        return newWord;
    }

    public static string ReverseString(string pInputeValue)
    {
        if (string.IsNullOrEmpty(pInputeValue))
        {
            return "";
        }

        StringBuilder reversedString = new();

        for (int counter = pInputeValue.Length - 1; counter >= 0; counter--)
        {
            reversedString.Append(pInputeValue[counter]);
        }

        return reversedString.ToString();
    }

    public static string ReverseWords(string pInputeValue)
    {
        if (string.IsNullOrEmpty(pInputeValue))
        {
            return "";
        }

        StringBuilder reversedString = new();
        var split = pInputeValue.Split(' ');

        for (int counter = split.Length - 1; counter >= 0; counter--)
        {
            reversedString.Append(split[counter]);

            if (counter > 0)
            {
                reversedString.Append(' ');
            }
        }

        return reversedString.ToString();
    }


    public static void Main(string[] args)
    {

        // Count Odd Numbers 
        // Console.WriteLine(CountOddNumbersRevisionOne([1, 2, 3, 4, 5])); // 3
        // Console.WriteLine(CountOddNumbersRevisionOne([2, 4, 6, 8]));    // 0
        // Console.WriteLine(CountOddNumbersRevisionOne([1, 3, 5, 7]));    // 4
        // Console.WriteLine(CountOddNumbersRevisionOne([]));               // 0

        // Most Frequent Number Revision

        // Console.WriteLine(MostFrequentNumberRevisionOne([1, 2, 2, 3, 2])); // 2
        // Console.WriteLine(MostFrequentNumberRevisionOne([5, 5, 1, 1, 5])); // 5
        // Console.WriteLine(MostFrequentNumberRevisionOne([9]));             // 9
        // Console.WriteLine(MostFrequentNumberRevisionOne([7, 7, 7, 7]));   // 7

        // Remove last occurrence - [1,5,10, 5] Target 5 => [1,5, 10] 
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 1, 5, 10, 5 }, 5))); // 1,5,10
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 5, 1, 5, 5 }, 5)));  // 5,1,5
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 5 }, 5)));           // (empty)


        // Count Vowels and Consants
        // CountVowelsAndConsonantsRevisionOne("hello");      // Vowels: 2, Consonants: 3
        // CountVowelsAndConsonantsRevisionOne("AEIOU");      // Vowels: 5, Consonants: 0
        // CountVowelsAndConsonantsRevisionOne("bcdfg");      // Vowels: 0, Consonants: 5
        // CountVowelsAndConsonantsRevisionOne("Hello World"); // Vowels: 3, Consonants: 7


        // Remove spaces From String 
        // Console.WriteLine(RemoveSpaces("Hello World"));          // HelloWorld
        // Console.WriteLine(RemoveSpaces(" C# Is Fun "));          // C#IsFun
        // Console.WriteLine(RemoveSpaces("NoSpaces"));             // NoSpaces
        // Console.WriteLine(RemoveSpaces("   "));                  // (empty)

        // Reverse Words in string
        // Console.WriteLine(ReverseString("Hello World"));                 // World Hello
        // Console.WriteLine(ReverseString("C# Is Awesome"));               // Awesome Is C#
        // Console.WriteLine(ReverseString("One Two Three Four"));          // Four Three Two One
        // Console.WriteLine(ReverseString("Single"));                      // Single

        // // Reverse Words in Sentence
        // Console.WriteLine(ReverseWords("Hello World"));                 // World Hello
        // Console.WriteLine(ReverseWords("C# Is Awesome"));               // Awesome Is C#
        // Console.WriteLine(ReverseWords("One Two Three Four"));          // Four Three Two One
        // Console.WriteLine(ReverseWords("Single"));                      // Single


        /*
            NEXT CHALLENGES

            ```
            1. Count Positive Numbers

            * Return how many numbers are greater than zero.
            * Positive means value > 0.
            * Example: [1, -2, 3, 0, 5] -> 3
            * Example: [-1, -2] -> 0
            * Return 0 for null or empty.

            2. Find Most Frequent Number - Bug Found in my last try so I need to do this again

            * Return the number that appears the most.
            * Use two separate variables:
                - mostFrequentNumber = the actual number
                - highestCount = how many times the best number appeared
            * Example: [1, 2, 2, 3, 2] -> 2
            * Example: [5, 5, 1, 1] -> 5
            * Example: [10, 10, 9, 9, 9] -> 9
            * If there is a tie, return the number that appears first.
            * Return 0 for null or empty.

            3. Find Second Largest Distinct Number

            * Return the second largest different number.
            * Distinct means the value must be different.
            * Example: [10, 10, 5, 3] -> 5
            * Example: [1, 5, 3, 9, 2] -> 5
            * Example: [10, 10] -> -1
            * Example: [5, 5, 5] -> -1
            * Return -1 if there is no second distinct number.
            * Return -1 for null or empty.

            4. Find First Even Number

            * Return the first even number in the array.
            * Even means value % 2 == 0.
            * Example: [1, 3, 4, 6] -> 4
            * Example: [2, 4, 6] -> 2
            * Example: [1, 3, 5] -> 0
            * Example: [-3, -2, 1] -> -2
            * Return 0 for null or empty.

            5. Find Last Even Number

            * Return the last even number in the array.
            * Even means value % 2 == 0.
            * Example: [1, 3, 4, 6] -> 6
            * Example: [2, 4, 6] -> 6
            * Example: [1, 3, 5] -> 0
            * Example: [-3, -2, 1] -> -2
            * Loop backwards from the end.
            * Return 0 for null or empty.

            6. Optional Stretch: Move Even Numbers To Front

            * Return a new array with even numbers first, then odd numbers.
            * Keep the original order inside each group.
            * Example: [1, 2, 3, 4, 5] -> [2, 4, 1, 3, 5]
            * Example: [2, 4, 6] -> [2, 4, 6]
            * Example: [1, 3, 5] -> [1, 3, 5]
            * Example: [-2, -3, -4, 1] -> [-2, -4, -3, 1]
            * First pass: add evens.
            * Second pass: add odds.
            * Return [] for null or empty.
            ```

            */

    }
}
