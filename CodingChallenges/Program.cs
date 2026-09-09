using System.Text;

public class Program
{
    public static int CountEvenNumbersAtEvenIndexes(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int outerIndex = 0; outerIndex <= numbers.Length - 1; outerIndex += 2)
        {
            if (numbers[outerIndex] % 2 == 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string CleanExtraSpacesBetweenWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();

        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {

            if (strBuilder.Length > 0)
            {
                strBuilder.Append(' ');
            }
            strBuilder.Append(str);
        }

        return strBuilder.ToString();
    }

    public static int[] CalculateRunningTotals(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        int total = 0;
        List<int> newList = [];

        foreach (int number in numbers)
        {
            newList.Add(total += number);
        }

        return newList.ToArray();
    }

    public static int? FindSmallestPositiveNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? smallestNumberSoFar = null;

        foreach (int number in numbers)
        {
            if (number > 0 && (number < smallestNumberSoFar || smallestNumberSoFar is null))
            {
                smallestNumberSoFar = number;
            }
        }

        return smallestNumberSoFar;
    }

    public static Dictionary<int, int> CountWordLengthFrequency(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<int, int> newDict = [];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            if (newDict.TryGetValue(str.Length, out int value))
            {
                newDict[str.Length] = value + 1;
            }
            else
            {
                newDict[str.Length] = 1;
            }
        }

        return newDict;
    }

    public static int CountLongWordsWithLinq(string input) => 
    string.IsNullOrWhiteSpace(input) ? 0 : 
    input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Count( ip => ip.Length > 4);
    public static void Main(string[] args)
    {
        // Count Long Words With Linq
        Console.WriteLine(CountLongWordsWithLinq("cat banana apple dog") == 2);
        Console.WriteLine(CountLongWordsWithLinq("one two six") == 0);
        Console.WriteLine(CountLongWordsWithLinq("coding practice today") == 3);
        Console.WriteLine(CountLongWordsWithLinq("") == 0);
        Console.WriteLine(CountLongWordsWithLinq("  ") == 0);
        Console.WriteLine(CountLongWordsWithLinq(null!) == 0);

        // Count Word Length Frequency
        // Dictionary<int, int> lengthsOne = CountWordLengthFrequency("cat dog apple");
        // Console.WriteLine(lengthsOne[3] == 2);
        // Console.WriteLine(lengthsOne[5] == 1);

        // Dictionary<int, int> lengthsTwo = CountWordLengthFrequency("hi to code");
        // Console.WriteLine(lengthsTwo[2] == 2);
        // Console.WriteLine(lengthsTwo[4] == 1);

        // Dictionary<int, int> lengthsThree = CountWordLengthFrequency("");
        // Console.WriteLine(lengthsThree.Count == 0);

        // Find Smallest Positive Number
        // Console.WriteLine(FindSmallestPositiveNumber([5, 2, -1, 10]) == 2);
        // Console.WriteLine(FindSmallestPositiveNumber([-5, 0, -2]) == null);
        // Console.WriteLine(FindSmallestPositiveNumber([7]) == 7);
        // Console.WriteLine(FindSmallestPositiveNumber([10, 3, 4, 1]) == 1);
        // Console.WriteLine(FindSmallestPositiveNumber(null!) == null);
        // Console.WriteLine(FindSmallestPositiveNumber([]) == null);

        // Calculate Running Totals
        // int[] totalsOne = CalculateRunningTotals([2, 4, 5]);
        // Console.WriteLine(totalsOne.Length == 3);
        // Console.WriteLine(totalsOne[0] == 2);
        // Console.WriteLine(totalsOne[1] == 6);
        // Console.WriteLine(totalsOne[2] == 11);

        // int[] totalsTwo = CalculateRunningTotals([10, -3, 2]);
        // Console.WriteLine(totalsTwo.Length == 3);
        // Console.WriteLine(totalsTwo[0] == 10);
        // Console.WriteLine(totalsTwo[1] == 7);
        // Console.WriteLine(totalsTwo[2] == 9);
        // Console.WriteLine(CalculateRunningTotals(null!).Length == 0);
        // Console.WriteLine(CalculateRunningTotals([]).Length == 0);
        // Console.WriteLine(CalculateRunningTotals([]).Length == 0);

        // Clean Extra Spaces Between Words
        // Console.WriteLine(CleanExtraSpacesBetweenWords("  Paul   is  coding  ") == "Paul is coding");
        // Console.WriteLine(CleanExtraSpacesBetweenWords("hello     world") == "hello world");
        // Console.WriteLine(CleanExtraSpacesBetweenWords("one") == "one");
        // Console.WriteLine(CleanExtraSpacesBetweenWords("") == "");
        // Console.WriteLine(CleanExtraSpacesBetweenWords(" ") == "");
        // Console.WriteLine(CleanExtraSpacesBetweenWords(null!) == "");

        // Count Even Numbers At Even Indexes
        // Console.WriteLine(CountEvenNumbersAtEvenIndexes([2, 3, 4, 5, 6]) == 3);
        // Console.WriteLine(CountEvenNumbersAtEvenIndexes([1, 2, 3, 4]) == 0);
        // Console.WriteLine(CountEvenNumbersAtEvenIndexes([0, 1, 8, 3]) == 2);
        // Console.WriteLine(CountEvenNumbersAtEvenIndexes(null!) == 0);
        // Console.WriteLine(CountEvenNumbersAtEvenIndexes([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
