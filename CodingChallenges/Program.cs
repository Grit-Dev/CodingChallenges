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

    public static void Main(string[] args)
    {
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

        //Rotate Array left by one:
        Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([1, 2, 3, 4]))); // 2,3,4,1
        Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([10, 20, 30]))); // 20,30,10
        Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([1])));          // 1
        Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([])));            // (empty)

    }
}
