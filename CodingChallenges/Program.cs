public class Program
{
    public static int CountNumbersBetweenTenAndTwenty(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int count = 0;

        foreach (int digit in numbers)
        {
            if (digit >= 10 && digit <= 20)
            {
                count++;
            }
        }

        return count;
    }

    public static int CountValidRoomCodes(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int count = 0;

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length == 6)
            {
                if (strTrimmed.StartsWith("RM-", StringComparison.OrdinalIgnoreCase))
                {
                    string digits = strTrimmed.Substring(3);

                    if (int.TryParse(digits, out _))
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    public static void Main(string[] args)
    {
        // Count Valid Room Codes
        Console.WriteLine(CountValidRoomCodes("RM-101, RM-202, BAD-999") == 2);
        Console.WriteLine(CountValidRoomCodes("rm-001, RM-ABC, RM-1234") == 1);
        Console.WriteLine(CountValidRoomCodes("hello, RM-777") == 1);
        Console.WriteLine(CountValidRoomCodes("") == 0);
        Console.WriteLine(CountValidRoomCodes("  ") == 0);
        Console.WriteLine(CountValidRoomCodes(null!) == 0);

        // Count Numbers Between 10 and 20
        // Console.WriteLine(CountNumbersBetweenTenAndTwenty([5, 10, 15, 20, 25]) == 3);
        // Console.WriteLine(CountNumbersBetweenTenAndTwenty([1, 2, 3]) == 0);
        // Console.WriteLine(CountNumbersBetweenTenAndTwenty([10, 20, 30]) == 2);
        // Console.WriteLine(CountNumbersBetweenTenAndTwenty(null!) == 0);
        // Console.WriteLine(CountNumbersBetweenTenAndTwenty([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
