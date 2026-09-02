using System.Text;

public class Program
{
    public static int CountNumbersWithinDistanceOfZero(int[] numbers, int distance)
    {
        if (numbers is null || numbers.Length == 0 ||
        distance < 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int digit in numbers)
        {
            if (Math.Abs(digit) <= distance)
            {
                counter++;
            }
        }

        return counter;
    }

    public static string ReplaceEverySecondCharacterWithStar(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var strBuilder = new StringBuilder();
        strBuilder.Append(input);

        // Spaces Count As Characters
        for (int outerIndex = 1; outerIndex <= input.Length - 1; outerIndex += 2)
        {
            strBuilder[outerIndex] = '*';
        }

        return strBuilder.ToString();

    }
    public static void Main(string[] args)
    {
        // Replace Every Second Character With Star 
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("abcdef") == "a*c*e*");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("hello") == "h*l*o");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("Paul") == "P*u*");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("a") == "a");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("") == "");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar(" ") == "");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar(null!) == "");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("ab cd") == "a* *d");
        Console.WriteLine(ReplaceEverySecondCharacterWithStar("hello world") == "h*l*o*w*r*d");

        // Warm Up: Count Numbers Within Distance Of Zero
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([-3, -1, 0, 2, 5], 2) == 3);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([-10, 4, 6], 5) == 1);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([1, -1, 2, -2], 1) == 2);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero(null!, 2) == 0);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([], 2) == 0);
        // Console.WriteLine(CountNumbersWithinDistanceOfZero([1, 2, 3], -1) == 0);


        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
