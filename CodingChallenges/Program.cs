
using System.Diagnostics.Metrics;

public class Program
{
    public static int CountValuesMatchingIndexSignRule(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 0; index <= numbers.Length - 1; index++)
        {
            if (index % 2 == 0 && numbers[index] > 0)
            {
                counter++;
            }
            else if (index % 2 != 0 && numbers[index] < 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string[] ExtractLetterHashtags(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            int indexOfHashTag = word.IndexOf('#');

            if (indexOfHashTag == -1 || indexOfHashTag > 0)
            {
                continue;
            }

            if (word.Substring(indexOfHashTag + 1).Length < 1)
            {
                continue;
            }

            char newCharacter = word[indexOfHashTag + 1];

            if (!char.IsLetter(newCharacter))
            {
                continue;
            }
            else
            {
                newList.Add((word.Substring(indexOfHashTag + 1)));
            }
        }

        return newList.ToArray();
    }

    public static int[] GetRunningTotalsUntilNegative(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        int total = 0;
        List<int> newList = [];

        foreach (int number in numbers)
        {
            newList.Add(total += number);

            if (total < 0)
            {
                return newList.ToArray();
            }
        }

        return newList.ToArray();
    }

    public static int CountValidItemQuantities(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            int indexOfEqual = strTrimmed.IndexOf('=');

            if (indexOfEqual == -1)
            {
                continue;
            }

            int countEquals = strTrimmed.Count(ce => ce == '=');

            if (countEquals > 1)
            {
                continue;
            }

            if (strTrimmed.Substring(0, indexOfEqual).Length == 0 ||
                strTrimmed.Substring(indexOfEqual + 1).Length == 0)
            {
                continue;
            }

            if (int.TryParse(strTrimmed.Substring(indexOfEqual + 1), out int value) &&
                value >= 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int[] GetTopThreeUniqueScoresWithLinq(int[] scores) => scores is null || 
        scores.Length == 0 ? [] : scores.OrderByDescending(c => c).Distinct().Take(3).ToArray();

    public static void Main(string[] args)
    {
        //Get Top Three Unique Scores With Linq
        int[] topOne = GetTopThreeUniqueScoresWithLinq([50, 90, 90, 70, 100]);
        Console.WriteLine(topOne.Length == 3);
        Console.WriteLine(topOne[0] == 100);
        Console.WriteLine(topOne[1] == 90);
        Console.WriteLine(topOne[2] == 70);

        int[] topTwo = GetTopThreeUniqueScoresWithLinq([5, 5, 1]);
        Console.WriteLine(topTwo.Length == 2);
        Console.WriteLine(topTwo[0] == 5);
        Console.WriteLine(topTwo[1] == 1);

        int[] topThree = GetTopThreeUniqueScoresWithLinq([-1, 10, 0, 10]);
        Console.WriteLine(topThree.Length == 3);
        Console.WriteLine(topThree[0] == 10);
        Console.WriteLine(topThree[1] == 0);
        Console.WriteLine(topThree[2] == -1);
        Console.WriteLine(GetTopThreeUniqueScoresWithLinq(null!).Length == 0);
        Console.WriteLine(GetTopThreeUniqueScoresWithLinq([]).Length == 0);

        // Count Valid Item Quantities
        Console.WriteLine(CountValidItemQuantities("binder=abc, case=1") == 1);
        Console.WriteLine(CountValidItemQuantities("   =5, mat=0") == 1);
        Console.WriteLine(CountValidItemQuantities("one=10=20, two=5") == 1);
        Console.WriteLine(CountValidItemQuantities("bad, alsoBad") == 0);
        Console.WriteLine(CountValidItemQuantities("") == 0);
        Console.WriteLine(CountValidItemQuantities("   ") == 0);
        Console.WriteLine(CountValidItemQuantities(null!) == 0);

        // Get Running Totals Until Negative
        int[] totalsOne = GetRunningTotalsUntilNegative([5, -2, -10, 20]);
        Console.WriteLine(totalsOne.Length == 3);
        Console.WriteLine(totalsOne[0] == 5);
        Console.WriteLine(totalsOne[1] == 3);
        Console.WriteLine(totalsOne[2] == -7);

        int[] totalsTwo = GetRunningTotalsUntilNegative([2, 3, 4]);
        Console.WriteLine(totalsTwo.Length == 3);
        Console.WriteLine(totalsTwo[0] == 2);
        Console.WriteLine(totalsTwo[1] == 5);
        Console.WriteLine(totalsTwo[2] == 9);

        int[] totalsThree = GetRunningTotalsUntilNegative([-1, 5]);
        Console.WriteLine(totalsThree.Length == 1);
        Console.WriteLine(totalsThree[0] == -1);
        Console.WriteLine(GetRunningTotalsUntilNegative(null!).Length == 0);

        // Extract Letter Hashtags
        string[] tagsOne = ExtractLetterHashtags("learning #CSharp today #Coding");
        Console.WriteLine(tagsOne.Length == 2);
        Console.WriteLine(tagsOne[0] == "CSharp");
        Console.WriteLine(tagsOne[1] == "Coding");

        string[] tagsTwo = ExtractLetterHashtags("#one #123 # @bad #Two");
        Console.WriteLine(tagsTwo.Length == 2);
        Console.WriteLine(tagsTwo[0] == "one");
        Console.WriteLine(tagsTwo[1] == "Two");

        Console.WriteLine(ExtractLetterHashtags("no tags here").Length == 0);
        Console.WriteLine(ExtractLetterHashtags("").Length == 0);
        Console.WriteLine(ExtractLetterHashtags("   ").Length == 0);
        Console.WriteLine(ExtractLetterHashtags(null!).Length == 0);

        // Count Values Matching Index Sign Rule
        Console.WriteLine(CountValuesMatchingIndexSignRule([5, -1, 3, 4, -2]) == 3);
        Console.WriteLine(CountValuesMatchingIndexSignRule([1, 2, 3, 4]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule([-1, -2, -3, -4]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule([0, -1, 0, -5]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule(null!) == 0);
        Console.WriteLine(CountValuesMatchingIndexSignRule([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
