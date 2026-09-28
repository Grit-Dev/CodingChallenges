using System;
using System.Text;

public class Program
{
    public static int[] GetNumbersAtOddIndexesReversed(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        List<int> newList = [];
        List<int> reverseList = [];

        for (int index = 1; index < numbers.Length; index += 2)
        {
            newList.Add(numbers[index]);
        }

        for (int index = newList.Count - 1; index >= 0; index--)
        {
            reverseList.Add(newList[index]);
        }

        return reverseList.ToArray();

    }

    public static string ReplaceVowelsWithStar(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        StringBuilder newStr = new StringBuilder();

       List<char> newCharList = ['a', 'e', 'i', 'o', 'u'];

        foreach (char character in input)
        {
            if (newCharList.Contains(char.ToLower(character)))
            {
                newStr.Append('*');
            }
            else
            {
                newStr.Append(character);
            }
        }

        return newStr.ToString();
    }

    public static void Main(string[] args)
    {

        // Replace Vowels With Star
        Console.WriteLine(ReplaceVowelsWithStar("Paul Codes") == "P**l C*d*s");
        Console.WriteLine(ReplaceVowelsWithStar("HELLO") == "H*LL*");
        Console.WriteLine(ReplaceVowelsWithStar("sky") == "sky");
        Console.WriteLine(ReplaceVowelsWithStar("a") == "*");
        Console.WriteLine(ReplaceVowelsWithStar("") == "");
        Console.WriteLine(ReplaceVowelsWithStar("   ") == "");
        Console.WriteLine(ReplaceVowelsWithStar(null!) == "");

        // Get Numbers At Odd Indexes Reversed
        //int[] oddReverseOne = GetNumbersAtOddIndexesReversed([10, 20, 30, 40, 50, 60]);
        //Console.WriteLine(oddReverseOne.Length == 3);
        //Console.WriteLine(oddReverseOne[0] == 60);
        //Console.WriteLine(oddReverseOne[1] == 40);
        //Console.WriteLine(oddReverseOne[2] == 20);

        //int[] oddReverseTwo = GetNumbersAtOddIndexesReversed([1, 2, 3]);
        //Console.WriteLine(oddReverseTwo.Length == 1);
        //Console.WriteLine(oddReverseTwo[0] == 2);
        //Console.WriteLine(GetNumbersAtOddIndexesReversed([7]).Length == 0);
        //Console.WriteLine(GetNumbersAtOddIndexesReversed(null!).Length == 0);
        //Console.WriteLine(GetNumbersAtOddIndexesReversed([]).Length == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
