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
    public static void Main(string[] args)
    {
        // Get Tow Number Total Above Limit
        int[] totalsOne = GetTwoNumberTotalsAboveLimit([2, 5, 10, 1], 10);
        Console.WriteLine(totalsOne.Length == 2);
        Console.WriteLine(totalsOne[0] == 15);
        Console.WriteLine(totalsOne[1] == 11);

        int[] totalsTwo = GetTwoNumberTotalsAboveLimit([1, 2, 3], 10);
        Console.WriteLine(totalsTwo.Length == 0);

        int[] totalsThree = GetTwoNumberTotalsAboveLimit([-5, 20, -2, 15], 10);
        Console.WriteLine(totalsThree.Length == 3);
        Console.WriteLine(totalsThree[0] == 15);
        Console.WriteLine(totalsThree[1] == 18);
        Console.WriteLine(totalsThree[2] == 13);
        Console.WriteLine(GetTwoNumberTotalsAboveLimit(null!, 10).Length == 0);
        Console.WriteLine(GetTwoNumberTotalsAboveLimit([], 10).Length == 0);

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
