public class Program
{
    public static int[] ClampNumbersToRange(int[] numbers, int min, int max)
    {
        if ((numbers is null || numbers.Length == 0) || min > max)
        {
            return [];
        }

        List<int> newList = [];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                newList.Add(max);
            }
            else if (number < min)
            {
                newList.Add(min);
            }
            else
            {
                newList.Add(number);
            }
        }

        return newList.ToArray();
    }

    public static void Main(string[] args)
    {
        // Clamp Numbers To Range
        int[] clampedOne = ClampNumbersToRange([-5, 3, 10, 20], 0, 10);
        Console.WriteLine(clampedOne.Length == 4);
        Console.WriteLine(clampedOne[0] == 0);
        Console.WriteLine(clampedOne[1] == 3);
        Console.WriteLine(clampedOne[2] == 10);
        Console.WriteLine(clampedOne[3] == 10);

        int[] clampedTwo = ClampNumbersToRange([1, 2, 3], 0, 5);
        Console.WriteLine(clampedTwo[0] == 1);
        Console.WriteLine(clampedTwo[1] == 2);
        Console.WriteLine(clampedTwo[2] == 3);
        Console.WriteLine(ClampNumbersToRange([1, 2, 3], 10, 5).Length == 0);
        Console.WriteLine(ClampNumbersToRange(null!, 0, 10).Length == 0);
        Console.WriteLine(ClampNumbersToRange([], 0, 10).Length == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
