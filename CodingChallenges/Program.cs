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
    public static Dictionary<string, int> CountWordFrequencyWithTryGetValue(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<string, int> newDict = [];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if (newDict.TryGetValue(strTrimmed, out int value))
            {
                newDict[strTrimmed] = value + 1;
            }
            else
            {
                newDict[strTrimmed] = 1;
            }
        }

        return newDict;

    }

    public static int[] SquareNumbersWithLinq(int[] numbers) =>
        numbers?.Select(n => n * n).ToArray() ?? [];

    public static string FindFirstWordWithMoreConsonantsThanVowels(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        List<char> newListVowels = ['a', 'e', 'i', 'o', 'u'];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            int countVowels = 0;
            int countNonVowels = 0;

            string strLowered = str.ToLower();

            foreach (char character in strLowered)
            {
                if (newListVowels.Contains(character))
                {
                    countVowels++;
                }
                else if(char.IsLetter(character))
                {
                    countNonVowels++;
                }
            }

            if(countNonVowels > countVowels)
            {
                return str;
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
