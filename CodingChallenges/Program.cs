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

        for (int index = 0; index < numbers.Length; index++)
        {
            total += numbers[index];

            if (highestRunningTotal is null || total > highestRunningTotal)
            {
                highestRunningTotal = total;
                highestRunningIndex = index;
            }
        }

        return highestRunningIndex;
    }

    public static int? FindHighestValidPrice(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        int? highestValidPrice = null;
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            int indexEqualCounter = strTrimmed.Count(iec => iec == '=');

            if (indexEqualCounter > 1)
            {
                continue;
            }

            int indexOfEqual = strTrimmed.IndexOf('=');

            if (indexOfEqual < 0)
            {
                continue;
            }

            if (strTrimmed.AsSpan(0, indexOfEqual).Length == 0 ||
            strTrimmed.AsSpan(indexOfEqual + 1).Length == 0)
            {
                continue;
            }

            if (int.TryParse(strTrimmed.AsSpan(indexOfEqual + 1), out int value) &&
            value >= 0)
            {
                if (highestValidPrice is null || value > highestValidPrice)
                {
                    highestValidPrice = value;
                }
            }
        }

        return highestValidPrice;
    }

    public static char? FindFirstUniqueLetter(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        Dictionary<char, int> newDict = [];

        foreach (char character in input.Trim())
        {
            if (!char.IsLetter(character))
            {
                continue;
            }

            char characterToLower = char.ToLower(character);

            if (newDict.TryGetValue(char.ToLower(characterToLower), out int value))
            {
                newDict[characterToLower] = value + 1;
            }
            else
            {
                newDict[characterToLower] = 1;
            }
        }

        char result = newDict.FirstOrDefault(nd => nd.Value == 1).Key;

        if (result == '\0')
        {
            return null;
        }

        return result;
    }
    public static void Main(string[] args)
    {
        // Find First Unique Letter
        Console.WriteLine(FindFirstUniqueLetter("swiss") == 'w');
        Console.WriteLine(FindFirstUniqueLetter("Racecar") == 'e');
        Console.WriteLine(FindFirstUniqueLetter("aabb") == null);
        Console.WriteLine(FindFirstUniqueLetter("1122!!a") == 'a');
        Console.WriteLine(FindFirstUniqueLetter("") == null);
        Console.WriteLine(FindFirstUniqueLetter(" ") == null);
        Console.WriteLine(FindFirstUniqueLetter(null!) == null);

        // Find Highest Valid Price
        // Console.WriteLine(FindHighestValidPrice("sleeves=5, box=40, bad") == 40);
        // Console.WriteLine(FindHighestValidPrice("bad=abc, playmat=-10") == null);
        // Console.WriteLine(FindHighestValidPrice("case=120, binder=35") == 120);
        // Console.WriteLine(FindHighestValidPrice("one=10=20, two=5") == 5);
        // Console.WriteLine(FindHighestValidPrice("free=0, paid=10") == 10);
        // Console.WriteLine(FindHighestValidPrice("") == null);
        // Console.WriteLine(FindHighestValidPrice(" ") == null);
        // Console.WriteLine(FindHighestValidPrice(null!) == null);

        // Find Index Of Highest Running Total
        // Console.WriteLine(FindIndexOfHighestRunningTotal([3, -1, 5, -10]) == 2);
        // Console.WriteLine(FindIndexOfHighestRunningTotal([5, -2, -10, 20]) == 3);
        // Console.WriteLine(FindIndexOfHighestRunningTotal([-2, -3, -1]) == 0);
        // Console.WriteLine(FindIndexOfHighestRunningTotal([1, 1, -5]) == 1);
        // Console.WriteLine(FindIndexOfHighestRunningTotal(null!) == null);
        // Console.WriteLine(FindIndexOfHighestRunningTotal([]) == null);

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
