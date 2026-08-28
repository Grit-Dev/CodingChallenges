using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{
    public static Dictionary<string, int> CountTagFrequency(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        var newDict = new Dictionary<string, int>();
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if (newDict.ContainsKey(strTrimmed))
            {
                newDict[strTrimmed]++;
            }
            else
            {
                newDict[strTrimmed] = 1;
            }
        }

        return newDict;
    }
    public static void Main(string[] args)
    {
        // Dictionary Basics: Count Tag Frequency: 
        Dictionary<string, int> resultCTGOne = CountTagFrequency("Rare, Common, Rare");
        Console.WriteLine(resultCTGOne["rare"] == 2);
        Console.WriteLine(resultCTGOne["common"] == 1);

        Dictionary<string, int> resultCTGTwo = CountTagFrequency("Epic, epic, COMMON");
        Console.WriteLine(resultCTGTwo["epic"] == 2);
        Console.WriteLine(resultCTGTwo["common"] == 1);

        Dictionary<string, int> resultCTGThree = CountTagFrequency("");
        Console.WriteLine(resultCTGThree.Count == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
