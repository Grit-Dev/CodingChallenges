public class Program
{
    public static int[] RotateRightByOne(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        if (numbers.Length == 1)
        {
            return [numbers[0]];
        }

        int[] result = new int[numbers.Length];

        result[0] = numbers[numbers.Length - 1];

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            result[index + 1] = numbers[index];
        }

        return result;
    }

    public static string[] FindWordsWithNoRepeatedLetters(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitString)
        {
            List<char> UniqueChr = [];

            foreach (char chr in word)
            {
                if (!UniqueChr.Contains(chr))
                {
                    UniqueChr.Add(chr);
                }
            }

            if (UniqueChr.Count == word.Length)
            {
                newList.Add(word);
            }
        }

        return newList.ToArray();
    }

    public static int? FindStartIndexOfLongestIncreasingRun(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
            return null;

        int longestStart = 0;
        int longestLength = 1;

        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestStart = currentStart;
                }

                currentStart = i;
                currentLength = 1;
            }
        }

        // Final check for last run
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }

        return longestStart;
    }

    public static void Main(string[] args)
    {
        // Find Start Index Of Longest Increasing Run
        Console.WriteLine(FindStartIndexOfLongestIncreasingRun([1, 3, 5, 2, 4]) == 0);
        Console.WriteLine(FindStartIndexOfLongestIncreasingRun([5, 4, 3]) == 0);
        Console.WriteLine(FindStartIndexOfLongestIncreasingRun([1, 2, 1, 2, 3]) == 2);
        Console.WriteLine(FindStartIndexOfLongestIncreasingRun([7]) == 0);
        Console.WriteLine(FindStartIndexOfLongestIncreasingRun(null!) == null);
        Console.WriteLine(FindStartIndexOfLongestIncreasingRun([]) == null);

        // Unique Letters:
        string[] uniqueLettersOne = FindWordsWithNoRepeatedLetters("cat apple sword moon");

        Console.WriteLine(uniqueLettersOne.Length == 2);
        Console.WriteLine(uniqueLettersOne[0] == "cat");
        Console.WriteLine(uniqueLettersOne[1] == "sword");

        string[] uniqueLettersTwo = FindWordsWithNoRepeatedLetters("Book test abc");

        Console.WriteLine(uniqueLettersTwo.Length == 1);
        Console.WriteLine(uniqueLettersTwo[0] == "abc");

        Console.WriteLine(FindWordsWithNoRepeatedLetters("hello moon").Length == 0);
        Console.WriteLine(FindWordsWithNoRepeatedLetters("").Length == 0);
        Console.WriteLine(FindWordsWithNoRepeatedLetters(null!).Length == 0);

        // Warm Up: Rotate Right By One
        int[] rotateOne = RotateRightByOne([1, 2, 3, 4]);

        Console.WriteLine(rotateOne.Length == 4);
        Console.WriteLine(rotateOne[0] == 4);
        Console.WriteLine(rotateOne[1] == 1);
        Console.WriteLine(rotateOne[2] == 2);
        Console.WriteLine(rotateOne[3] == 3);

        int[] rotateTwo = RotateRightByOne([10, 20]);

        Console.WriteLine(rotateTwo[0] == 20);
        Console.WriteLine(rotateTwo[1] == 10);

        int[] rotateThree = RotateRightByOne([7]);

        Console.WriteLine(rotateThree.Length == 1);
        Console.WriteLine(rotateThree[0] == 7);

        Console.WriteLine(RotateRightByOne(null!).Length == 0);
        Console.WriteLine(RotateRightByOne([]).Length == 0);


        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
