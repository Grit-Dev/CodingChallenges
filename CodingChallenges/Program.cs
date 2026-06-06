using CodingChallenges.Challenge;

public class Program
{
    // PMG TO DO: REFACTOR
    public static int CountPositiveNumbers(int[] pInputValue)
    { 
        int counter = 0;

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        foreach (int value in pInputValue)
        {
            if (value > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountingWordsRev(string pInputValue)
    {
        int counter = 0;
        bool insiderWord = false;

        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        foreach (char character in pInputValue)
        {
            if (char.IsWhiteSpace(character) == false)
            {
                if (insiderWord == false)
                {
                    counter++;
                    insiderWord = true;
                }
            }
            else
            {
                insiderWord = false;
            }
        }

        return counter;
    }

    public static int[] TwoSumRev(int[] pInputValue, int pTarget)
    {

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [0, 0];
        }

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            for (int counterTwo = counter + 1; counterTwo <= pInputValue.Length - 1; counterTwo++)
            {
                if (pInputValue[counter] + pInputValue[counterTwo] == pTarget)
                {
                    return [counter, counterTwo];
                }
            }
        }

        return [0, 0];
    }


    public static void Main(string[] args)
    {
        var runChallengeSolution = new ChallengeSolutions();
        runChallengeSolution.RunAllChallengeSolutions();

        Console.WriteLine(CountPositiveNumbers([1, -2, 3, 0, 5]));
        Console.WriteLine(CountPositiveNumbers([-1, -2, -3]));
        Console.WriteLine(CountPositiveNumbers([0, 0, 0]));
        Console.WriteLine(CountPositiveNumbers([10]));
        Console.WriteLine(CountPositiveNumbers(null));
        Console.WriteLine(CountPositiveNumbers([]));

        Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 2, 7, 11, 15 }, 9))}]");
        Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 4, 5 }, 9))}]");
        Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 3, 2, 4 }, 6))}]");
        Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 3, 3 }, 6))}]");
        Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 1, 8, 10, 2 }, 10))}]");

        Console.WriteLine($"Should be 1. Result: {CountingWordsRev(" One ")}");
        Console.WriteLine($"Should be 1. Result: {CountingWordsRev("One ")}");
        Console.WriteLine($"Should be 2. Result: {CountingWordsRev(" Hello World ")}");
        Console.WriteLine($"Should be 6. Result: {CountingWordsRev(" I went for a walk today ")}");


    }
}
