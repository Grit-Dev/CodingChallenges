using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{
    public static Dictionary<string, int> CountCategoryFrequency(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        var newDict = new Dictionary<string, int>();

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if(newDict.ContainsKey(strTrimmed))
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
        // Dictionary Basics: Count Category Frequency: 
        Dictionary<string, int> resultOne = CountCategoryFrequency("Card, Sealed, Card");
        Console.WriteLine(resultOne["card"] == 2);
        Console.WriteLine(resultOne["sealed"] == 1);

        Dictionary<string, int> resultTwo = CountCategoryFrequency("Binder, binder, CARD");
        Console.WriteLine(resultTwo["binder"] == 2);
        Console.WriteLine(resultTwo["card"] == 1);

        Dictionary<string, int> resultThree = CountCategoryFrequency("");
        Console.WriteLine(resultThree.Count == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
