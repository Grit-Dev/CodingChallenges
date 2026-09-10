
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

        return newDict.MaxBy(nd => nd.Value).Key.FirstOrDefault();

    }
    public static void Main(string[] args)
    {
        //Find Most Frequent Word
        Console.WriteLine(FindMostFrequentWord("apple banana apple pear banana apple") == "apple");
        Console.WriteLine(FindMostFrequentWord("Dog cat DOG bird CAT") == "dog");
        Console.WriteLine(FindMostFrequentWord("one two three") == "one");
        Console.WriteLine(FindMostFrequentWord("") == null);
        Console.WriteLine(FindMostFrequentWord(" ") == null);
        Console.WriteLine(FindMostFrequentWord(null!) == null);
        Console.WriteLine(FindMostFrequentWord("apple banana banana apple") == "banana");

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
