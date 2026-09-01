using System.Globalization;
using System.Security.Cryptography.X509Certificates;
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
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var newStringBuild = new StringBuilder();

        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            if (str.Length >= 3)
            {
                newStringBuild.Append($"{str} ");
            }
        }

        return newStringBuild.ToString().Trim();

    }

    public static bool HasPairWithTargetSum(int[] numbers, int target)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return false;
        }

        for (int outerIndex = 0; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            for (int innerIndex = outerIndex + 1; innerIndex <= numbers.Length - 1; innerIndex++)
            {
                if (numbers[outerIndex] + numbers[innerIndex] == target)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static string FindFirstRepeatedWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var newDict = new Dictionary<string, int>();

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strLowered = str.ToLower();

            if (newDict.ContainsKey(strLowered))
            {
                return str;
            }
            else
            {
                newDict[strLowered] = 1;
            }
        }

        return "";
    }

    public static int[] GetPassingScoresWithLinq(int[] scores) =>
    scores?.Where(s => s >= 50).ToArray() ?? [];

    public static string FindFirstWordWithTwoVowels(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        List<char> vowelList = ['a', 'e', 'i', 'o', 'u'];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            int counter = 0;
            string strLowered = str.ToLower();

            foreach (char character in strLowered)
            {
                if (vowelList.Contains(character))
                {
                    counter++;
                }

                if (counter == 2)
                {
                    return str;
                }
            }
        }

        return "";
    }
    public static void Main(string[] args)
    {
        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
