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
    public static void Main(string[] args)
    {
        // Count Valid Promo Codes: 
        Console.WriteLine(CountValidPromoCodes("PRO-1234, PRO-9999, BAD-1234") == 2);
        Console.WriteLine(CountValidPromoCodes("pro-0001, PRO-12A4, PRO-12345") == 1);
        Console.WriteLine(CountValidPromoCodes("hello, PRO-7777") == 1);
        Console.WriteLine(CountValidPromoCodes("") == 0);
        Console.WriteLine(CountValidPromoCodes("   ") == 0);
        Console.WriteLine(CountValidPromoCodes(null!) == 0);

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
