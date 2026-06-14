using System.Collections.Generic;

public class Program
{
    // PMG TO DO: REFACTOR

    public static int CountNumbersLessThanTarget(int[] pInputValue, int pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int count = 0;

        foreach (int value in pInputValue)
        {
            if (value < pTarget)
            {
                count++;
            }
        }

        return count;
    }

    public static int SumPositiveNumbersRev2(int[] pInputValue)
    {
        int total = 0;

        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        foreach (int value in pInputValue)
        {
            if (value > 0)
            {
                total = total + value;
            }
        }

        return total;
    }

    public static int[] MergeArrays(int[] pInputValueOne, int[] pInputValueTwo)
    {
        if ((pInputValueOne == null || pInputValueOne.Length == 0)
        && (pInputValueTwo == null || pInputValueTwo.Length == 0))
        {
            return [];
        }
        else if (pInputValueOne == null || pInputValueOne.Length == 0)
        {
            return pInputValueTwo;
        }
        else if (pInputValueTwo == null || pInputValueTwo.Length == 0)
        {
            return pInputValueOne;
        }

        List<int> mergedList = [];

        foreach (int valueOne in pInputValueOne)
        {
            mergedList.Add(valueOne);
        }

        foreach (int valueTwo in pInputValueTwo)
        {
            mergedList.Add(valueTwo);
        }

        return mergedList.ToArray();


    }

    public static int FindLastIndexOfTarget(int[] pInputValueOne, int pTarget)
    {
        if (pInputValueOne == null || pInputValueOne.Length == 0)
        {
            return -1;
        }

        for (int counter = pInputValueOne.Length - 1; counter >= 0; counter--)
        {
            if (pInputValueOne[counter] == pTarget)
            {
                return counter;
            }
        }


        return -1;
    }

    public static int[] SplitPositiveAndNegativeNumbers(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        List<int> numberList = [];

        foreach (int value in pInputValue)
        {
            if (value > 0)
            {
                numberList.Add(value);
            }
        }

        foreach (int value in pInputValue)
        {
            if (value < 0)
            {
                numberList.Add(value);
            }
        }

        return numberList.ToArray();
    }

    public static int[] ReplaceTargetWithValue(int[] pInputValue, int target, int replacement)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        int[] newArray = new int[pInputValue.Length];

        for (int counter = 0; counter < pInputValue.Length; counter++)
        {
            if (pInputValue[counter] == target)
            {
                newArray[counter] = replacement;
            }
            else
            {
                newArray[counter] = pInputValue[counter];
            }
        }

        return newArray;
    }


    public static void Main(string[] args)
    {

        // New Challenge: Replace Target With Value
        Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 99 should return [1, 99, 5, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue(new int[] { 1, 0, 5, 0 }, 0, 99))}]");
        Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 0 should return [1, 0, 5, 0] => Answer: [{string.Join(", ", ReplaceTargetWithValue(new int[] { 1, 0, 5, 0 }, 0, 0))}]");
        Console.WriteLine($"[1, 5, 10, 5], target 5, replacement 99 should return [1, 99, 10, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([ 1, 5, 10, 5], 5, 99))}]");
        Console.WriteLine($"[3, 4, 5], target 9, replacement 0 should return [3, 4, 5] => Answer: [{string.Join(", ", ReplaceTargetWithValue([ 3, 4, 5 ], 9, 0))}]");
        Console.WriteLine($"[7], target 7, replacement 1 should return [1] => Answer: [{string.Join(", ", ReplaceTargetWithValue([ 7], 7, 1))}]");
        Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue([], 5, 99))}]");
        Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue(null!, 5, 99))}]");


        //  Split Positive And Negative Numbers
        // Return a new array with positive numbers first, then negative numbers. Ignore zero.
        Console.WriteLine($"[1, -2, 3, -4, 0] should return [1, 3, -2, -4] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([1, -2, 3, -4, 0]))}]");
        Console.WriteLine($"[-1, -2, 5] should return [5, -1, -2] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([-1, -2, 5]))}]");
        Console.WriteLine($"[0, 0] should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([0, 0]))}]");
        Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([1, 2, 3]))}]");
        Console.WriteLine($"[-1, -2, -3] should return [-1, -2, -3] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([-1, -2, -3]))}]");
        Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([]))}]");
        Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers(null!))}]");


        // Count Numbers Less Than Target
        //Console.WriteLine(CountNumbersLessThanTarget([1, 5, 10, 3], 4));
        //Console.WriteLine(CountNumbersLessThanTarget([10, 20, 30], 15));
        //Console.WriteLine(CountNumbersLessThanTarget([-5, -2, 0], 1));
        //Console.WriteLine(CountNumbersLessThanTarget([1, 2, 3], 0));
        //Console.WriteLine(CountNumbersLessThanTarget([], 4));
        //Console.WriteLine(CountNumbersLessThanTarget(null!, 4));

        // Sum Positive Numbers
        Console.WriteLine(SumPositiveNumbersRev2([1, 2, 4]));
        Console.WriteLine(SumPositiveNumbersRev2([0, 0, 0, 5]));
        Console.WriteLine(SumPositiveNumbersRev2([-1, -2, -3, 5]));
        Console.WriteLine(SumPositiveNumbersRev2([1]));
        Console.WriteLine(SumPositiveNumbersRev2([]));
        Console.WriteLine(SumPositiveNumbersRev2(null!));

        // Merge Arrays(Duplicates allowed)
        Console.WriteLine($"[1, 2], [3, 4] should return [1, 2, 3, 4] => Answer: [{string.Join(", ", MergeArrays([1, 2], [3, 4]))}]");
        Console.WriteLine($"[1, 2], [2, 3] should return [1, 2, 2, 3] => Answer: [{string.Join(", ", MergeArrays([1, 2], [2, 3]))}]");
        Console.WriteLine($"[], [1, 2] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([], [1, 2]))}]");
        Console.WriteLine($"[1, 2], [] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([1, 2], []))}]");
        Console.WriteLine($"null, [1, 2] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays(null!, [1, 2]))}]");
        Console.WriteLine($"[1, 2], null should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([1, 2], null!))}]");
        Console.WriteLine($"null, null should return [] => Answer: [{string.Join(", ", MergeArrays(null!, null!))}]");
        Console.WriteLine($"[], [] should return [] => Answer: [{string.Join(", ", MergeArrays([], []))}]");


        // Find Last Index of Target
        Console.WriteLine($"[1, 5, 10, 5], target 5 should return 3 => Answer: {FindLastIndexOfTarget([1, 5, 10, 5], 5)}");
        Console.WriteLine($"[3, 4, 5], target 9 should return -1 => Answer: {FindLastIndexOfTarget([3, 4, 5], 9)}");
        Console.WriteLine($"[7], target 7 should return 0 => Answer: {FindLastIndexOfTarget([7], 7)}");
        Console.WriteLine($"[5, 5, 5], target 5 should return 2 => Answer: {FindLastIndexOfTarget([5, 5, 5], 5)}");
        Console.WriteLine($"Empty array, target 1 should return -1 => Answer: {FindLastIndexOfTarget([], 1)}");
        Console.WriteLine($"Null, target 1 should return -1 => Answer: {FindLastIndexOfTarget(null!, 1)}");

    }
}
