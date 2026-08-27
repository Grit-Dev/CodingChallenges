public class Program
{
    public static int CountNegativeMultiplesOfThreeWarmUp(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < 0 && digit % 3 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountValidCaseCodes(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string [] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strTrimmed = str.Trim();

            if(strTrimmed.Length == 9 &&
            strTrimmed.StartsWith("CASE-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(5), out _))
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Valid Case Codes
        Console.WriteLine(CountValidCaseCodes("CASE-1234, CASE-9999, BAD-1234") == 2);
        Console.WriteLine(CountValidCaseCodes("case-0001, CASE-12A4, CASE-12345") == 1);
        Console.WriteLine(CountValidCaseCodes("hello, CASE-7777") == 1);
        Console.WriteLine(CountValidCaseCodes("") == 0);
        Console.WriteLine(CountValidCaseCodes(" ") == 0);
        Console.WriteLine(CountValidCaseCodes(null!) == 0);


        // Count Negative Multiples Of Three
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-3, -6, 3, 9, -10]) == 2);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-1, -2, -4]) == 0);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([-9, 0, -12]) == 2);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp(null!) == 0);
        Console.WriteLine(CountNegativeMultiplesOfThreeWarmUp([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
