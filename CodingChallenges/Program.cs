using System.Collections.Generic;

public class Program
{
    // PMG TO DO: REFACTOR
    public static void Main(string[] args)
    {

        //Minimum:
        //1.Count Numbers Less Than Target
        //2.Sum Positive Numbers
        //3.Merge Arrays

        //Good:
        //4.Find Last Index of Target
        //5.Replace Target With Value

        //Stretch:
        //6.Split Positive And Negative Numbers


        // Next Challenges:

        // Warm-up: Count numbers Less than Target:
        // [1, 5, 10, 3], target 4 → 2
        // [10, 20, 30], target 15 → 1
        // [-5, -2, 0], target - 3 → 1
        // [1, 2, 3], target 0 → 0
        // [] target 5 → 0
        // null target 5 → 0


        // Rev: Sum Positive Numbers: 
        //[1, -2, 3, 0, 5] → 9
        //[-1, -2] → 0
        //[10] → 10
        //[] → 0
        //null → 0


        // Rev: Merge Arrays
        // Key Note: Read Requirements
        //[1, 2], [3, 4] → [1, 2, 3, 4]
        //[1, 2], [2, 3] → [1, 2, 2, 3]
        //[], [1, 2] → [1, 2]
        //[1, 2], [] → [1, 2]
        //null, [1, 2] → [1, 2]
        //[1, 2], null → [1, 2]
        //null, null → [][1, 2], [3, 4] → [1, 2, 3, 4]
        //[1, 2], [2, 3] → [1, 2, 2, 3]
        //[], [1, 2] → [1, 2]
        //[1, 2], [] → [1, 2]
        //null, [1, 2] → [1, 2]
        //[1, 2], null → [1, 2]


        // New Challenge: Find Last Index of Target
        // Return the last index where the target appears. Return -1 if not found.
        //[1, 5, 10, 5], target 5 → 3
        //[3, 4, 5], target 9 → -1
        //[7], target 7 → 0
        //[5, 5, 5], target 5 → 2
        //[] target 1 → -1
        //null target 1 → -1


        // New Challenge: Replace Target With Value
        //[1, 5, 10, 5], target 5, replacement 99 → [1, 99, 10, 99]
        //[3, 4, 5], target 9, replacement 0 → [3, 4, 5]
        //[7], target 7, replacement 1 → [1]
        //[] → []
        //null → [][1, 5, 10, 5], target 5, replacement 99 → [1, 99, 10, 99]
        //[3, 4, 5], target 9, replacement 0 → [3, 4, 5]
        //[7], target 7, replacement 1 → [1]
        //[] → []
        //null → []

        // Stretch Goal: Split Positive And Negative Numbers
        //Return a new array with positive numbers first, then negative numbers. Ignore zero.
        //[1, -2, 3, -4, 0] → [1, 3, -2, -4]
        //[-1, -2, 5] → [5, -1, -2]
        //[0, 0] → []
        //[] → []
        //null → [][1, -2, 3, -4, 0] → [1, 3, -2, -4]
        //[-1, -2, 5] → [5, -1, -2]
        //[0, 0] → []
        //[] → []
        //null → []



    }
}
