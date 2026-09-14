using System.Text;

public class Program
{
    public static int CountAdjacentIncreases(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            if (numbers[index] > numbers[index - 1])
            {
                counter++;
            }
        }

        return counter;
    }

    public static string CreateSlugFromTitle(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();

        input = input.ToLower();

        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            if (strBuilder.Length > 0)
            {
                strBuilder.Append('-');
            }

            strBuilder.Append(str);
        }

        return strBuilder.ToString();
    }

    public static int[] GetTwoNumberTotalsAboveLimit(int[] numbers, int limit)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return [];
        }

        List<int> totalPairCounter = [];

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            int total = numbers[index] + numbers[index + 1];

            if (total > limit)
            {
                totalPairCounter.Add(total);
            }
        }

        return totalPairCounter.ToArray();
    }

    public static int? FindFirstValidScore(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        string[] stringSplit = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            string strTrimmed = str.Trim();

            if (int.TryParse(strTrimmed, out int value) &&
            value >= 0 && value <= 100)
            {
                return value;
            }
        }

        return null;
    }

    public static Dictionary<int, List<string>> GroupWordsByLength(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<int, List<string>> newDict = [];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strTrimmed = str.Trim();

            if(newDict.TryGetValue(strTrimmed.Length, out List<string>? value))
            {
                value.Add(strTrimmed);
            }
            else
            {
                newDict[strTrimmed.Length] = [strTrimmed];
            }
        }

        return newDict;
    }

    public static void Main(string[] args)
    {
        // Group Words By Length
        Dictionary<int, List<string>> groupsOne = GroupWordsByLength("cat dog apple");
        Console.WriteLine(groupsOne[3].Count == 2);
        Console.WriteLine(groupsOne[3][0] == "cat");
        Console.WriteLine(groupsOne[3][1] == "dog");
        Console.WriteLine(groupsOne[5].Count == 1);
        Console.WriteLine(groupsOne[5][0] == "apple");

        Dictionary<int, List<string>> groupsTwo = GroupWordsByLength("hi to code test");
        Console.WriteLine(groupsTwo[2].Count == 2);
        Console.WriteLine(groupsTwo[2][0] == "hi");
        Console.WriteLine(groupsTwo[2][1] == "to");
        Console.WriteLine(groupsTwo[4].Count == 2);
        Console.WriteLine(groupsTwo[4][0] == "code");
        Console.WriteLine(groupsTwo[4][1] == "test");

        Dictionary<int, List<string>> groupsThree = GroupWordsByLength(null!);
        Console.WriteLine(groupsThree.Count == 0);

        // Find First Valid Score
        // Console.WriteLine(FindFirstValidScore("bad, -1, 75, 90") == 75);
        // Console.WriteLine(FindFirstValidScore("abc, 200, -5") == null);
        // Console.WriteLine(FindFirstValidScore("100, 50") == 100);
        // Console.WriteLine(FindFirstValidScore("0, 10") == 0);
        // Console.WriteLine(FindFirstValidScore("") == null);
        // Console.WriteLine(FindFirstValidScore(" ") == null);
        // Console.WriteLine(FindFirstValidScore(null!) == null);

        // Get Tow Number Total Above Limit
        // int[] totalsOne = GetTwoNumberTotalsAboveLimit([2, 5, 10, 1], 10);
        // Console.WriteLine(totalsOne.Length == 2);
        // Console.WriteLine(totalsOne[0] == 15);
        // Console.WriteLine(totalsOne[1] == 11);

        // int[] totalsTwo = GetTwoNumberTotalsAboveLimit([1, 2, 3], 10);
        // Console.WriteLine(totalsTwo.Length == 0);

        // int[] totalsThree = GetTwoNumberTotalsAboveLimit([-5, 20, -2, 15], 10);
        // Console.WriteLine(totalsThree.Length == 3);
        // Console.WriteLine(totalsThree[0] == 15);
        // Console.WriteLine(totalsThree[1] == 18);
        // Console.WriteLine(totalsThree[2] == 13);
        // Console.WriteLine(GetTwoNumberTotalsAboveLimit(null!, 10).Length == 0);
        // Console.WriteLine(GetTwoNumberTotalsAboveLimit([], 10).Length == 0);

        // Create Slug From Title
        // Console.WriteLine(CreateSlugFromTitle("Hello World") == "hello-world");
        // Console.WriteLine(CreateSlugFromTitle(" Paul Codes Daily ") == "paul-codes-daily");
        // Console.WriteLine(CreateSlugFromTitle("CSharp Practice") == "csharp-practice");
        // Console.WriteLine(CreateSlugFromTitle("One") == "one");
        // Console.WriteLine(CreateSlugFromTitle("") == "");
        // Console.WriteLine(CreateSlugFromTitle(" ") == "");
        // Console.WriteLine(CreateSlugFromTitle(null!) == "");

        // Warm up: Count Adjacent Increases. 
        // Console.WriteLine(CountAdjacentIncreases([1, 3, 2, 5]) == 2);
        // Console.WriteLine(CountAdjacentIncreases([5, 4, 3]) == 0);
        // Console.WriteLine(CountAdjacentIncreases([1, 2, 3, 4]) == 3);
        // Console.WriteLine(CountAdjacentIncreases([7]) == 0);
        // Console.WriteLine(CountAdjacentIncreases(null!) == 0);
        // Console.WriteLine(CountAdjacentIncreases([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
