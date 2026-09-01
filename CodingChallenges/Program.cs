using System.Text;

public class Program
{
    public static int CountNumbersOutsideRange(int[] numbers, int min, int max)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < min || digit > max)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int[] ReplaceNegativesWithZero(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        List<int> newList = [];

        foreach (int digit in numbers)
        {
            if (digit < 0)
            {
                newList.Add(0);
            }
            else
            {
                newList.Add(digit);
            }


        }

        return newList.ToArray();
    }

    public static string RemoveWordsShorterThanThree(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var newStringBuild = new StringBuilder();

        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in stringSplit)
        {
            if(str.Length >= 3)
            {
                newStringBuild.Append($"{str} ");
            }
        }

        return newStringBuild.ToString().Trim();

    }

    public static void Main(string[] args)
    {
        // Remove Words Shorter Than Three
        Console.WriteLine(RemoveWordsShorterThanThree("hi paul is coding today") == "paul coding today");
        Console.WriteLine(RemoveWordsShorterThanThree("a big red cat") == "big red cat");
        Console.WriteLine(RemoveWordsShorterThanThree("to be or not") == "not");
        Console.WriteLine(RemoveWordsShorterThanThree("") == "");
        Console.WriteLine(RemoveWordsShorterThanThree(" ") == "");
        Console.WriteLine(RemoveWordsShorterThanThree(null!) == "");

        // Replace Negatives With Zero
        // int[] replacedOne = ReplaceNegativesWithZero(new int[] { 1, -2, 3, -4 });
        // Console.WriteLine(replacedOne[0] == 1);
        // Console.WriteLine(replacedOne[1] == 0);
        // Console.WriteLine(replacedOne[2] == 3);
        // Console.WriteLine(replacedOne[3] == 0);

        // int[] replacedTwo = ReplaceNegativesWithZero(new int[] { -1, -2, -3 });
        // Console.WriteLine(replacedTwo[0] == 0);
        // Console.WriteLine(replacedTwo[1] == 0);
        // Console.WriteLine(replacedTwo[2] == 0);

        // Console.WriteLine(ReplaceNegativesWithZero(null).Length == 0);
        // Console.WriteLine(ReplaceNegativesWithZero([]).Length == 0);

        // Warm Up: Count Numbers Outside Range
        // Console.WriteLine(CountNumbersOutsideRange([1, 5, 10, 15, 20], 5, 15) == 2);
        // Console.WriteLine(CountNumbersOutsideRange([5, 10, 15], 5, 15) == 0);
        // Console.WriteLine(CountNumbersOutsideRange([-5, 0, 50], 0, 20) == 2);
        // Console.WriteLine(CountNumbersOutsideRange(null!, 0, 10) == 0);
        // Console.WriteLine(CountNumbersOutsideRange([], 0, 10) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
