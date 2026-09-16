using System.Xml;

public class Program
{
    public static int CountNumbersDivisibleByTwoOrThreeButNotBoth(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0 && number % 3 == 0)
            {
                continue;
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string[] ExtractMentionUsernames(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];
        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            int indexOfAtSymbol = str.IndexOf('@');
            int indexOfAtSymbolCount = str.Count(i => i == '@');

            if (indexOfAtSymbolCount > 1)
            {
                continue;
            }

            if (indexOfAtSymbol > 0 || indexOfAtSymbol < 0)
            {
                continue;
            }

            if (str.Length > 1)
            {
                newList.Add(str.Substring(1));
            }
        }

        return newList.ToArray();
    }

    public static int? FindIndexOfHighestRunningTotal(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? highestRunningTotal = null;
        int total = 0;
        int? highestRunningIndex = null;

        for (int index = 0; index <= numbers.Length - 1; index++)
        {
            total += numbers[index];

            if (highestRunningTotal is null || total > highestRunningTotal)
            {
                highestRunningTotal = total;
                highestRunningIndex = index;
            }
        }

        return highestRunningTotal > 0 ? highestRunningIndex : 0;
    }
    public static void Main(string[] args)
    {
        // Find Index Of Highest Running Total
        Console.WriteLine(FindIndexOfHighestRunningTotal([3, -1, 5, -10]) == 2);
        Console.WriteLine(FindIndexOfHighestRunningTotal([5, -2, -10, 20]) == 3);
        Console.WriteLine(FindIndexOfHighestRunningTotal([-2, -3, -1]) == 0);
        Console.WriteLine(FindIndexOfHighestRunningTotal([1, 1, -5]) == 1);
        Console.WriteLine(FindIndexOfHighestRunningTotal(null!) == null);
        Console.WriteLine(FindIndexOfHighestRunningTotal([]) == null);

        // Extract Mention Usernames 
        // string[] mentionsOne = ExtractMentionUsernames("hello @Paul and @Sarah");
        // Console.WriteLine(mentionsOne.Length == 2);
        // Console.WriteLine(mentionsOne[0] == "Paul");
        // Console.WriteLine(mentionsOne[1] == "Sarah");

        // string[] mentionsTwo = ExtractMentionUsernames("@one @ @Two");
        // Console.WriteLine(mentionsTwo.Length == 2);
        // Console.WriteLine(mentionsTwo[0] == "one");
        // Console.WriteLine(mentionsTwo[1] == "Two");
        // Console.WriteLine(ExtractMentionUsernames("no mentions here").Length == 0);
        // Console.WriteLine(ExtractMentionUsernames("").Length == 0);
        // Console.WriteLine(ExtractMentionUsernames(" ").Length == 0);
        // Console.WriteLine(ExtractMentionUsernames(null!).Length == 0);

        // Warm up: Count Numbers divisible by two or three but noth Both. 
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([2, 3, 4, 6, 9, 12, 15]) == 5);
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([6, 12, 18]) == 0);
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([2, 4, 8]) == 3);
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([3, 9, 15]) == 3);
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([0, 2, 6]) == 1);
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth(null!) == 0);
        // Console.WriteLine(CountNumbersDivisibleByTwoOrThreeButNotBoth([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
