public class Program
{
    public static Dictionary<char, int> CountFirstLetterFrequency(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<char, int> dict = [];

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            char firstLetter = char.ToLower(word[0]);

            if (dict.ContainsKey(firstLetter))
            {
                dict[firstLetter]++;
            }
            else
            {
                dict.Add(firstLetter, 1);
            }
        }

        return dict;
    }
    public static void Main(string[] args)
    {
        // Count First Letter Frequency
        var resultOne = CountFirstLetterFrequency("apple banana apricot");
        Console.WriteLine(resultOne['a'] == 2);
        Console.WriteLine(resultOne['b'] == 1);

        var resultTwo = CountFirstLetterFrequency("Dog duck cat");
        Console.WriteLine(resultTwo['d'] == 2);
        Console.WriteLine(resultTwo['c'] == 1);

        var resultThree = CountFirstLetterFrequency("");
        Console.WriteLine(resultThree.Count == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
