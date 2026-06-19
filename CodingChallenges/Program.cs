public class Program
{
    public static int CountNonZerosWarmUp(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int count = 0;

        foreach (int value in pInputValue)
        {
            if (value != 0)
            {
                count++;
            }
        }

        return count;
    }

    public static int[] RotateArrayRightByOne(int[] pInputValue)
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

    public static int[] RotateArrayLeftWarmUp(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return [];
        }

        var newArray = new int[pInputValue.Length];
        newArray[pInputValue.Length - 1] = pInputValue[0];

        for (int counter = 0; counter < pInputValue.Length -1; counter++)
        {
            newArray[counter] = pInputValue[counter +1];
        }

        return newArray;
    }

    public static int MostFrequentNumberInArrayRevision(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        };

        int mostFrequentNumber = 0;

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {

            int count = 0;
            int value = pInputValue[counter];

            for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
            {
                if (value == pInputValue[counterTwo])
                {
                    count++;
                }
            }

            if (count > mostFrequentNumber)
            {
                mostFrequentNumber = value;
            }

        }

        return mostFrequentNumber;
    }

    public static int[] RemoveNegativeNumbers(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return []; 
        }

        List<int> newList = [];

        foreach (int counter in pInputValue)
        {
            if (counter >= 0)
            {
                newList.Add(counter);
            }
        }

        return newList.ToArray();
    }

    public static int FindSecondLargestDistinctNumber(int[] pInputValue)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return -1;
        }

        int firstLargestnumber = int.MinValue;
        int secondLargestnumber = int.MinValue;

        for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        {
            int value = pInputValue[counter];

            if (value > firstLargestnumber)
            {
                secondLargestnumber = firstLargestnumber;
                firstLargestnumber = value;
            }
            else if (value > secondLargestnumber && value != firstLargestnumber)
            {
                secondLargestnumber = value;
            }
        }

        if (secondLargestnumber == int.MinValue)
        {
            return -1;
        }

        return secondLargestnumber;
    }

    public static int FindFirstNumberGreaterThanTarget(int[] pInputValue, int pInputTarget)
    {
        if (pInputValue == null || pInputValue.Length == 0)
        {
            return 0;
        }

        int threshold = 0;
        int targetedValue = 0;

        foreach (int value in pInputValue)
        {
            if (value > pInputTarget)
            {
                return value;
            }
        }

        return 0;
    }


    public static void Main(string[] args)
    {

        // Find Fist Number Greater Than Target
        Console.WriteLine($"[1, 5, 10, 3], target 4 should return 5 => Answer: {FindFirstNumberGreaterThanTarget([1, 5, 10, 3], 4)}");
        Console.WriteLine($"[1, 2, 3], target 10 should return 0 => Answer: {FindFirstNumberGreaterThanTarget([1, 2, 3], 10)}");
        Console.WriteLine($"[-5, -2, 0], target -3 should return -2 => Answer: {FindFirstNumberGreaterThanTarget([-5, -2, 0], -3)}");
        Console.WriteLine($"[7], target 5 should return 7 => Answer: {FindFirstNumberGreaterThanTarget([7], 5)}");
        Console.WriteLine($"Empty array, target 5 should return 0 => Answer: {FindFirstNumberGreaterThanTarget([], 5)}");
        Console.WriteLine($"Null, target 5 should return 0 => Answer: {FindFirstNumberGreaterThanTarget(null!, 5)}");

        // Count Non Zeros: 
        //Console.WriteLine(CountNonZerosWarmUp([1, 0, 2, 0, 3])); // 3
        //Console.WriteLine(CountNonZerosWarmUp([0, 0, 0]));       // 0
        //Console.WriteLine(CountNonZerosWarmUp([1, 2, 3]));       // 3
        //Console.WriteLine(CountNonZerosWarmUp([]));               // 0

        // Rotate Array right by one:
        //Console.WriteLine(string.Join(",", RotateArrayRightByOne([1, 2, 3, 4]))); // 4,1,2,3
        //Console.WriteLine(string.Join(",", RotateArrayRightByOne([10, 20, 30]))); // 30,10,20
        //Console.WriteLine(string.Join(",", RotateArrayRightByOne([1])));          // 1
        //Console.WriteLine(string.Join(",", RotateArrayRightByOne([])));            // (empty)

        // Rotate Array left by one:
        //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([1, 2, 3, 4]))); // 2,3,4,1
        //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([10, 20, 30]))); // 20,30,10
        //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([1])));          // 1
        //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([])));            // (empty)

        // Most Frequent Number:
        //Console.WriteLine(MostFrequentNumberInArrayRevision([1, 2, 2, 3, 2])); // 2
        //Console.WriteLine(MostFrequentNumberInArrayRevision([5, 5, 1, 1]));    // 5
        //Console.WriteLine(MostFrequentNumberInArrayRevision([9]));             // 9
        //Console.WriteLine(MostFrequentNumberInArrayRevision([]));               // 0

        // Count Negative Numbers:
        //Console.WriteLine($"[1, -2, 3, -4] should return [1, 3] => Answer: [{string.Join(", ", RemoveNegativeNumbers([1, -2, 3, -4]))}]");
        //Console.WriteLine($"[-1, -2, -3] should return [] => Answer: [{string.Join(", ", RemoveNegativeNumbers([-1, -2, -3]))}]");
        //Console.WriteLine($"[0, 1, 2] should return [0, 1, 2] => Answer: [{string.Join(", ", RemoveNegativeNumbers([0, 1, 2]))}]");
        //Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", RemoveNegativeNumbers([]))}]");
        //Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", RemoveNegativeNumbers(null!))}]");

        // Second largest Number Distinct
        //Console.WriteLine($"[10, 10, 5, 3] should return 5 => Answer: {FindSecondLargestDistinctNumber([10, 10, 5, 3])}");
        //Console.WriteLine($"[1, 5, 3, 9, 2] should return 5 => Answer: {FindSecondLargestDistinctNumber([1, 5, 3, 9, 2])}");
        //Console.WriteLine($"[30, 20, 10] should return 20 => Answer: {FindSecondLargestDistinctNumber([30, 20, 10])}");
        //Console.WriteLine($"[-5, -2, -1, -10] should return -2 => Answer: {FindSecondLargestDistinctNumber([-5, -2, -1, -10])}");
        //Console.WriteLine($"[10, 10] should return -1 => Answer: {FindSecondLargestDistinctNumber([10, 10])}");
        //Console.WriteLine($"[5, 5, 5] should return -1 => Answer: {FindSecondLargestDistinctNumber([5, 5, 5])}");
        //Console.WriteLine($"[100] should return -1 => Answer: {FindSecondLargestDistinctNumber([100])}");
        //Console.WriteLine($"Empty array should return -1 => Answer: {FindSecondLargestDistinctNumber([])}");
        //Console.WriteLine($"Null should return -1 => Answer: {FindSecondLargestDistinctNumber(null!)}");










    }
}
