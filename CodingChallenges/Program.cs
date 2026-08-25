public class Program
{
    public static int CountOddNumbersAtOddIndexes(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int outerIndex = 1; outerIndex <= numbers.Length - 1; outerIndex += 2)
        {
            if (numbers[outerIndex] % 2 != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidAssetCodes(string input)
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
            strTrimmed.StartsWith("AST-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int FindLongestSameNumberStreakRev(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int highestStreakSoFar = 1;
        int streakCounter = 1;

        for (int outerIndex = 1; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] == numbers[outerIndex - 1])
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

    public static int? FindFirstNumberBiggerThanBothNeighbours(int[] numbers)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return null;
        }

        for (int outerIndex = 1; outerIndex < numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] > numbers[outerIndex - 1] &&
            numbers[outerIndex] > numbers[outerIndex + 1])
            {
                return numbers[outerIndex];
            }
        }

        return null;
    }

    public static int CountWordsLongerThanPrevious(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;

        string [] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for(int outerIndex = 1; outerIndex <= splitString.Length -1; outerIndex++)
        {
            string strTrimmed = splitString[outerIndex];

            if(strTrimmed.Length > splitString[outerIndex -1].Length)
            {
                counter++;
            }
        }

        return counter;

    }

    public static void Main(string[] args)
    {
        // Count Words Longer Than Previous
        Console.WriteLine(CountWordsLongerThanPrevious("hi there paul") == 1);
        Console.WriteLine(CountWordsLongerThanPrevious("one two three four") == 1);
        Console.WriteLine(CountWordsLongerThanPrevious("aaaa bb c") == 0);
        Console.WriteLine(CountWordsLongerThanPrevious("") == 0);
        Console.WriteLine(CountWordsLongerThanPrevious(null!) == 0);

        // Find First Number Bigger Than Both Neighbours
        // Console.WriteLine(FindFirstNumberBiggerThanBothNeighbours([1, 5, 2, 8, 3]) == 5);
        // Console.WriteLine(FindFirstNumberBiggerThanBothNeighbours([1, 2, 3, 4]) == null);
        // Console.WriteLine(FindFirstNumberBiggerThanBothNeighbours([10, 20, 15]) == 20);
        // Console.WriteLine(FindFirstNumberBiggerThanBothNeighbours([5, 4, 3]) == null);
        // Console.WriteLine(FindFirstNumberBiggerThanBothNeighbours([1, 2]) == null);
        // Console.WriteLine(FindFirstNumberBiggerThanBothNeighbours(null!) == null);

        // Find Longest Same Number Streak Rev
        // Console.WriteLine(FindLongestSameNumberStreakRev([1, 1, 2, 2, 2, 3]) == 3);
        // Console.WriteLine(FindLongestSameNumberStreakRev([5, 5, 5, 5]) == 4);
        // Console.WriteLine(FindLongestSameNumberStreakRev([1, 2, 3, 4]) == 1);
        // Console.WriteLine(FindLongestSameNumberStreakRev([7]) == 1);
        // Console.WriteLine(FindLongestSameNumberStreakRev([1, 1, 2, 1, 1, 1]) == 3);
        // Console.WriteLine(FindLongestSameNumberStreakRev(null!) == 0);
        // Console.WriteLine(FindLongestSameNumberStreakRev([]) == 0);

        // Count Valid Asset Codes
        // Console.WriteLine(CountValidAssetCodes("AST-1234, AST-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidAssetCodes("ast-0001, AST-12A4, AST-12345") == 1);
        // Console.WriteLine(CountValidAssetCodes("hello, AST-7777") == 1);
        // Console.WriteLine(CountValidAssetCodes("") == 0);
        // Console.WriteLine(CountValidAssetCodes(" ") == 0);
        // Console.WriteLine(CountValidAssetCodes(null!) == 0);

        // Count Odd Numbers At Odd Indexes
        // Console.WriteLine(CountOddNumbersAtOddIndexes([10, 3, 8, 7, 6]) == 2);
        // Console.WriteLine(CountOddNumbersAtOddIndexes([1, 2, 3, 4]) == 0);
        // Console.WriteLine(CountOddNumbersAtOddIndexes([5, 9, 2, 11]) == 2);
        // Console.WriteLine(CountOddNumbersAtOddIndexes(null!) == 0);
        // Console.WriteLine(CountOddNumbersAtOddIndexes([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
