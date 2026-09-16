public class Program
{
    public static int[] GetTopTwoEvenNumbersWithLinq(int[] numbers) =>
    numbers is null || numbers.Length == 0 ? [] :
    numbers.Where(n => n % 2 == 0).OrderByDescending(n => n).Take(2).ToArray();

    public static string? FindMostExpensiveItem(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        int? HighestPriceSoFar = null;
        string? highestProductPriceItem = null;

        string[] stringSplit = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            string strTrimmed = str.Trim();

            int indexOfEqualCounter = strTrimmed.Count(ioe => ioe == '=');
            int indexOfEqual = strTrimmed.IndexOf('=');

            if (indexOfEqualCounter != 1)
            {
                continue;
            }

            if (strTrimmed.Substring(0, indexOfEqual).Length == 0 ||
            strTrimmed.Substring(indexOfEqual + 1).Length == 0)
            {
                continue;
            }

            if (int.TryParse(strTrimmed.Substring(indexOfEqual + 1), out int value) &&
            value >= 0 && (HighestPriceSoFar is null || value > HighestPriceSoFar))
            {
                HighestPriceSoFar = value;
                highestProductPriceItem = strTrimmed.Substring(0, indexOfEqual).Trim();
            }
        }

        return highestProductPriceItem;
    }
    public static void Main(string[] args)
    {
        // Find Most Expensive Item
        Console.WriteLine(FindMostExpensiveItem("box=50, sleeves=10, binder=40") == "box");
        Console.WriteLine(FindMostExpensiveItem("box=50, binder=50, sleeves=10") == "box");
        Console.WriteLine(FindMostExpensiveItem("box=abc, sleeves=-1") == null);
        Console.WriteLine(FindMostExpensiveItem(" item = 100 , other = 99 ") == "item");
        Console.WriteLine(FindMostExpensiveItem("bad=10=20, good=5") == "good");
        Console.WriteLine(FindMostExpensiveItem("") == null);
        Console.WriteLine(FindMostExpensiveItem(" ") == null);
        Console.WriteLine(FindMostExpensiveItem(null!) == null);

        // Get Top Two Even Numbers
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([1, 8, 4, 10, 3]).SequenceEqual([10, 8]));
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([2]).SequenceEqual([2]));
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([7, 9]).Length == 0);
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq(null!).Length == 0);
        // Console.WriteLine(GetTopTwoEvenNumbersWithLinq([]).Length == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
