using CodingChallenges.Challenge;
using System.Diagnostics.Metrics;

public class Program
{
    // PMG TO DO: REFACTOR
    public static int CountNegativeNumbers(int[] pInputValue)
    {
        int counter = 0;

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        foreach (int value in pInputValue)
        {
            if (value < 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static char FindFirstNonRepeatingCharacterRev(string pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return '_';
        }

        pInputValue = pInputValue.ToLower().Trim();

        for (int counter = 0; counter < pInputValue.Length; counter++)
        {
            int charCounter = 0;

            for (int counterTwo = 0; counterTwo < pInputValue.Length; counterTwo++)
            {
                if (pInputValue[counter] == pInputValue[counterTwo])
                {
                    charCounter++;
                }
            }

            if (charCounter == 1)
            {
                return pInputValue[counter];
            }
        }

        return '_';
    }

    public static int[] TwoSumRevision(int[] pInputValue, int pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [0, 0];
        }

        for (int counter = 0; counter < pInputValue.Length; counter++)
        {
            for (int counterTwo = counter + 1; counterTwo < pInputValue.Length; counterTwo++)
            {
                if (pInputValue[counter] + pInputValue[counterTwo] == pTarget)
                {
                    return [counter, counterTwo];
                }
            }
        }

        return [0, 0];
    }

    public static int FindMissingNumber(int[] pInputValue)
    {
        int expectedNumber = 1;

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        for (int counter = 0; counter <= pInputValue.Length -1; counter++)
        {
            if (pInputValue[counter] != expectedNumber)
            {
                return expectedNumber;
            }

            expectedNumber++;
        }

        return expectedNumber;
    }

    public static int[] RemoveDuplicateNumbers(int[] pInputValue)
    {
        var list = new List<int>();

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        foreach (int number in pInputValue)
        {
            if (!list.Contains(number))
            {
                list.Add(number);
            }
        }

        return list.ToArray();
    }

    public static void Main(string[] args)
    {

        // Remove Duplicate numbers:
        Console.WriteLine($"[1, 2, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 1, 2, 2, 3 }))}]");
        Console.WriteLine($"[5, 5, 5] should return [5] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 5, 5, 5 }))}]");
        Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 1, 2, 3 }))}]");
        Console.WriteLine($"[4, 1, 4, 2, 1] should return [4, 1, 2] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 4, 1, 4, 2, 1 }))}]");
        Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { }))}]");
        Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(null))}]");


        // Find missing number: You are given numbers from 1 to n, but one number is missing.
        //Console.WriteLine($"[1, 2, 4, 5] should return 3 => Answer: {FindMissingNumber([1, 2, 4, 5])}");
        //Console.WriteLine($"[1, 3, 4, 5] should return 2 => Answer: {FindMissingNumber([1, 3, 4, 5])}");
        //Console.WriteLine($"[2, 3, 4, 5] should return 1 => Answer: {FindMissingNumber([2, 3, 4, 5])}");
        //Console.WriteLine($"[1, 2, 3, 4] should return 5 => Answer: {FindMissingNumber([1, 2, 3, 4])}");
        //Console.WriteLine($"[1, 2, 3, 5, 6] should return 4 => Answer: {FindMissingNumber([1, 2, 3, 5, 6])}");
        //Console.WriteLine($"Empty array should return 0 => Answer: {FindMissingNumber([])}");
        //Console.WriteLine($"Null should return 0 => Answer: {FindMissingNumber(null)}");

        // Two Sum Revision:
        //Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 2, 7, 11, 15 }, 9))}]");
        //Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 4, 5 }, 9))}]");
        //Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 3, 2, 4 }, 6))}]");
        //Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 3, 3 }, 6))}]");
        //Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 1, 8, 10, 2 }, 10))}]");


        //// Find first Non Repeating Character:
        //Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacterRev("swiss")}");
        //Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacterRev("hello")}");
        //Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacterRev("aabbc")}");
        //Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacterRev("aabb")}");
        //Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacterRev("")}");
        //Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacterRev(null)}");
        //Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacterRev("Cyberpunk")}");

        //// Count Negative Numbers: 
        //Console.WriteLine(CountNegativeNumbers([1, -2, 3, -4, 5]));
        //Console.WriteLine(CountNegativeNumbers([-1, -2, -3]));
        //Console.WriteLine(CountNegativeNumbers([0, 0, 0]));
        //Console.WriteLine(CountNegativeNumbers([10]));
        //Console.WriteLine(CountNegativeNumbers([]));
        //Console.WriteLine(CountNegativeNumbers(null));
    }
}
