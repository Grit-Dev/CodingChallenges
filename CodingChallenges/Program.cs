public class Program
{
    public static int CountNumbersDivisibleByTwoButNotThree(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int number in numbers)
        {
            if (number != 0 && number % 2 == 0 && number % 3 != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string RemoveShortWordsAndLowercase(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        return string.Join(' ', input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Where(ss => ss.Length >= 4)
        .Select(ss => ss.ToLower()));
    }


    public static int CountTimesRunningTotalIsPositive(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;

            if (total > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int? FindLastPositiveNumber(int[] numbers) =>
    numbers is null || numbers.Length == 0 ? null :
    numbers.Where(n => n > 0)
    .Cast<int?>()
    .LastOrDefault();

    public static Dictionary<char, int> CountWordsByLastLetter(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        Dictionary<char, int> newDict = [];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            char charLowered = char.ToLower(str[str.Length - 1]);

            if (char.IsLetter(charLowered))
            {
                if (newDict.TryGetValue(charLowered, out int value))
                {
                    newDict[charLowered] = value + 1;
                }
                else
                {
                    newDict[charLowered] = 1;
                }
            }
        }

        return newDict;
    }

    

    public static void Main(string[] args)
    {
        // Count Words By Last Letter
        // Dictionary<char, int> lastLettersOne = CountWordsByLastLetter("coding testing cat");
        // Console.WriteLine(lastLettersOne['g'] == 2);
        // Console.WriteLine(lastLettersOne['t'] == 1);

        // Dictionary<char, int> lastLettersTwo = CountWordsByLastLetter("Dog frog CAT");
        // Console.WriteLine(lastLettersTwo['g'] == 2);
        // Console.WriteLine(lastLettersTwo['t'] == 1);

        // Dictionary<char, int> lastLettersThree = CountWordsByLastLetter("hello! apple 123");
        // Console.WriteLine(lastLettersThree['e'] == 1);
        // Console.WriteLine(lastLettersThree.ContainsKey('!') == false);
        // Console.WriteLine(lastLettersThree.ContainsKey('3') == false);

        // Dictionary<char, int> lastLettersFour = CountWordsByLastLetter(null!);
        // Console.WriteLine(lastLettersFour.Count == 0);

        // Find Last Positive Number
        // Console.WriteLine(FindLastPositiveNumber([-1, 5, 0, 9, -2]) == 9);
        // Console.WriteLine(FindLastPositiveNumber([-5, 0, -1]) == null);
        // Console.WriteLine(FindLastPositiveNumber([7]) == 7);
        // Console.WriteLine(FindLastPositiveNumber([1, 2, 3]) == 3);
        // Console.WriteLine(FindLastPositiveNumber(null!) == null);
        // Console.WriteLine(FindLastPositiveNumber([]) == null);

        // Count Times Running Total Is Positive
        // Console.WriteLine(CountTimesRunningTotalIsPositive([3, -1, -5, 10]) == 3);
        // Console.WriteLine(CountTimesRunningTotalIsPositive([-5, 2, 2]) == 0);
        // Console.WriteLine(CountTimesRunningTotalIsPositive([1, 1, 1]) == 3);
        // Console.WriteLine(CountTimesRunningTotalIsPositive([5, -5, 1]) == 2);
        // Console.WriteLine(CountTimesRunningTotalIsPositive(null!) == 0);
        // Console.WriteLine(CountTimesRunningTotalIsPositive([]) == 0);

        // Remove Short Words And Lowercase
        // Console.WriteLine(RemoveShortWordsAndLowercase("Hi Paul is Coding Today")  == "paul coding today");
        // Console.WriteLine(RemoveShortWordsAndLowercase("a big red dragon") == "dragon");
        // Console.WriteLine(RemoveShortWordsAndLowercase("to be or no") == "");
        // Console.WriteLine(RemoveShortWordsAndLowercase(" HELLO world ") == "hello world");
        // Console.WriteLine(RemoveShortWordsAndLowercase("") == "");
        // Console.WriteLine(RemoveShortWordsAndLowercase(" ") == "");
        // Console.WriteLine(RemoveShortWordsAndLowercase(null!) == "");

        // Count Numbers Divisible By Two But Not Three
        // Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([2, 3, 4, 6, 8, 9, 12]) == 3);
        // Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([6, 12, 18]) == 0);
        // Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([0, 2, 4]) == 2);
        // Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([1, 3, 5]) == 0);
        // Console.WriteLine(CountNumbersDivisibleByTwoButNotThree(null!) == 0);
        // Console.WriteLine(CountNumbersDivisibleByTwoButNotThree([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
