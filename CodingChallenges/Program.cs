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

    public static void Main(string[] args)
    {
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
        Console.WriteLine(FindWordsWithNoRepeatedLetters(null).Length == 0);

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
