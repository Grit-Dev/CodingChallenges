
using System.Reflection.PortableExecutable;
using System.Text;

public class Program
{
    public static int CountNumbersBetweenTwoValues(int[] numbers, int min, int max)
    {
        if (numbers is null || numbers.Length == 0 || min > max)
        {
            return 0;
        }

        int counter = 0;

        foreach (int number in numbers)
        {
            if (number >= min && number <= max)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string NormaliseNameList(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim().ToLower();

            if (strTrimmed.Length == 0)
            {
                continue;
            }

            if (strBuilder.Length > 0)
            {
                strBuilder.Append(", ");
            }

            strBuilder.Append(strTrimmed);
        }

        return strBuilder.ToString();
    }

    public static int? FindFirstPointWhereBalanceGoesNegative(int[] changes)
    {
        if (changes is null || changes.Length == 0)
        {
            return null;
        }

        int total = 0;

        foreach (int number in changes)
        {
            total += number;

            if (total < 0)
            {
                return total;
            }
        }

        return null;
    }

    public static int CountValidPaymentRecords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Count(counter => counter == ':') != 1)
            {
                continue;
            }

            int indexOfColon = strTrimmed.IndexOf(':');

            string beforeColon = strTrimmed.Substring(0, indexOfColon);
            string afterColon = strTrimmed.Substring(indexOfColon + 1);

            if (beforeColon.Length != 0 && afterColon.Length != 0)
            {
                if (int.TryParse(afterColon, out int value))
                {
                    if (value >= 0)
                    {
                        counter++;
                    }
                }
            }
        }

        return counter;
    }

    public static Dictionary<char, int> CountFirstLetterFrequency(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<char, int> newDict = [];
        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {

            char character = char.ToLower(str[0]);

            if (char.IsLetter(character))
            {
                if (newDict.TryGetValue(character, out int value))
                {
                    newDict[character] = value + 1;
                }
                else
                {
                    newDict[character] = 1;
                }
            }
        }

        return newDict;
    }

    public static bool AreAllScoresPassingWithLinq(int[] numbers) =>
    numbers is not null && numbers.Length != 0 && numbers.All(n => n >= 50);

    public static int SumValidPaymentAmountsAgain(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int total = 0;

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            if (strTrimmed.Count(counter => counter == ':') != 1)
            {
                continue;
            }

            int indexOfColon = strTrimmed.IndexOf(':');

            string beforeColon = strTrimmed.Substring(0, indexOfColon).Trim();
            string afterColon = strTrimmed.Substring(indexOfColon + 1).Trim();

            if (beforeColon.Length == 0 || afterColon.Length == 0)
            {
                continue;
            }

            if (int.TryParse(afterColon, out int value))
            {
                if (value >= 0)
                {
                    total += value;
                }
            }
        }

        return total;
    }
    public static void Main(string[] args)
    {
        // Sum Valid Payment Amounts Again
        Console.WriteLine(SumValidPaymentAmountsAgain("Paul:20, Sarah:35, Bob:abc") == 55);
        Console.WriteLine(SumValidPaymentAmountsAgain("Paul:10, :50, Tom:5") == 15);
        Console.WriteLine(SumValidPaymentAmountsAgain("BadRecord, Sam:-5, Amy:30") == 30);
        Console.WriteLine(SumValidPaymentAmountsAgain("Paul:10:20, Sarah:5") == 5);
        Console.WriteLine(SumValidPaymentAmountsAgain("Paul:0, Sarah:10") == 10);
        Console.WriteLine(SumValidPaymentAmountsAgain("Bad, AlsoBad") == 0);
        Console.WriteLine(SumValidPaymentAmountsAgain("") == 0);
        Console.WriteLine(SumValidPaymentAmountsAgain(null!) == 0);

        // Are All Scores Passing With Linq
        // Console.WriteLine(AreAllScoresPassingWithLinq([50, 60, 70]) == true);
        // Console.WriteLine(AreAllScoresPassingWithLinq([50, 40, 90]) == false);
        // Console.WriteLine(AreAllScoresPassingWithLinq([100]) == true);
        // Console.WriteLine(AreAllScoresPassingWithLinq(null!) == false);
        // Console.WriteLine(AreAllScoresPassingWithLinq([]) == false);

        // CountFirstLetterFrequency
        // Dictionary<char, int> lettersOne = CountFirstLetterFrequency("apple banana apricot");
        // Console.WriteLine(lettersOne['a'] == 2);
        // Console.WriteLine(lettersOne['b'] == 1);

        // Dictionary<char, int> lettersTwo = CountFirstLetterFrequency("Dog duck cat");
        // Console.WriteLine(lettersTwo['d'] == 2);
        // Console.WriteLine(lettersTwo['c'] == 1);

        // Dictionary<char, int> lettersThree = CountFirstLetterFrequency("123 apple !test");
        // Console.WriteLine(lettersThree['a'] == 1);
        // Console.WriteLine(lettersThree.ContainsKey('1') == false);
        // Console.WriteLine(lettersThree.ContainsKey('!') == false);

        // Dictionary<char, int> lettersFour = CountFirstLetterFrequency(null!);
        // Console.WriteLine(lettersFour.Count == 0);

        // Count Valid Payments Records
        // Console.WriteLine(CountValidPaymentRecords("Paul:20, Sarah:35, Bob:abc") == 2);
        // Console.WriteLine(CountValidPaymentRecords("Paul:10, :50, Tom:5") == 2);
        // Console.WriteLine(CountValidPaymentRecords("BadRecord, Sam:-5, Amy:30") == 1);
        // Console.WriteLine(CountValidPaymentRecords("Paul:10:20, Sarah:5") == 1);
        // Console.WriteLine(CountValidPaymentRecords("Paul:0, Sarah:10") == 2);
        // Console.WriteLine(CountValidPaymentRecords("Bad, AlsoBad") == 0);
        // Console.WriteLine(CountValidPaymentRecords("") == 0);
        // Console.WriteLine(CountValidPaymentRecords(" ") == 0);
        // Console.WriteLine(CountValidPaymentRecords(null!) == 0);

        // Find First Point Where Balance Goes negative 
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([10, -3, -8, 5]) == -1);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([5, -2, -1]) == null);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([-4, 10]) == -4);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative(null!) == null);
        // Console.WriteLine(FindFirstPointWhereBalanceGoesNegative([]) == null);

        // Normalise Name List
        // Console.WriteLine(NormaliseNameList(" Paul, SARAH , bob ") == "paul, sarah, bob");
        // Console.WriteLine(NormaliseNameList("Tom,, Amy, ") == "tom, amy");
        // Console.WriteLine(NormaliseNameList(" Derek ") == "derek");
        // Console.WriteLine(NormaliseNameList("") == "");
        // Console.WriteLine(NormaliseNameList(" ") == "");
        // Console.WriteLine(NormaliseNameList(null!) == "");

        // // Count Numbers Between Two Values
        // Console.WriteLine(CountNumbersBetweenTwoValues([1, 5, 10, 15, 20], 5, 15) == 3);
        // Console.WriteLine(CountNumbersBetweenTwoValues([5, 10, 15], 6, 14) == 1);
        // Console.WriteLine(CountNumbersBetweenTwoValues([-5, 0, 5], -5, 0) == 2);
        // Console.WriteLine(CountNumbersBetweenTwoValues([1, 2, 3], 10, 5) == 0);
        // Console.WriteLine(CountNumbersBetweenTwoValues(null!, 0, 10) == 0);
        // Console.WriteLine(CountNumbersBetweenTwoValues([], 0, 10) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
