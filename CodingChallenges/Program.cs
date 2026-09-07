
using System.Text;

public class Program
{
    public static int CountNumbersWithSameParityAsTheirIndex(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int outerIndex = 0; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] % 2 == 0 && outerIndex % 2 == 0)
            {
                counter++;
            }
            else if (numbers[outerIndex] % 2 != 0 && outerIndex % 2 != 0)
            {
                counter++;
            }

        }

        return counter;
    }

    public static string MaskMiddleCharacters(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        if (input.Length <= 2)
        {
            return input;
        }

        return input[0] + new string('*', input.Length - 2) + input[input.Length - 1];
    }
    public static void Main(string[] args)
    {
        //Mask Middle Character
        Console.WriteLine(MaskMiddleCharacters("Paul") == "P**l");
        Console.WriteLine(MaskMiddleCharacters("coding") == "c****g");
        Console.WriteLine(MaskMiddleCharacters("ab") == "ab");
        Console.WriteLine(MaskMiddleCharacters("a") == "a");
        Console.WriteLine(MaskMiddleCharacters("") == "");
        Console.WriteLine(MaskMiddleCharacters(" ") == "");
        Console.WriteLine(MaskMiddleCharacters(null!) == "");

        // Count Numbers With Same Parity As Their Index
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([2, 3, 4, 7]) == 4);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([1, 2, 3, 4]) == 0);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([0, 5, 8, 10]) == 3);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex(null!) == 0);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
