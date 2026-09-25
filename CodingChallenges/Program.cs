public class Program
{
    public static int[] ClampNumbersToRange(int[] numbers, int min, int max)
    {
        if ((numbers is null || numbers.Length == 0) || min > max)
        {
            return [];
        }

        List<int> newList = [];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                newList.Add(max);
            }
            else if (number < min)
            {
                newList.Add(min);
            }
            else
            {
                newList.Add(number);
            }
        }

        return newList.ToArray();
    }

    public static string[] GetWordsBetweenLengths(string input, int minLength, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(input) || minLength > maxLength)
        {
            return [];
        }

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<string> newList = [];

        foreach (string word in splitString)
        {
            if (word.Length >= minLength && word.Length <= maxLength)
            {
                newList.Add(word);
            }
        }

        return newList.ToArray();
    }
    public static void Main(string[] args)
    {
        // Get Words Between Lengths
        string[] wordsOne = GetWordsBetweenLengths("cat banana dog coding", 3, 5);
        Console.WriteLine(wordsOne.Length == 2);
        Console.WriteLine(wordsOne[0] == "cat");
        Console.WriteLine(wordsOne[1] == "dog");

        string[] wordsTwo = GetWordsBetweenLengths("hi paul code practice", 4, 8);
        Console.WriteLine(wordsTwo.Length == 3);
        Console.WriteLine(wordsTwo[0] == "paul");
        Console.WriteLine(wordsTwo[1] == "code");
        Console.WriteLine(wordsTwo[2] == "practice");
        Console.WriteLine(GetWordsBetweenLengths("one two three", 10, 5).Length == 0);
        Console.WriteLine(GetWordsBetweenLengths("", 1, 5).Length == 0);
        Console.WriteLine(GetWordsBetweenLengths(null!, 1, 5).Length == 0);

        // Clamp Numbers To Range
        //int[] clampedOne = ClampNumbersToRange([-5, 3, 10, 20], 0, 10);
        //Console.WriteLine(clampedOne.Length == 4);
        //Console.WriteLine(clampedOne[0] == 0);
        //Console.WriteLine(clampedOne[1] == 3);
        //Console.WriteLine(clampedOne[2] == 10);
        //Console.WriteLine(clampedOne[3] == 10);

        //int[] clampedTwo = ClampNumbersToRange([1, 2, 3], 0, 5);
        //Console.WriteLine(clampedTwo[0] == 1);
        //Console.WriteLine(clampedTwo[1] == 2);
        //Console.WriteLine(clampedTwo[2] == 3);
        //Console.WriteLine(ClampNumbersToRange([1, 2, 3], 10, 5).Length == 0);
        //Console.WriteLine(ClampNumbersToRange(null!, 0, 10).Length == 0);
        //Console.WriteLine(ClampNumbersToRange([], 0, 10).Length == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
