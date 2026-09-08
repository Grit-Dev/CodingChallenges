
using System.Text;

public class Program
{
    public static int CountNumbersBetweenTwoValues(int[] numbers, int min, int max)
    {
        if (numbers is null || numbers.Length == 0 || min > max)
        {
            return 0;
        }

        int counter = 0;

        foreach (int number in numbers)
        {
            if (number >= min && number <= max)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string NormaliseNameList(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if (strTrimmed.Length == 0)
            {
                continue;
            }

            if (strBuilder.Length > 0)
            {
                strBuilder.Append(", ");
            }

            strBuilder.Append(strTrimmed);
        }

        return strBuilder.ToString();
    }

    public static int? FindFirstPointWhereBalanceGoesNegative(int[] changes)
    {
        if (changes is null || changes.Length == 0)
        {
            return null;
        }

        int total = 0;

        foreach (int number in changes)
        {
            total += number;

            if (total < 0)
            {
                return total;
            }
        }

        return null;
    }
    public static void Main(string[] args)
    {
        // Find First Point Where Balance Goes negative 
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([10, -3, -8, 5]) == -1);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([5, -2, -1]) == null);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([-4, 10]) == -4);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative(null!) == null);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([]) == null);

        // Normalise Name List
        // Console.WriteLine(NormaliseNameList(" Paul, SARAH , bob ") == "paul, sarah, bob");
        // Console.WriteLine(NormaliseNameList("Tom,, Amy, ") == "tom, amy");
        // Console.WriteLine(NormaliseNameList(" Derek ") == "derek");
        // Console.WriteLine(NormaliseNameList("") == "");
        // Console.WriteLine(NormaliseNameList(" ") == "");
        // Console.WriteLine(NormaliseNameList(null!) == "");

        // // Count Numbers Between Two Values
        // Console.WriteLine(CountNumbersBetweenTwoValues([1, 5, 10, 15, 20], 5, 15) == 3);
        // Console.WriteLine(CountNumbersBetweenTwoValues([5, 10, 15], 6, 14) == 1);
        // Console.WriteLine(CountNumbersBetweenTwoValues([-5, 0, 5], -5, 0) == 2);
        // Console.WriteLine(CountNumbersBetweenTwoValues([1, 2, 3], 10, 5) == 0);
        // Console.WriteLine(CountNumbersBetweenTwoValues(null!, 0, 10) == 0);
        // Console.WriteLine(CountNumbersBetweenTwoValues([], 0, 10) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
