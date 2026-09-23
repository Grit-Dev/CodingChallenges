
public class Program
{
    public static int CountValuesMatchingIndexSignRule(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 0; index <= numbers.Length - 1; index++)
        {
            if (index % 2 == 0 && numbers[index] > 0)
            {
                counter++;
            }
            else if (index % 2 != 0 && numbers[index] < 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string[] ExtractLetterHashtags(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            int indexOfHashTag = word.IndexOf('#');

            if (indexOfHashTag == -1 || indexOfHashTag > 0)
            {
                continue;
            }

            if (word.Substring(indexOfHashTag + 1).Length < 1)
            {
                continue;
            }

            char newCharacter = word[indexOfHashTag + 1];

            if (!char.IsLetter(newCharacter))
            {
                continue;
            }
            else
            {
                newList.Add((word.Substring(indexOfHashTag + 1)));
            }
        }

        return newList.ToArray();
    }

    public static void Main(string[] args)
    {
        //Get Running Totals Until Negative
        //- Return an empty array if numbers is null or empty.
        //- Return a new array.
        //- Include the first negative running total before stopping.
        //- If the total never becomes negative, return all running totals.

        //Console checks:

        //int[] totalsOne = GetRunningTotalsUntilNegative(new int[] { 5, -2, -10, 20 });

        //Console.WriteLine(totalsOne.Length == 3);
        //Console.WriteLine(totalsOne[0] == 5);
        //Console.WriteLine(totalsOne[1] == 3);
        //Console.WriteLine(totalsOne[2] == -7);

        //int[] totalsTwo = GetRunningTotalsUntilNegative(new int[] { 2, 3, 4 });

        //Console.WriteLine(totalsTwo.Length == 3);
        //Console.WriteLine(totalsTwo[0] == 2);
        //Console.WriteLine(totalsTwo[1] == 5);
        //Console.WriteLine(totalsTwo[2] == 9);

        //int[] totalsThree = GetRunningTotalsUntilNegative(new int[] { -1, 5 });

        //Console.WriteLine(totalsThree.Length == 1);
        //Console.WriteLine(totalsThree[0] == -1);

        //Console.WriteLine(GetRunningTotalsUntilNegative(null).Length == 0);

        // Extract Letter Hashtags
        string[] tagsOne = ExtractLetterHashtags("learning #CSharp today #Coding");
        Console.WriteLine(tagsOne.Length == 2);
        Console.WriteLine(tagsOne[0] == "CSharp");
        Console.WriteLine(tagsOne[1] == "Coding");

        string[] tagsTwo = ExtractLetterHashtags("#one #123 # @bad #Two");
        Console.WriteLine(tagsTwo.Length == 2);
        Console.WriteLine(tagsTwo[0] == "one");
        Console.WriteLine(tagsTwo[1] == "Two");

        Console.WriteLine(ExtractLetterHashtags("no tags here").Length == 0);
        Console.WriteLine(ExtractLetterHashtags("").Length == 0);
        Console.WriteLine(ExtractLetterHashtags("   ").Length == 0);
        Console.WriteLine(ExtractLetterHashtags(null!).Length == 0);

        // Count Values Matching Index Sign Rule
        Console.WriteLine(CountValuesMatchingIndexSignRule([5, -1, 3, 4, -2]) == 3);
        Console.WriteLine(CountValuesMatchingIndexSignRule([1, 2, 3, 4]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule([-1, -2, -3, -4]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule([0, -1, 0, -5]) == 2);
        Console.WriteLine(CountValuesMatchingIndexSignRule(null!) == 0);
        Console.WriteLine(CountValuesMatchingIndexSignRule([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
