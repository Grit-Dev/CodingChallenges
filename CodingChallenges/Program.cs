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
        string [] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strTrimmed = str.Trim();

            if(strTrimmed.Length == 8 && 
            strTrimmed.StartsWith("AST-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static void Main(string[] args)
    {
        // Count Valid Asset Codes
        Console.WriteLine(CountValidAssetCodes("AST-1234, AST-9999, BAD-1234") == 2);
        Console.WriteLine(CountValidAssetCodes("ast-0001, AST-12A4, AST-12345") == 1);
        Console.WriteLine(CountValidAssetCodes("hello, AST-7777") == 1);
        Console.WriteLine(CountValidAssetCodes("") == 0);
        Console.WriteLine(CountValidAssetCodes(" ") == 0);
        Console.WriteLine(CountValidAssetCodes(null!) == 0);

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
