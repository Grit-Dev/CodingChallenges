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

    public static int[] GetTotalsOfGroupsOfThree(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        List<int> totals = [];

        for (int index = 0; index < numbers.Length; index += 3)
        {
            int total = 0;

            for (int i = index; i < index + 3 && i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            totals.Add(total);
        }

        return totals.ToArray();
    }

    public static string[] CreateInitialsFromNameList(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        string[] rawNames = input.Split(',');

        List<string> initialsList = [];

        foreach (string raw in rawNames)
        {
            string trimmed = raw.Trim();

            if (trimmed.Length == 0)
            {
                continue;
            }

            string[] parts = trimmed.Split(' ');

            StringBuilder initials = new StringBuilder();

            foreach (string part in parts)
            {
                string trimmedPart = part.Trim();

                if (trimmedPart.Length == 0)
                {
                    continue;
                }

                initials.Append(char.ToUpper(trimmedPart[0]));
            }

            if (initials.Length > 0)
            {
                initialsList.Add(initials.ToString());
            }
        }

        return initialsList.ToArray();
    }

    public static void Main(string[] args)
    {

        // Create Initials From Name List
        string[] initialsOne = CreateInitialsFromNameList("Paul McGinley, Sarah Connor");
        Console.WriteLine(initialsOne.Length == 2);
        Console.WriteLine(initialsOne[0] == "PM");
        Console.WriteLine(initialsOne[1] == "SC");

        string[] initialsTwo = CreateInitialsFromNameList(" john  smith , , amy ");
        Console.WriteLine(initialsTwo.Length == 2);
        Console.WriteLine(initialsTwo[0] == "JS");
        Console.WriteLine(initialsTwo[1] == "A");
        Console.WriteLine(CreateInitialsFromNameList("").Length == 0);
        Console.WriteLine(CreateInitialsFromNameList("   ").Length == 0);
        Console.WriteLine(CreateInitialsFromNameList(null!).Length == 0);

        // Get Totals Of Groups Of Three
        //int[] groupTotalsOne = GetTotalsOfGroupsOfThree([1, 2, 3, 4, 5, 6, 7]);
        //Console.WriteLine(groupTotalsOne.Length == 3);
        //Console.WriteLine(groupTotalsOne[0] == 6);
        //Console.WriteLine(groupTotalsOne[1] == 15);
        //Console.WriteLine(groupTotalsOne[2] == 7);

        //int[] groupTotalsTwo = GetTotalsOfGroupsOfThree([10, -5, 3]);
        //Console.WriteLine(groupTotalsTwo.Length == 1);
        //Console.WriteLine(groupTotalsTwo[0] == 8);

        //int[] groupTotalsThree = GetTotalsOfGroupsOfThree([5, 5, 5, 5]);
        //Console.WriteLine(groupTotalsThree.Length == 2);
        //Console.WriteLine(groupTotalsThree[0] == 15);
        //Console.WriteLine(groupTotalsThree[1] == 5);
        //Console.WriteLine(GetTotalsOfGroupsOfThree(null!).Length == 0);
        //Console.WriteLine(GetTotalsOfGroupsOfThree([]).Length == 0);

        // Replace Vowels With Star
        //Console.WriteLine(ReplaceVowelsWithStar("Paul Codes") == "P**l C*d*s");
        //Console.WriteLine(ReplaceVowelsWithStar("HELLO") == "H*LL*");
        //Console.WriteLine(ReplaceVowelsWithStar("sky") == "sky");
        //Console.WriteLine(ReplaceVowelsWithStar("a") == "*");
        //Console.WriteLine(ReplaceVowelsWithStar("") == "");
        //Console.WriteLine(ReplaceVowelsWithStar("   ") == "");
        //Console.WriteLine(ReplaceVowelsWithStar(null!) == "");

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
