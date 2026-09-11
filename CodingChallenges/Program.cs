
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
    public static void Main(string[] args)
    {
        // Find Biggest Drop Between Adjacent Numbers
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([10, 7, 12, 4]) == 8);
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([5, 4, 3]) == 1);
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([1, 2, 3]) == null);
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([9, 1, 8, 2]) == 8);
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([7]) == null);
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers(null!) == null);
        Console.WriteLine(FindBiggestDropBetweenAdjacentNumbers([]) == null);


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
