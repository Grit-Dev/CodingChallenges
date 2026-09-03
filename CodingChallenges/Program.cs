using System.Text;

public class Program
{
    public static int CountNumbersDivisibleByThreeOrFive(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit == 0)
            {
                continue;
            }

            if (digit % 3 == 0 || digit % 5 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string ReverseEachWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();
        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            for (int innerIndex = str.Length - 1; innerIndex >= 0; innerIndex--)
            {
                strBuilder.Append(str[innerIndex]);
            }

            strBuilder.Append(' ');
        }

        return strBuilder.ToString().Trim();

    }

    public static bool IsWordMirrorMatch(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        int left = 0;
        int right = input.Length - 1;

        input = input.ToLower();

        while (left <= right)
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;

    }

    public static int[] MoveZeroesToEnd(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        List<int> newList = [];
        int counter = 0;

        foreach (int digit in numbers)
        {
            if (digit != 0)
            {
                newList.Add(digit);
            }
            else
            {
                counter++;
            }
        }

        for (int outerIndex = 0; outerIndex < counter; outerIndex++)
        {
            newList.Add(0);
        }

        return newList.ToArray();
    }

    public static string FindFirstUniqueWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var newDict = new Dictionary<string, int>();

        foreach (string str in splitString)
        {
            string strLowered = str.ToLower();

            if (newDict.TryGetValue(strLowered, out int value))
            {
                newDict[strLowered] = value + 1;
            }
            else
            {
                newDict[strLowered] = 1;
            }
        }

        var ans = newDict.FirstOrDefault(nd => nd.Value == 1).Key;

        return ans ?? "";
    }

    public static bool HasFailingScoreWithLinq(int[] scores) =>
    scores?.Any(s => s < 50) ?? false;
    
    public static void Main(string[] args)
    {
        // Has Failing Score With Linq
        Console.WriteLine(HasFailingScoreWithLinq([80, 70, 40]) == true);
        Console.WriteLine(HasFailingScoreWithLinq([50, 60, 70]) == false);
        Console.WriteLine(HasFailingScoreWithLinq([10]) == true);
        Console.WriteLine(HasFailingScoreWithLinq(null!) == false);
        Console.WriteLine(HasFailingScoreWithLinq([]) == false);

        // First Unique Word
        // Console.WriteLine(FindFirstUniqueWord("red blue red green") == "blue");
        // Console.WriteLine(FindFirstUniqueWord("Cat dog cat bird") == "dog");
        // Console.WriteLine(FindFirstUniqueWord("one one two two") == "");
        // Console.WriteLine(FindFirstUniqueWord("solo") == "solo");
        // Console.WriteLine(FindFirstUniqueWord("") == "");
        // Console.WriteLine(FindFirstUniqueWord(" ") == "");
        // Console.WriteLine(FindFirstUniqueWord(null!) == "");

        // Move Zeros to End
        // int[] movedOne = MoveZeroesToEnd([0, 1, 0, 3, 12]);
        // Console.WriteLine(movedOne.Length == 5);
        // Console.WriteLine(movedOne[0] == 1);
        // Console.WriteLine(movedOne[1] == 3);
        // Console.WriteLine(movedOne[2] == 12);
        // Console.WriteLine(movedOne[3] == 0);
        // Console.WriteLine(movedOne[4] == 0);

        // int[] movedTwo = MoveZeroesToEnd([1, 2, 3]);
        // Console.WriteLine(movedTwo[0] == 1);
        // Console.WriteLine(movedTwo[1] == 2);
        // Console.WriteLine(movedTwo[2] == 3);

        // int[] movedThree = MoveZeroesToEnd([0, 0, 5]);
        // Console.WriteLine(movedThree[0] == 5);
        // Console.WriteLine(movedThree[1] == 0);
        // Console.WriteLine(movedThree[2] == 0);
        // Console.WriteLine(MoveZeroesToEnd(null!).Length == 0);
        // Console.WriteLine(MoveZeroesToEnd([]).Length == 0);

        // // Is Word Mirror Match
        // Console.WriteLine(IsWordMirrorMatch("level") == true);
        // Console.WriteLine(IsWordMirrorMatch("Racecar") == true);
        // Console.WriteLine(IsWordMirrorMatch("hello") == false);
        // Console.WriteLine(IsWordMirrorMatch("ab ba") == true);
        // Console.WriteLine(IsWordMirrorMatch("a") == true);
        // Console.WriteLine(IsWordMirrorMatch("") == false);
        // Console.WriteLine(IsWordMirrorMatch(" ") == false);
        // Console.WriteLine(IsWordMirrorMatch(null!) == false);

        // Reverse Each Word
        // Console.WriteLine(ReverseEachWord("hello world") == "olleh dlrow");
        // Console.WriteLine(ReverseEachWord("Paul Codes") == "luaP sedoC");
        // Console.WriteLine(ReverseEachWord(" one two ") == "eno owt");
        // Console.WriteLine(ReverseEachWord("a") == "a");
        // Console.WriteLine(ReverseEachWord("") == "");
        // Console.WriteLine(ReverseEachWord(" ") == "");
        // Console.WriteLine(ReverseEachWord(null!) == "");

        // Warm Up: Count Numbers Divisible By Three Or Five
        // Console.WriteLine(CountNumbersDivisibleByThreeOrFive([3, 5, 15, 7, 10]) == 4);
        // Console.WriteLine(CountNumbersDivisibleByThreeOrFive([1, 2, 4, 8]) == 0);
        // Console.WriteLine(CountNumbersDivisibleByThreeOrFive([0, 30, -5]) == 2);
        // Console.WriteLine(CountNumbersDivisibleByThreeOrFive(null!) == 0);
        // Console.WriteLine(CountNumbersDivisibleByThreeOrFive([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
