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
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string [] splitStrings = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitStrings)
        {
            string strTrimmed = str.Trim();

            if(strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("INV-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(4), out _))
            {
                counter++;
            }
        }

        return counter;
    }

    public static void Main(string[] args)
    {
        // Count Valid Invoice Codes
        Console.WriteLine(CountValidInvoiceCodes("INV-1234, INV-9999, BAD-1234") == 2);
        Console.WriteLine(CountValidInvoiceCodes("inv-0001, INV-12A4, INV-12345") == 1);
        Console.WriteLine(CountValidInvoiceCodes("hello, INV-7777") == 1);
        Console.WriteLine(CountValidInvoiceCodes("") == 0);
        Console.WriteLine(CountValidInvoiceCodes(" ") == 0);
        Console.WriteLine(CountValidInvoiceCodes(null!) == 0);

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
