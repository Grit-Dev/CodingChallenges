using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    // PMG TO DO: REFACTOR
    public static int CountNonZero(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        foreach (int value in pInputValue)
        {
            if (value > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public static int[] RotateArrayToRight(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        int[] newArray = new int[pInputValue.Length];
        newArray[0] = pInputValue[pInputValue.Length - 1];

        for (int counter = 1; counter <= pInputValue.Length - 1; counter++)
        {
            newArray[counter] = pInputValue[counter - 1];
        }

        return newArray;
    }

    public static int[] MoveTargetToEnd(int[] pInputValue, int pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        List<int> newList = [];

        foreach (int value in pInputValue)
        {
            if (value != pTarget)
            {
                newList.Add(value);
            }
        }

        foreach (int value in pInputValue)
        {
            if (value == pTarget)
            {
                newList.Add(value);
            }
        }

        return newList.ToArray();
    }

    public static int MostFrequentNumberInArray(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int frequentHolderNumber = 0;
        int incrementor;
        int incrementorTotal = 0;

        // Exit early to save nested loop            
        if (pInputValue.Length == 1)
        {
            return pInputValue[0];
        }


        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            int value = pInputValue[counter];
            incrementor = 0;


            for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
            {
                if (value == pInputValue[counterTwo])
                {
                    incrementor++;
                }
            }

            if (incrementor > incrementorTotal)
            {
                incrementorTotal = incrementor;
                frequentHolderNumber = pInputValue[counter];
            }
        }

        return frequentHolderNumber;
    }

    public static int[] RotateArrayLeft(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        int[] newArray = new int[pInputValue.Length];
        newArray[pInputValue.Length - 1] = pInputValue[0];

        for (int counter = 0; counter < pInputValue.Length - 1; counter++)
        {
            newArray[counter] = pInputValue[counter + 1];
        }

        return newArray;
    }

    // 7 Remove First occurrence of target:
    // - Remove only the first matching target Value. 
    // Example: [1,5,10,5] Target: 5 => [1,10,5]
    public static int[] RemoveFirstOccurrence(int[] pInputValue, int pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        List<int> newList = [];
        int counter = 0;

        foreach (int value in pInputValue)
        {
            if (value == pTarget && counter == 0)
            {
                counter++;
            }
            else
            {
                newList.Add(value);
            }
        }

        return newList.ToArray();
    }

    public static int[] RemoveLastOccurrence(int[] pInputValue, int pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        List<int> newList = [];

        foreach (int value in pInputValue)
        {
            if (!newList.Contains(value))
            {
                newList.Add(value);
            }

        }

        return newList.ToArray();
    }

    public static int[] RemoveLastOccurrenceReverseForLoop(int[] pInputValue, int pTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        List<int> newList = [];
        int count = 0;

        for (int counter = pInputValue.Length - 1; counter >= 0; counter--)
        {
            if (pInputValue[counter] == pTarget && count == 0)
            {
                count++;
            }
            else
            {
                newList.Add(pInputValue[counter]);
            }
        }

        newList.Reverse();
        return newList.ToArray();
    }

    public static int FindSecondLargestNumberRevTwo(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int firstLargestNumber;
        int secondLargestNumber;

        if (pInputValue.Length == 1)
        {
            return pInputValue[0];
        }

        if (pInputValue[0] >= pInputValue[1])
        {
            firstLargestNumber = pInputValue[0];
            secondLargestNumber = pInputValue[1];
        }
        else
        {
            firstLargestNumber = pInputValue[1];
            secondLargestNumber = pInputValue[0];
        }


        for (int counter = 2; counter <= pInputValue.Length - 1; counter++)
        {
            int value = pInputValue[counter];

            if (value > firstLargestNumber)
            {
                secondLargestNumber = firstLargestNumber;
                firstLargestNumber = value;
            }
            else if (value > secondLargestNumber)
            {
                secondLargestNumber = value;
            }
        }


        return secondLargestNumber;
    }

    public static void Main(string[] args)
    {
        // 1. Count Non-Zero Numbers - Complete
        // - Return how many numbers are not zero

        // Console.WriteLine(CountNonZero([1, 0, 2, 0, 3])); // 3
        // Console.WriteLine(CountNonZero([0, 0, 0]));       // 0
        // Console.WriteLine(CountNonZero([1, 2, 3]));       // 3
        // Console.WriteLine(CountNonZero([]));               // 0

        // 2. Revision: Move Target to End 
        // - Move Target values within an array to the end of the array
        // Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3, 2, 4], 2))); // 1,3,4,2,2
        // Console.WriteLine(string.Join(",", MoveTargetToEnd([5, 1, 5, 2], 5)));    // 1,2,5,5
        // Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3], 9)));       // 1,2,3

        // 3. Revision: Find Second Largest Number 
        Console.WriteLine(FindSecondLargestNumberRevTwo([1, 2, 3, 4]));     // 3
        Console.WriteLine(FindSecondLargestNumberRevTwo([10, 5, 8, 20]));   // 10
        Console.WriteLine(FindSecondLargestNumberRevTwo([5, 5, 5, 5]));     // 5
        Console.WriteLine(FindSecondLargestNumberRevTwo([1]));              // 1
        Console.WriteLine(FindSecondLargestNumberRevTwo([5, 10])); // 5
        Console.WriteLine(FindSecondLargestNumberRevTwo([7, 7, 7, 7]));
        Console.WriteLine(FindSecondLargestNumberRevTwo([-10, -5, -20, -1])); // -5
        Console.WriteLine(FindSecondLargestNumberRevTwo([-10, 5, 3, 2])); // 3
        Console.WriteLine(FindSecondLargestNumberRevTwo([10, 10, 5, 3])); // 5
        Console.WriteLine(FindSecondLargestNumberRevTwo([]));



        // 4. New Challenge Find Most Frequent Number
        // - Return the number that appears the most 
        // 
        // Console.WriteLine(MostFrequentNumberInArray([1, 2, 2, 3, 2])); // 2
        // Console.WriteLine(MostFrequentNumberInArray([5, 5, 1, 1]));    // 5
        // Console.WriteLine(MostFrequentNumberInArray([9]));             // 9
        // Console.WriteLine(MostFrequentNumberInArray([]));               // 0


        // 5. New Challenge: Rotating Array Right By One - Complete
        // Move the Last number to the front - New Sized array 
        // Example [1,2,3,4] -> [4,1,2,3]
        // [10, 20, 30] -> [30, 10, 20]
        // Put last value at index 0; Then
        // copy the rest of the orginal values one positon to 
        // the right
        // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { 1, 2, 3, 4 }))); // 4,1,2,3
        // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { 10, 20, 30 }))); // 30,10,20
        // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { 1 })));          // 1
        // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { })));            // (empty)

        // 6. New Challenge(Optional): Rotate Array Left By One 
        // -Move the first number to the end
        // Example: [1,2,3,4,] = [2,3,4,1]
        // Copy Everything after index 0 one position left.
        // Put the original 1st value at the end
        // Console.WriteLine(string.Join(",", RotateArrayLeft([1, 2, 3, 4]))); // 2,3,4,1
        // Console.WriteLine(string.Join(",", RotateArrayLeft([10, 20, 30]))); // 20,30,10
        // Console.WriteLine(string.Join(",", RotateArrayLeft([1])));          // 1
        // Console.WriteLine(string.Join(",", RotateArrayLeft([])));            // (empty)

        // 7 Remove First occurrence of target:
        // - Remove only the first matching target Value. 
        // Example: [1,5,10,5] Target: 5 => [1,10,5]
        // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 1, 5, 10, 5 }, 5))); // 1,10,5
        // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 5, 1, 5, 5 }, 5)));  // 1,5,5
        // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
        // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 5 }, 5)));           // (empty)

        // 8 Remove last occurrence of target
        // - remove only the last matching target value
        // Example: [1,5,10,5] Target: 5 => [1,5,10]
        // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 1, 5, 10, 5 }, 5))); // 1,5,10
        // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 5, 1, 5, 5 }, 5)));  // 5,1,5
        // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
        // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 5 }, 5)));           // (empty)

        // 9 Remove Last occurrence - Messing around
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 1, 5, 10, 5 }, 5))); // 1,5,10
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 5, 1, 5, 5 }, 5)));  // 5,1,5
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
        // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 5 }, 5)));           // (empty)

    }
}
