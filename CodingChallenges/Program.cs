using System.Text;

public class Program
{
    public static int CountNumbersWithinDistanceOfZero(int[] numbers, int distance)
    {
        if (numbers is null || numbers.Length == 0 ||
        distance < 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (Math.Abs(digit) <= distance)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string ReplaceEverySecondCharacterWithStar(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();
        strBuilder.Append(input);

        // Spaces Count As Characters
        for (int outerIndex = 1; outerIndex <= input.Length - 1; outerIndex += 2)
        {
            strBuilder[outerIndex] = '*';
        }

        return strBuilder.ToString();

    }

    public static int? FindFirstRunningTotalOverLimit(int[] numbers, int limit)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int total = 0;

        foreach (int digit in numbers)
        {
            total += digit;

            if (total > limit)
            {
                return total;
            }
        }

        return null;
    }

    public static string[] GetHighPriorityTickets(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();
            if (strTrimmed.Length == 9 &&
            strTrimmed.StartsWith("HIGH-", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(strTrimmed.Substring(5), out _))
            {
                newList.Add(strTrimmed);
            }
        }

        return newList.ToArray();
    }
    public static void Main(string[] args)
    {
        // Get Valid Email Email Address
        string[] ticketsOne = GetHighPriorityTickets("HIGH-1234, LOW-9999, High-5678");

        Console.WriteLine(ticketsOne.Length == 2);
        Console.WriteLine(ticketsOne[0] == "HIGH-1234");
        Console.WriteLine(ticketsOne[1] == "High-5678");

        string[] ticketsTwo = GetHighPriorityTickets("BAD-1234, high-0001, HIGH-12A4");

        Console.WriteLine(ticketsTwo.Length == 1);
        Console.WriteLine(ticketsTwo[0] == "high-0001");
        Console.WriteLine(GetHighPriorityTickets("").Length == 0);
        Console.WriteLine(GetHighPriorityTickets(" ").Length == 0);
        Console.WriteLine(GetHighPriorityTickets(null!).Length == 0);

        // Find First Running Total Over Limit
        // Console.WriteLine(FindFirstRunningTotalOverLimit([2, 4, 5, 1], 10) == 11);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([1, 2, 3], 10) == null);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([10, 1], 10) == 11);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([-5, 20], 10) == 15);
        // Console.WriteLine(FindFirstRunningTotalOverLimit(null!, 10) == null);
        // Console.WriteLine(FindFirstRunningTotalOverLimit([], 10) == null);

        // Replace Every Second Character With Star 
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("abcdef") == "a*c*e*");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("hello") == "h*l*o");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("Paul") == "P*u*");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("a") == "a");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("") == "");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar(" ") == "");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar(null!) == "");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("ab cd") == "a* *d");
        // Console.WriteLine(ReplaceEverySecondCharacterWithStar("hello world") == "h*l*o*w*r*d");

        // Warm Up: Count Numbers Within Distance Of Zero
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([-3, -1, 0, 2, 5], 2) == 3);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([-10, 4, 6], 5) == 1);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([1, -1, 2, -2], 1) == 2);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero(null!, 2) == 0);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([], 2) == 0);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([1, 2, 3], -1) == 0);


        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
