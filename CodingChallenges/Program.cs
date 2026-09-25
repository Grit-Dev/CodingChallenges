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

    public static int[] MergeArraysAlternating(int[] first, int[] second)
    {
        int firstLength = first?.Length ?? 0;
        int secondLength = second?.Length ?? 0;

        if (firstLength == 0 && secondLength == 0)
        {
            return [];
        }

        List<int> result = [];

        int maxLength = Math.Max(firstLength, secondLength);

        for (int index = 0; index < maxLength; index++)
        {
            if (index < firstLength)
            {
                result.Add(first![index]);
            }

            if (index < secondLength)
            {
                result.Add(second![index]);
            }
        }

        return result.ToArray();
    }

    public static void Main(string[] args)
    {
        // Merge Arrays Alternating 
        int[] mergedOne = MergeArraysAlternating([1, 2, 3], [10, 20]);
        Console.WriteLine(mergedOne.Length == 5);
        Console.WriteLine(mergedOne[0] == 1);
        Console.WriteLine(mergedOne[1] == 10);
        Console.WriteLine(mergedOne[2] == 2);
        Console.WriteLine(mergedOne[3] == 20);
        Console.WriteLine(mergedOne[4] == 3);

        int[] mergedTwo = MergeArraysAlternating([1], [10, 20, 30]);
        Console.WriteLine(mergedTwo.Length == 4);
        Console.WriteLine(mergedTwo[0] == 1);
        Console.WriteLine(mergedTwo[1] == 10);
        Console.WriteLine(mergedTwo[2] == 20);
        Console.WriteLine(mergedTwo[3] == 30);

        int[] mergedThree = MergeArraysAlternating(null!, [5, 6]);
        Console.WriteLine(mergedThree.Length == 2);
        Console.WriteLine(mergedThree[0] == 5);
        Console.WriteLine(mergedThree[1] == 6);
        Console.WriteLine(MergeArraysAlternating(null!, null!).Length == 0);

        // Get Words Between Lengths
        //string[] wordsOne = GetWordsBetweenLengths("cat banana dog coding", 3, 5);
        //Console.WriteLine(wordsOne.Length == 2);
        //Console.WriteLine(wordsOne[0] == "cat");
        //Console.WriteLine(wordsOne[1] == "dog");

        //string[] wordsTwo = GetWordsBetweenLengths("hi paul code practice", 4, 8);
        //Console.WriteLine(wordsTwo.Length == 3);
        //Console.WriteLine(wordsTwo[0] == "paul");
        //Console.WriteLine(wordsTwo[1] == "code");
        //Console.WriteLine(wordsTwo[2] == "practice");
        //Console.WriteLine(GetWordsBetweenLengths("one two three", 10, 5).Length == 0);
        //Console.WriteLine(GetWordsBetweenLengths("", 1, 5).Length == 0);
        //Console.WriteLine(GetWordsBetweenLengths(null!, 1, 5).Length == 0);

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
