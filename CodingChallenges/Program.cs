using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    public static int CountNumbersOutsideRange(int[] numbers, int min, int max)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit < min || digit > max)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int[] ReplaceNegativesWithZero(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        List<int> newList = [];

        foreach (int digit in numbers)
        {
            if (digit < 0)
            {
                newList.Add(0);
            }
            else
            {
                newList.Add(digit);
            }


        }

        return newList.ToArray();
    }

    public static string RemoveWordsShorterThanThree(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var newStringBuild = new StringBuilder();

        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            if (str.Length >= 3)
            {
                newStringBuild.Append($"{str} ");
            }
        }

        return newStringBuild.ToString().Trim();

    }

    public static bool HasPairWithTargetSum(int[] numbers, int target)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return false;
        }

        for (int outerIndex = 0; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            for (int innerIndex = outerIndex + 1; innerIndex <= numbers.Length - 1; innerIndex++)
            {
                if (numbers[outerIndex] + numbers[innerIndex] == target)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static string FindFirstRepeatedWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var newDict = new Dictionary<string, int>();

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strLowered = str.ToLower();

            if (newDict.ContainsKey(strLowered))
            {
                return str;
            }
            else
            {
                newDict[strLowered] = 1;
            }
        }

        return "";
    }

    public static int[] GetPassingScoresWithLinq(int[] scores) =>
    scores?.Where(s => s >= 50).ToArray() ?? [];

    public static string FindFirstWordWithTwoVowels(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        List<char> vowelList = ['a', 'e', 'i', 'o', 'u'];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            int counter = 0;
            string strLowered = str.ToLower();

            foreach (char character in strLowered)
            {
                if (vowelList.Contains(character))
                {
                    counter++;
                }

                if (counter == 2)
                {
                    return str;
                }
            }
        }

        return "";
    }
    public static void Main(string[] args)
    {
        // Find First Word With Two Vowels
        Console.WriteLine(FindFirstWordWithTwoVowels("sky cat tree code") == "tree");
        Console.WriteLine(FindFirstWordWithTwoVowels("my rhythm fly") == "");
        Console.WriteLine(FindFirstWordWithTwoVowels("Paul codes daily") == "Paul");
        Console.WriteLine(FindFirstWordWithTwoVowels("dog house tree") == "house");
        Console.WriteLine(FindFirstWordWithTwoVowels("APPLE banana") == "APPLE");
        Console.WriteLine(FindFirstWordWithTwoVowels("a be see") == "see");
        Console.WriteLine(FindFirstWordWithTwoVowels("") == "");
        Console.WriteLine(FindFirstWordWithTwoVowels(" ") == "");
        Console.WriteLine(FindFirstWordWithTwoVowels(null!) == "");


        // Find Passing Scores With Linq
        // int[] passingOne = GetPassingScoresWithLinq([40, 50, 60, 30]);
        // Console.WriteLine(passingOne.Length == 2);
        // Console.WriteLine(passingOne[0] == 50);
        // Console.WriteLine(passingOne[1] == 60);

        // int[] passingTwo = GetPassingScoresWithLinq([80, 20, 90]);
        // Console.WriteLine(passingTwo.Length == 2);
        // Console.WriteLine(passingTwo[0] == 80);
        // Console.WriteLine(passingTwo[1] == 90);

        // Console.WriteLine(GetPassingScoresWithLinq([10, 20]).Length == 0);
        // Console.WriteLine(GetPassingScoresWithLinq(null!).Length == 0);
        // Console.WriteLine(GetPassingScoresWithLinq([]).Length == 0);

        // Find First Repeated Word
        // Console.WriteLine(FindFirstRepeatedWord("red blue green red") == "red");
        // Console.WriteLine(FindFirstRepeatedWord("Cat dog cat bird") == "cat");
        // Console.WriteLine(FindFirstRepeatedWord("one two three") == "");
        // Console.WriteLine(FindFirstRepeatedWord("") == "");
        // Console.WriteLine(FindFirstRepeatedWord(" ") == "");
        // Console.WriteLine(FindFirstRepeatedWord(null!) == "");

        // Has Pair With Target Sum
        // Console.WriteLine(HasPairWithTargetSum([2, 4, 6, 8], 10) == true);
        // Console.WriteLine(HasPairWithTargetSum([1, 2, 3], 10) == false);
        // Console.WriteLine(HasPairWithTargetSum([5, 5], 10) == true);
        // Console.WriteLine(HasPairWithTargetSum([7], 7) == false);
        // Console.WriteLine(HasPairWithTargetSum(null!, 10) == false);
        // Console.WriteLine(HasPairWithTargetSum([], 10) == false);

        // Remove Words Shorter Than Three
        // Console.WriteLine(RemoveWordsShorterThanThree("hi paul is coding today") == "paul coding today");
        // Console.WriteLine(RemoveWordsShorterThanThree("a big red cat") == "big red cat");
        // Console.WriteLine(RemoveWordsShorterThanThree("to be or not") == "not");
        // Console.WriteLine(RemoveWordsShorterThanThree("") == "");
        // Console.WriteLine(RemoveWordsShorterThanThree(" ") == "");
        // Console.WriteLine(RemoveWordsShorterThanThree(null!) == "");

        // Replace Negatives With Zero
        // int[] replacedOne = ReplaceNegativesWithZero(new int[] { 1, -2, 3, -4 });
        // Console.WriteLine(replacedOne[0] == 1);
        // Console.WriteLine(replacedOne[1] == 0);
        // Console.WriteLine(replacedOne[2] == 3);
        // Console.WriteLine(replacedOne[3] == 0);

        // int[] replacedTwo = ReplaceNegativesWithZero(new int[] { -1, -2, -3 });
        // Console.WriteLine(replacedTwo[0] == 0);
        // Console.WriteLine(replacedTwo[1] == 0);
        // Console.WriteLine(replacedTwo[2] == 0);

        // Console.WriteLine(ReplaceNegativesWithZero(null).Length == 0);
        // Console.WriteLine(ReplaceNegativesWithZero([]).Length == 0);

        // Warm Up: Count Numbers Outside Range
        // Console.WriteLine(CountNumbersOutsideRange([1, 5, 10, 15, 20], 5, 15) == 2);
        // Console.WriteLine(CountNumbersOutsideRange([5, 10, 15], 5, 15) == 0);
        // Console.WriteLine(CountNumbersOutsideRange([-5, 0, 50], 0, 20) == 2);
        // Console.WriteLine(CountNumbersOutsideRange(null!, 0, 10) == 0);
        // Console.WriteLine(CountNumbersOutsideRange([], 0, 10) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
