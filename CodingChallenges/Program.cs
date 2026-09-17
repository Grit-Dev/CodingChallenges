public class Program
{
    public static int? FindFirstGapGreaterThanThree(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return null;
        }

        const int biggestgapBetweenNumbers = 3;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            int total = Math.Abs(numbers[index] - numbers[index - 1]);

            if (total > biggestgapBetweenNumbers)
            {
                return total;
            }
        }

        return null;
    }

    public static int CountDirectionChanges(int[] numbers)
    {
        if (numbers is null || numbers.Length < 3)
        {
            return 0;
        }

        bool isGoingUp = false;
        bool isGoingDown = false;
        int counter = 0;

        for (int index = 1; index <= numbers.Length - 1; index++)
        {
            if (numbers[index - 1] < numbers[index])
            {
                if (isGoingDown)
                {
                    counter++;
                }

                isGoingUp = true;
                isGoingDown = false;
            }
            else if (numbers[index - 1] > numbers[index])
            {
                if (isGoingUp)
                {
                    counter++;
                }

                isGoingDown = true;
                isGoingUp = false;

            }
            else
            {
                continue;
            }
        }

        return counter;
    }

    public static void Main(string[] args)
    {
        // Count Direction Changes
        Console.WriteLine(CountDirectionChanges([1, 3, 5, 4, 2, 6]) == 2);
        Console.WriteLine(CountDirectionChanges([1, 2, 3, 4]) == 0);
        Console.WriteLine(CountDirectionChanges([4, 3, 2, 1]) == 0);
        Console.WriteLine(CountDirectionChanges([1, 3, 1, 3, 1]) == 3);
        Console.WriteLine(CountDirectionChanges([]) == 0);
        Console.WriteLine(CountDirectionChanges(null!) == 0);

        // Find The First Gap Greater Than Three
        // Console.WriteLine(FindFirstGapGreaterThanThree([5, 6, 10, 11]) == 4);
        // Console.WriteLine(FindFirstGapGreaterThanThree([1, 2, 3, 4]) == null);
        // Console.WriteLine(FindFirstGapGreaterThanThree([10, 5]) == 5);
        // Console.WriteLine(FindFirstGapGreaterThanThree([-1, -8]) == 7);
        // Console.WriteLine(FindFirstGapGreaterThanThree(null!) == null);
        // Console.WriteLine(FindFirstGapGreaterThanThree([]) == null);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
