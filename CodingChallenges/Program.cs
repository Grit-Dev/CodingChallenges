
public class Program
{
    public static string? FindFirstRepeatedWord(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        List<string> newList = [];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in splitString)
        {
            string strLowered = str.ToLower();

            if(newList.Contains(strLowered))
            {
                return strLowered;
            }
            
            newList.Add(strLowered);
        }

        return null;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(FindFirstRepeatedWord("apple banana apple pear") == "apple");
        Console.WriteLine(FindFirstRepeatedWord("Dog cat DOG bird") == "dog");
        Console.WriteLine(FindFirstRepeatedWord("one two three") == null);
        Console.WriteLine(FindFirstRepeatedWord("") == null);
        Console.WriteLine(FindFirstRepeatedWord(" ") == null);
        Console.WriteLine(FindFirstRepeatedWord(null)== null);
        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
