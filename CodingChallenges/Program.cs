public class Program
{
    public static int CountPositiveMultiplesOfThree(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit > 0 && digit % 3 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static int CountValidTicketCodes(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split([','], StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Length == 8 &&
            strTrimmed.StartsWith("TCK-", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(strTrimmed.Substring(3), out int value))
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static int FindLongestSameNumberStreakRev(int [] numbers)
    {
        if(numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 1;
        int longestStreakSoFar = 1;
        int previousNumber = numbers[0];

        for(int outterIndex = 1; outterIndex <= numbers.Length -1; outterIndex++)
        {
            if(numbers[outterIndex] == previousNumber)
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if(counter > longestStreakSoFar)
            {
                longestStreakSoFar = counter;
            }

            previousNumber = numbers[outterIndex];
        }

        return longestStreakSoFar;
    }
    public static void Main(string[] args)
    {
        // Find Longest Same-Number Streak
        Console.WriteLine(FindLongestSameNumberStreakRev([1, 1, 2, 2, 2, 3]) == 3);
        Console.WriteLine(FindLongestSameNumberStreakRev([5, 5, 5, 5]) == 4);
        Console.WriteLine(FindLongestSameNumberStreakRev([1, 2, 3, 4]) == 1);
        Console.WriteLine(FindLongestSameNumberStreakRev([7]) == 1);
        Console.WriteLine(FindLongestSameNumberStreakRev([1, 1, 2, 1, 1, 1]) == 3);
        Console.WriteLine(FindLongestSameNumberStreakRev(null!) == 0);
        Console.WriteLine(FindLongestSameNumberStreakRev([]) == 0);

        // Count Valid Ticket Codes
        // Console.WriteLine(CountValidTicketCodes("TCK-1234, TCK-9999, BAD-1234") == 2);
        // Console.WriteLine(CountValidTicketCodes("tck-1111, TCK-12A4, TCK-12345") == 1);
        // Console.WriteLine(CountValidTicketCodes("hello, TCK-0001") == 1);
        // Console.WriteLine(CountValidTicketCodes("") == 0);
        // Console.WriteLine(CountValidTicketCodes("  ") == 0);
        // Console.WriteLine(CountValidTicketCodes(null!) == 0);

        // Count Positive Multiples of 3
        // Console.WriteLine(CountPositiveMultiplesOfThree([3, 6, -3, 10, 12]) == 3);
        // Console.WriteLine(CountPositiveMultiplesOfThree([1, 2, 4, 5]) == 0);
        // Console.WriteLine(CountPositiveMultiplesOfThree([0, 3, 9]) == 2);
        // Console.WriteLine(CountPositiveMultiplesOfThree(null!) == 0);
        // Console.WriteLine(CountPositiveMultiplesOfThree([]) == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
