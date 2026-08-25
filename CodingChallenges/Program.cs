public class Program
{
    public static Dictionary<string, int> CountPriorityFrequency(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<string, int> newDict = [];

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
        Dictionary<string, int> resultOne = CountPriorityFrequency("High, Low, High");
        Console.WriteLine(resultOne["high"] == 2);
        Console.WriteLine(resultOne["low"] == 1);

        Dictionary<string, int> resultTwo = CountPriorityFrequency("Medium, medium, LOW");
        Console.WriteLine(resultTwo["medium"] == 2);
        Console.WriteLine(resultTwo["low"] == 1);

        Dictionary<string, int> resultThree = CountPriorityFrequency("");
        Console.WriteLine(resultThree.Count == 0);

        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
