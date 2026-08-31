public class Program
{
    public static int CountNegativeEvenNumbersWarmUp(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < 0 && digit % 2 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidPromoCodes(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("PRO-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int FindLongestBelowLimitStreak(int[] numbers, int limit)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int streakCounter = 0;
        int highestStreakSoFar = 0;

        foreach (int digit in numbers)
        {
            if (digit < limit)
            {
                streakCounter++;
            }
            else
            {
                streakCounter = 0;
            }

            if (streakCounter > highestStreakSoFar)
            {
                highestStreakSoFar = streakCounter;
            }
        }

        return highestStreakSoFar;
    }

    public static string FindShortestWordLongerThanThree(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        string bestSoFar = "";

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            if (word.Length > 3 &&
            (bestSoFar == "" || word.Length < bestSoFar.Length))
            {
                bestSoFar = word;
            }
        }

        return bestSoFar;
    }

    public static string FindMostFrequentStatus(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        Dictionary<string, int> newDict = [];
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if (newDict.ContainsKey(strTrimmed))
            {
                newDict[strTrimmed]++;
            }
            else
            {
                newDict[strTrimmed] = 1;
            }
        }

        return newDict.MaxBy(nd => nd.Value).Key;
    }

    public static string FindFirstWordContainingDigit(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            foreach(char character in str)
            {
                if(char.IsDigit(character))
                {
                    return str;
                }
            }
        }

        return "";
    }
    public static void Main(string[] args)
    {
        // Find First Word Containing Digit:
        Console.WriteLine(FindFirstWordContainingDigit("hello test abc123 code") == "abc123");
        Console.WriteLine(FindFirstWordContainingDigit("room7 is ready") == "room7");
        Console.WriteLine(FindFirstWordContainingDigit("hello world") == "");
        Console.WriteLine(FindFirstWordContainingDigit("") == "");
        Console.WriteLine(FindFirstWordContainingDigit(null!) == "");

        // Find most Frequent Status:
        // Console.WriteLine(FindMostFrequentStatus("Open, Closed, Open, Pending") == "open");
        // Console.WriteLine(FindMostFrequentStatus("High, Low, high, Medium, high") == "high");
        // Console.WriteLine(FindMostFrequentStatus("Red, Blue, Red, Blue") == "red");
        // Console.WriteLine(FindMostFrequentStatus("") == "");
        // Console.WriteLine(FindMostFrequentStatus("  ") == "");
        // Console.WriteLine(FindMostFrequentStatus(null!) == "");

        // Find Shortest Word Longer Than Three
        // Console.WriteLine(FindShortestWordLongerThanThree("cat banana dog pear") == "pear");
        // Console.WriteLine(FindShortestWordLongerThanThree("one two six") == "");
        // Console.WriteLine(FindShortestWordLongerThanThree("coding test practice") == "test");
        // Console.WriteLine(FindShortestWordLongerThanThree("alpha beta code") == "beta");
        // Console.WriteLine(FindShortestWordLongerThanThree("") == "");
        // Console.WriteLine(FindShortestWordLongerThanThree(null!) == "");

        // Find Longest Below Limit Streak: 
        // Console.WriteLine(FindLongestBelowLimitStreak([3, 4, 10, 2, 1, 8], 5) == 2);
        // Console.WriteLine(FindLongestBelowLimitStreak([10, 11, 12], 5) == 0);
        // Console.WriteLine(FindLongestBelowLimitStreak([1, 2, 3], 5) == 3);
        // Console.WriteLine(FindLongestBelowLimitStreak([5, 4, 5, 3], 5) == 1);
        // Console.WriteLine(FindLongestBelowLimitStreak(null!, 5) == 0);
        // Console.WriteLine(FindLongestBelowLimitStreak([], 5) == 0);

        // Count Valid Promo Codes: 
        // Console.WriteLine(CountValidPromoCodes("PRO-1234, PRO-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidPromoCodes("pro-0001, PRO-12A4, PRO-12345") == 1);
        // Console.WriteLine(CountValidPromoCodes("hello, PRO-7777") == 1);
        // Console.WriteLine(CountValidPromoCodes("") == 0);
        // Console.WriteLine(CountValidPromoCodes("   ") == 0);
        // Console.WriteLine(CountValidPromoCodes(null!) == 0);

        // Warm Up: Count Negative Numbers
        // Console.WriteLine(CountNegativeEvenNumbersWarmUp([-2, -4, 5, 8, -7]) == 2);
        // Console.WriteLine(CountNegativeEvenNumbersWarmUp([-1, -3, -5]) == 0);
        // Console.WriteLine(CountNegativeEvenNumbersWarmUp([-10, 0, -12]) == 2);
        // Console.WriteLine(CountNegativeEvenNumbersWarmUp(null!) == 0);
        // Console.WriteLine(CountNegativeEvenNumbersWarmUp([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
