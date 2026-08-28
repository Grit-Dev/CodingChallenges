public class Program
{
    public static int CountPositiveNumbersWarmUp(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit > 0 && digit % 2 != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidBatchCodes(string input)
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
            strTrimmed.StartsWith("BAT-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int FindLongestAboveLimitStreak(int[] numbers, int limit)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int highestStreakSoFar = 0;
        int streakCounter = 0;

        foreach (int digit in numbers)
        {
            if (digit > limit)
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

    public static int? FindFirstNumberSmallerThanBothNeighbours(int[] numbers)
    {
        if(numbers is null || numbers.Length < 3)
        {
            return null;
        }

        for(int outerIndex = 1; outerIndex < numbers.Length -1; outerIndex++)
        {
            if(numbers[outerIndex] < numbers[outerIndex -1] &&
            numbers[outerIndex] < numbers[outerIndex +1])
            {
                return numbers[outerIndex];
            }
        }

        return null;
    }

    public static void Main(string[] args)
    {
        // Find First Number Smaller Than Both Neighbours
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours([9, 4, 8, 3, 7]) == 4);
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours([1, 2, 3, 4]) == null);
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours([10, 5, 20]) == 5);
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours([5, 4, 3]) == null);
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours([1, 2]) == null);
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours(null!) == null);
        Console.WriteLine(FindFirstNumberSmallerThanBothNeighbours([]) == null);

        // Find Longest Above Limit Streak
        // Console.WriteLine(FindLongestAboveLimitStreak([5, 12, 15, 3, 20, 25, 30], 10) == 3);
        // Console.WriteLine(FindLongestAboveLimitStreak([1, 2, 3], 10) == 0);
        // Console.WriteLine(FindLongestAboveLimitStreak([11, 12, 13], 10) == 3);
        // Console.WriteLine(FindLongestAboveLimitStreak([10, 11, 10, 12], 10) == 1);
        // Console.WriteLine(FindLongestAboveLimitStreak(null!, 10) == 0);
        // Console.WriteLine(FindLongestAboveLimitStreak([], 10) == 0);

        // Count Valid Batch Codes
        // Console.WriteLine(CountValidBatchCodes("BAT-1234, BAT-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidBatchCodes("bat-0001, BAT-12A4, BAT-12345") == 1);
        // Console.WriteLine(CountValidBatchCodes("hello, BAT-7777") == 1);
        // Console.WriteLine(CountValidBatchCodes("") == 0);
        // Console.WriteLine(CountValidBatchCodes(" ") == 0);
        // Console.WriteLine(CountValidBatchCodes(null!) == 0);

        // Warm up: Count Positive Odd Numbers
        // Console.WriteLine(CountPositiveNumbersWarmUp([1, 2, 3, -5, 7]) == 3);
        // Console.WriteLine(CountPositiveNumbersWarmUp([-1, -3, 2, 4]) == 0);
        // Console.WriteLine(CountPositiveNumbersWarmUp([9, 11, 12]) == 2);
        // Console.WriteLine(CountPositiveNumbersWarmUp(null!) == 0);
        // Console.WriteLine(CountPositiveNumbersWarmUp([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
