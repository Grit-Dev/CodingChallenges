public class Program
{
    public static int CountPositiveMultiplesOfFive(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit > 0 && digit % 5 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidInvoiceCodes(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitStrings = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitStrings)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("INV-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int FindLongestConsecutiveDecreasingStreak(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int highestStreakSoFar = 1;
        int streakCounter = 1;

        for (int outerIndex = 1; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] < numbers[outerIndex - 1])
            {
                streakCounter++;
            }
            else
            {
                streakCounter = 1;
            }

            if (streakCounter > highestStreakSoFar)
            {
                highestStreakSoFar = streakCounter;
            }
        }


        return highestStreakSoFar;
    }

    public static int? FindFirstValleyNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return null;
        }

        for (int outerIndex = 1; outerIndex < numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] < numbers[outerIndex - 1] &&
            numbers[outerIndex] < numbers[outerIndex + 1])
            {
                return numbers[outerIndex];
            }
        }

        return null;
    }

    public static Dictionary<string, int> CountErrorCodeFrequency(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<string, int> newDict = [];

        input = input.ToLower();
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (newDict.ContainsKey(strTrimmed))
            {
                newDict[strTrimmed]++;
            }
            else
            {
                newDict[strTrimmed] = 1;
            }
        }

        return newDict;
    }

    public static void Main(string[] args)
    {
        // CountErrorCodeFrequency
        Dictionary<string, int> res1 = CountErrorCodeFrequency("E404, E500, E404");
        Console.WriteLine(res1["e404"] == 2);
        Console.WriteLine(res1["e500"] == 1);

        Dictionary<string, int> res2 = CountErrorCodeFrequency("E401, e401, E403");
        Console.WriteLine(res2["e401"] == 2);
        Console.WriteLine(res2["e403"] == 1);

        Dictionary<string, int> res3 = CountErrorCodeFrequency("");
        Console.WriteLine(res3.Count == 0);

        // Find First Valley Number
        // Console.WriteLine(FindFirstValleyNumber([5, 2, 6, 1, 9]) == 2);
        // Console.WriteLine(FindFirstValleyNumber([1, 2, 3, 4]) == null);
        // Console.WriteLine(FindFirstValleyNumber([10, 5, 20]) == 5);
        // Console.WriteLine(FindFirstValleyNumber([5, 4, 3]) == null);
        // Console.WriteLine(FindFirstValleyNumber([1, 2]) == null);
        // Console.WriteLine(FindFirstValleyNumber(null!) == null);
        // Console.WriteLine(FindFirstValleyNumber([]) == null);

        // Find Longest Consecutive Decreasing Streak
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak([9, 7, 5, 10, 8]) == 3);
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak([5, 4, 3, 2]) == 4);
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak([1, 2, 3, 4]) == 1);
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak([7]) == 1);
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak([10, 8, 6, 6, 5]) == 3);
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak(null!) == 0);
        // Console.WriteLine(FindLongestConsecutiveDecreasingStreak([]) == 0);

        // Count Valid Invoice Codes
        // Console.WriteLine(CountValidInvoiceCodes("INV-1234, INV-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidInvoiceCodes("inv-0001, INV-12A4, INV-12345") == 1);
        // Console.WriteLine(CountValidInvoiceCodes("hello, INV-7777") == 1);
        // Console.WriteLine(CountValidInvoiceCodes("") == 0);
        // Console.WriteLine(CountValidInvoiceCodes(" ") == 0);
        // Console.WriteLine(CountValidInvoiceCodes(null!) == 0);

        // Warm Up: Count Positive Multiples of Five
        // Console.WriteLine(CountPositiveMultiplesOfFive([5, 10, -5, 12, 25]) == 3);
        // Console.WriteLine(CountPositiveMultiplesOfFive([1, 2, 3, 4]) == 0);
        // Console.WriteLine(CountPositiveMultiplesOfFive([0, 5, 15]) == 2);
        // Console.WriteLine(CountPositiveMultiplesOfFive(null!) == 0);
        // Console.WriteLine(CountPositiveMultiplesOfFive([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
