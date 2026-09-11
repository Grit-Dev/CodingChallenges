
using System.Text;
using CodingChallenges.Challenges.Phase_02_OOP.shared;

public class Program
{
    public static string? FindFirstRepeatedWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        List<string> newList = [];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strLowered = str.ToLower();

            if (newList.Contains(strLowered))
            {
                return strLowered;
            }

            newList.Add(strLowered);
        }

        return null;
    }

    public static string? FindMostFrequentWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        Dictionary<string, int> newDict = [];
        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);


        foreach (string str in stringSplit)
        {
            string strLowered = str.ToLower();

            if (newDict.TryGetValue(strLowered, out int value))
            {
                newDict[strLowered] = value + 1;
            }
            else
            {
                newDict[strLowered] = 1;
            }
        }

        return newDict.MaxBy(nd => nd.Value).Key;

    }

    public static int CountPositiveToNegativeChanges(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            if (numbers[index] == 0 || numbers[index + 1] == 0)
            {
                continue;
            }

            if (int.IsPositive(numbers[index]) && int.IsNegative(numbers[index + 1]))
            {
                counter++;
            }
        }

        return counter;
    }

    public static string CapitaliseFirstLetterOnly(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        input = input.Trim().ToLower();

        return char.ToUpper(input[0]) + input.Substring(1);
    }

    public static int? FindBiggestDropBetweenAdjacentNumbers(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return null;
        }

        int? biggestDropTotalFound = null;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            if (numbers[index] > numbers[index + 1])
            {
                int dropTotal = numbers[index] - numbers[index + 1];

                if (biggestDropTotalFound is null ||
                    dropTotal > biggestDropTotalFound)
                {
                    biggestDropTotalFound = dropTotal;
                }
            }
        }

        return biggestDropTotalFound;
    }

    public static int CountValidAges(string input)
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

            if (int.TryParse(strTrimmed, out int value) &&
            value >= 0 && value <= 120)
            {
                counter++;
            }
        }

        return counter;
    }

    public static Dictionary<string, int> GroupNumbersBySign(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        Dictionary<string, int> newDict = [];

        foreach (int number in numbers)
        {
            string result = number < 0 ? "negative" :
            number > 0 ? "positive" : "zero";

            if (newDict.TryGetValue(result, out int value))
            {
                newDict[result] = value + 1;
            }
            else
            {
                newDict[result] = 1;
            }
        }

        return newDict;
    }

    public static string FindLongestWordWithMaxBy(string input) =>
    string.IsNullOrWhiteSpace(input) ? "" : input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .MaxBy(ip => ip.Length) ?? "";

    public static string ConvertFullNameToTitleCase(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var result = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(ip => ip.Trim().ToLower());

        var strBuilder = new StringBuilder();

        foreach(string str in result)
        {
            if(strBuilder.Length > 0)
            {
                strBuilder.Append(' ');
            }

            strBuilder.Append(char.ToUpper(str[0]) + str.Substring(1));
            
        }

        return strBuilder.ToString();
    }
    public static void Main(string[] args)
    {
        // Convert Full Name To Title Case
        Console.WriteLine(ConvertFullNameToTitleCase("paul MCGINLEY") == "Paul Mcginley");
        Console.WriteLine(ConvertFullNameToTitleCase(" SARAH connor ") == "Sarah Connor");
        Console.WriteLine(ConvertFullNameToTitleCase("john michael SMITH") == "John Michael Smith");
        Console.WriteLine(ConvertFullNameToTitleCase("x") == "X");
        Console.WriteLine(ConvertFullNameToTitleCase("") == "");
        Console.WriteLine(ConvertFullNameToTitleCase(null) == "");

        // MaxBy Refresher
        // Console.WriteLine(FindLongestWordWithMaxBy("cat banana dog") == "banana");
        // Console.WriteLine(FindLongestWordWithMaxBy("one three seven") == "three");
        // Console.WriteLine(FindLongestWordWithMaxBy("coding daily practice") == "practice");
        // Console.WriteLine(FindLongestWordWithMaxBy("x") == "x");
        // Console.WriteLine(FindLongestWordWithMaxBy("") == "");
        // Console.WriteLine(FindLongestWordWithMaxBy(" ") == "");
        // Console.WriteLine(FindLongestWordWithMaxBy(null!) == "");

        // Group Numbers By Sign
        // Dictionary<string, int> signsOne = GroupNumbersBySign([5, -2, 0, 10]);
        // Console.WriteLine(signsOne["positive"] == 2);
        // Console.WriteLine(signsOne["negative"] == 1);
        // Console.WriteLine(signsOne["zero"] == 1);

        // Dictionary<string, int> signsTwo = GroupNumbersBySign([-1, -2, -3]);
        // Console.WriteLine(signsTwo["negative"] == 3);
        // Console.WriteLine(signsTwo.ContainsKey("positive") == false);
        // Console.WriteLine(signsTwo.ContainsKey("zero") == false);

        // Dictionary<string, int> signsThree = GroupNumbersBySign(null!);
        // Console.WriteLine(signsThree.Count == 0);

        // Count Valid Ages
        // Console.WriteLine(CountValidAges("20, 35, abc, -1, 121") == 2);
        // Console.WriteLine(CountValidAges("0, 120, 50") == 3);
        // Console.WriteLine(CountValidAges("10, bad, 30") == 2);
        // Console.WriteLine(CountValidAges("abc, -5, 999") == 0);
        // Console.WriteLine(CountValidAges("") == 0);
        // Console.WriteLine(CountValidAges(" ") == 0);
        // Console.WriteLine(CountValidAges(null!) == 0);

        // Find Biggest Drop Between Adjacent Numbers
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([10, 7, 12, 4]) == 8);
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([5, 4, 3]) == 1);
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([1, 2, 3]) == null);
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([9, 1, 8, 2]) == 8);
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([7]) == null);
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers(null!) == null);
        // Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([]) == null);

        // Capitalise First Letter Only
        // Console.WriteLine(CapitaliseFirstLetterOnly("paul") == "Paul");
        // Console.WriteLine(CapitaliseFirstLetterOnly("PAUL") == "Paul");
        // Console.WriteLine(CapitaliseFirstLetterOnly(" cODING ") == "Coding");
        // Console.WriteLine(CapitaliseFirstLetterOnly("x") == "X");
        // Console.WriteLine(CapitaliseFirstLetterOnly("") == "");
        // Console.WriteLine(CapitaliseFirstLetterOnly(" ") == "");
        // Console.WriteLine(CapitaliseFirstLetterOnly(null!) == "");

        // Count Positive To Negative Changes
        // Console.WriteLine(CountPositiveToNegativeChanges([5, -1, -2, 3, -4]) == 2);
        // Console.WriteLine(CountPositiveToNegativeChanges([-1, 2, -3]) == 1);
        // Console.WriteLine(CountPositiveToNegativeChanges([1, 0, -1]) == 0);
        // Console.WriteLine(CountPositiveToNegativeChanges([1, 2, 3]) == 0);
        // Console.WriteLine(CountPositiveToNegativeChanges([7]) == 0);
        // Console.WriteLine(CountPositiveToNegativeChanges(null!) == 0);
        // Console.WriteLine(CountPositiveToNegativeChanges([]) == 0);

        //Find Most Frequent Word
        // Console.WriteLine(FindMostFrequentWord("apple banana apple pear banana apple") == "apple");
        // Console.WriteLine(FindMostFrequentWord("Dog cat DOG bird CAT") == "dog");
        // Console.WriteLine(FindMostFrequentWord("one two three") == "one");
        // Console.WriteLine(FindMostFrequentWord("") == null);
        // Console.WriteLine(FindMostFrequentWord(" ") == null);
        // Console.WriteLine(FindMostFrequentWord(null!) == null);

        // Find First Repeated Word
        // Console.WriteLine(FindFirstRepeatedWord("apple banana apple pear") == "apple");
        // Console.WriteLine(FindFirstRepeatedWord("Dog cat DOG bird") == "dog");
        // Console.WriteLine(FindFirstRepeatedWord("one two three") == null);
        // Console.WriteLine(FindFirstRepeatedWord("") == null);
        // Console.WriteLine(FindFirstRepeatedWord(" ") == null);
        // Console.WriteLine(FindFirstRepeatedWord(null!) == null);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
