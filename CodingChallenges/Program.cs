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
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0; 
        }

        int counter = 0;
        string [] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strTrimmed = str.Trim();

            if(strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("BAT-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static void Main(string[] args)
    {
        // Count Valid Batch Codes
        Console.WriteLine(CountValidBatchCodes("BAT-1234, BAT-9999, BAD-1234") == 2);
        Console.WriteLine(CountValidBatchCodes("bat-0001, BAT-12A4, BAT-12345") == 1);
        Console.WriteLine(CountValidBatchCodes("hello, BAT-7777") == 1);
        Console.WriteLine(CountValidBatchCodes("") == 0);
        Console.WriteLine(CountValidBatchCodes(" ") == 0);
        Console.WriteLine(CountValidBatchCodes(null!) == 0);

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
