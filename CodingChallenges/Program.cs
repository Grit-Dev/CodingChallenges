
public class Program
{
    public static int CountSignChanges(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return 0;
        }

        int counter = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            int currentNumber = numbers[index];
            int nextNumber = numbers[index + 1];

            if (currentNumber == 0 || nextNumber == 0)
            {
                continue;
            }

            if (currentNumber > 0 && nextNumber < 0)
            {
                counter++;
            }
            else if (currentNumber < 0 && nextNumber > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string ConvertToSimpleTitleCase(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        return string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(name => char.ToUpper(name[0]) + name.Substring(1).ToLower()));
    }

    public static int? FindFirstThreeNumberTotalOverLimit(int[] numbers, int limit)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return null;
        }

        for (int index = 1; index < numbers.Length - 1; index++)
        {
            int total = numbers[index - 1] + numbers[index] + numbers[index + 1];

            if (total > limit)
            {
                return total;
            }
        }

        return null;
    }

    public static string[] GetWordsLongerThanPreviousWord(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        List<string> newList = [];

        string[] splitString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for(int index = 1; index <= splitString.Count() -1; index++)
        {
            if(splitString[index].Length > splitString[index -1].Length)
            {
                newList.Add(splitString[index]);
            }
        }

        return newList.ToArray();
    }
    public static void Main(string[] args)
    {
        // Get words Longer Than Previous Word
        string[] longerOne = GetWordsLongerThanPreviousWord("hi there paul coding");
        Console.WriteLine(longerOne.Length == 2);
        Console.WriteLine(longerOne[0] == "there");
        Console.WriteLine(longerOne[1] == "coding");

        string[] longerTwo = GetWordsLongerThanPreviousWord("one two three four");
        Console.WriteLine(longerTwo.Length == 1);
        Console.WriteLine(longerTwo[0] == "three");

        string[] longerThree = GetWordsLongerThanPreviousWord("a bb ccc dddd");
        Console.WriteLine(longerThree.Length == 3);
        Console.WriteLine(longerThree[0] == "bb");
        Console.WriteLine(longerThree[1] == "ccc");
        Console.WriteLine(longerThree[2] == "dddd");
        Console.WriteLine(GetWordsLongerThanPreviousWord("").Length == 0);
        Console.WriteLine(GetWordsLongerThanPreviousWord(" ").Length == 0);
        Console.WriteLine(GetWordsLongerThanPreviousWord(null).Length == 0);


        // Find First Three Number Total Over Limit
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit([2, 3, 6, 1], 10) == 11);
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit([1, 2, 3, 4], 20) == null);
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit([5, 5, 5], 10) == 15);
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit([-5, 10, 10], 10) == 15);
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit([1, 2], 10) == null);
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit(null!, 10) == null);
        Console.WriteLine(FindFirstThreeNumberTotalOverLimit([], 10) == null);

        // Convert To Simple Title Case
        // Console.WriteLine(ConvertToSimpleTitleCase("john SMITH codes") == "John Smith Codes");
        // Console.WriteLine(ConvertToSimpleTitleCase(" sarah CONNOR ") == "Sarah Connor");
        // Console.WriteLine(ConvertToSimpleTitleCase("a BIG day") == "A Big Day");
        // Console.WriteLine(ConvertToSimpleTitleCase("x") == "X");
        // Console.WriteLine(ConvertToSimpleTitleCase("") == "");
        // Console.WriteLine(ConvertToSimpleTitleCase(" ") == "");
        // Console.WriteLine(ConvertToSimpleTitleCase(null!) == "");

        // Count Sign Changes
        // Console.WriteLine(CountSignChanges([-1, 2, -3, 0, 4, -5]));
        // Console.WriteLine(CountSignChanges([1, 2, 3]) == 0);
        // Console.WriteLine(CountSignChanges([-1, -2, 3]) == 1);
        // Console.WriteLine(CountSignChanges([0, -1, 1, 0, -2]) == 1);
        // Console.WriteLine(CountSignChanges([7]) == 0);
        // Console.WriteLine(CountSignChanges(null!) == 0);
        // Console.WriteLine(CountSignChanges([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
