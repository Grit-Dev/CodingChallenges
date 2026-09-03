
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
        if(string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();
        string[] stringSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string str in stringSplit)
        {
            for(int innerIndex = str.Length -1; innerIndex >= 0; innerIndex--)
            {
                strBuilder.Append(str[innerIndex]);
            }

            strBuilder.Append(' ');
        }

        return strBuilder.ToString().Trim();

    }
    public static void Main(string[] args)
    {
        // Reverse Each Word
        Console.WriteLine(ReverseEachWord("hello world") == "olleh dlrow");
        Console.WriteLine(ReverseEachWord("Paul Codes") == "luaP sedoC");
        Console.WriteLine(ReverseEachWord(" one two ") == "eno owt");
        Console.WriteLine(ReverseEachWord("a") == "a");
        Console.WriteLine(ReverseEachWord("") == "");
        Console.WriteLine(ReverseEachWord(" ") == "");
        Console.WriteLine(ReverseEachWord(null!) == "");

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
