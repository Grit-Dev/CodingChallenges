using System.Text;

public class Program
{
    public static int CountNumbersWithinDistanceOfZero(int[] numbers, int distance)
    {
        if (numbers is null || numbers.Length == 0 ||
        distance < 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (Math.Abs(digit) <= distance)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string ReplaceEverySecondCharacterWithStar(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();
        strBuilder.Append(input);

        // Spaces Count As Characters
        for (int outerIndex = 1; outerIndex <= input.Length - 1; outerIndex += 2)
        {
            strBuilder[outerIndex] = '*';
        }

        return strBuilder.ToString();

    }

    public static int? FindFirstRunningTotalOverLimit(int[] numbers, int limit)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int total = 0;

        foreach (int digit in numbers)
        {
            total += digit;

            if (total > limit)
            {
                return total;
            }
        }

        return null;
    }

    public static string[] GetHighPriorityTickets(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();
            if (strTrimmed.Length == 9 &&
            strTrimmed.StartsWith("HIGH-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(5), out _))
            {
                newList.Add(strTrimmed);
            }
        }

        return newList.ToArray();
    }
    public static Dictionary<string, int> CountWordFrequencyWithTryGetValue(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<string, int> newDict = [];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if (newDict.TryGetValue(strTrimmed, out int value))
            {
                newDict[strTrimmed] = value + 1;
            }
            else
            {
                newDict[strTrimmed] = 1;
            }
        }

        return newDict;

    }

    public static int[] SquareNumbersWithLinq(int[] numbers) =>
        numbers?.Select(n => n * n).ToArray() ?? [];

    public static string FindFirstWordWithMoreConsonantsThanVowels(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        List<char> newListVowels = ['a', 'e', 'i', 'o', 'u'];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            int countVowels = 0;
            int countNonVowels = 0;

            string strLowered = str.ToLower();

            foreach (char character in strLowered)
            {
                if (newListVowels.Contains(character))
                {
                    countVowels++;
                }
                else if(char.IsLetter(character))
                {
                    countNonVowels++;
                }
            }

            if(countNonVowels > countVowels)
            {
                return str;
            }
        }

        return "";
    }

    public static void Main(string[] args)
    {
        // Find First Word With More Consonants Than Vowels
        Console.WriteLine(FindFirstWordWithMoreConsonantsThanVowels("area sky code") == "sky");
        Console.WriteLine(FindFirstWordWithMoreConsonantsThanVowels("audio queue") == "");
        Console.WriteLine(FindFirstWordWithMoreConsonantsThanVowels("test apple") == "test");
        Console.WriteLine(FindFirstWordWithMoreConsonantsThanVowels("") == "");
        Console.WriteLine(FindFirstWordWithMoreConsonantsThanVowels(null!) == "");
        Console.WriteLine(FindFirstWordWithMoreConsonantsThanVowels("a!!! test!") == "test!");

        // Square Number With Linq
        // int[] squaredOne = SquareNumbersWithLinq([1, 2, 3]);

        // Console.WriteLine(squaredOne.Length == 3);
        // Console.WriteLine(squaredOne[0] == 1);
        // Console.WriteLine(squaredOne[1] == 4);
        // Console.WriteLine(squaredOne[2] == 9);

        // int[] squaredTwo = SquareNumbersWithLinq([-2, 0, 5]);

        // Console.WriteLine(squaredTwo.Length == 3);
        // Console.WriteLine(squaredTwo[0] == 4);
        // Console.WriteLine(squaredTwo[1] == 0);
        // Console.WriteLine(squaredTwo[2] == 25);

        // Console.WriteLine(SquareNumbersWithLinq(null!).Length == 0);
        // Console.WriteLine(SquareNumbersWithLinq([]).Length == 0);

        // Count Word Frequency Using TryGetValue
        // Dictionary<string, int> wordsOne = CountWordFrequencyWithTryGetValue("apple banana apple");
        // Console.WriteLine(wordsOne["apple"] == 2);
        // Console.WriteLine(wordsOne["banana"] == 1);

        // Dictionary<string, int> wordsTwo = CountWordFrequencyWithTryGetValue("Hello hello HELLO");
        // Console.WriteLine(wordsTwo["hello"] == 3);

        // Dictionary<string, int> wordsThree = CountWordFrequencyWithTryGetValue("");
        // Console.WriteLine(wordsThree.Count == 0);

        // Get High Priority Tickets
        // string[] ticketsOne = GetHighPriorityTickets("HIGH-1234, LOW-9999, High-5678");

        // Console.WriteLine(ticketsOne.Length == 2);
        // Console.WriteLine(ticketsOne[0] == "HIGH-1234");
        // Console.WriteLine(ticketsOne[1] == "High-5678");

        // string[] ticketsTwo = GetHighPriorityTickets("BAD-1234, high-0001, HIGH-12A4");

        // Console.WriteLine(ticketsTwo.Length == 1);
        // Console.WriteLine(ticketsTwo[0] == "high-0001");
        // Console.WriteLine(GetHighPriorityTickets("").Length == 0);
        // Console.WriteLine(GetHighPriorityTickets(" ").Length == 0);
        // Console.WriteLine(GetHighPriorityTickets(null!).Length == 0);

        // Find First Running Total Over Limit
        // Console.WriteLine(FindFirstRunningTotalOverLimit([2, 4, 5, 1], 10) == 11);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([1, 2, 3], 10) == null);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([10, 1], 10) == 11);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([-5, 20], 10) == 15);
        // Console.WriteLine(FindFirstRunningTotalOverLimit(null!, 10) == null);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([], 10) == null);

        // Replace Every Second Character With Star 
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("abcdef") == "a*c*e*");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("hello") == "h*l*o");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("Paul") == "P*u*");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("a") == "a");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("") == "");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar(" ") == "");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar(null!) == "");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("ab cd") == "a* *d");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("hello world") == "h*l*o*w*r*d");

        // Warm Up: Count Numbers Within Distance Of Zero
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([-3, -1, 0, 2, 5], 2) == 3);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([-10, 4, 6], 5) == 1);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([1, -1, 2, -2], 1) == 2);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero(null!, 2) == 0);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([], 2) == 0);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([1, 2, 3], -1) == 0);


        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
