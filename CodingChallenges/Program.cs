using System.Reflection.Metadata.Ecma335;
using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static int?  FindFirstDuplicateNumber(int [] numbers)
    {
        if(numbers == null || numbers.Length < 2)
        {
            return null;
        }

        List<int> newList = [];

        foreach(int value in numbers)
        {
            if(!newList.Contains(value))
            {
                newList.Add(value);
            }
            else
            {
                return value;
            }
        }

        return null;
    }

    public static List<int> ParseValidIdsFromCsv(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        string [] stringSplit = input.Split([','], StringSplitOptions.RemoveEmptyEntries);
        List<int> newFormattedList = [];

        foreach(string text in stringSplit)
        {
            if(int.TryParse(text.Trim(), out int result))
            {
                if(result > 0)
                {
                    newFormattedList.Add(result);
                }
            }
        }

        return newFormattedList;

    }

    public static List<int> RemoveDuplicateIdsPreservingOrder(List<int> ids)
    {
        if(ids == null)
        {
            return [];
        }

        List<int> newListOfIds = [];

        foreach(int values in ids)
        {
            if(!newListOfIds.Contains(values))
            {
                newListOfIds.Add(values);
            }
        }

        return newListOfIds;
    }
    public static void Main(string[] args)
    {   
        // REMOVE DUPLICATE IDS PRESERVING ORDER
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([1, 2, 2, 3, 1]))}]"); // [1, 2, 3]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([5, 5, 5]))}]"); // [5]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([1, 2, 3]))}]"); // [1, 2, 3]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([]))}]"); // []
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder(null!))}]"); // []
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([1]))}]"); // [1]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([1, 1]))}]"); // [1]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([1, 2, 1, 2, 1, 2]))}]"); // [1, 2]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([10, 20, 30, 10, 20, 30]))}]"); // [10, 20, 30]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([-1, -1, 0, 0, 1, 1]))}]"); // [-1, 0, 1]
        Console.WriteLine($"[{string.Join(", ", RemoveDuplicateIdsPreservingOrder([3, 2, 1, 3, 2, 1]))}]"); // [3, 2, 1]

        // PARSE VALID IDS FROM CSV
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv("1,2,3"))}]"); // [1, 2, 3]
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv("10, -5, 3, hello"))}]"); // [10, 3]
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv("0, -1, abc"))}]"); // []
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv(" 4, 6 , test, 8 "))}]"); // [4, 6, 8]
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv(null!))}]"); // []
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv(""))}]"); // []
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv(" "))}]"); // []
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv("5"))}]"); // [5]
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv("0"))}]"); // []
        Console.WriteLine($"[{string.Join(", ", ParseValidIdsFromCsv("-10"))}]"); // []

        // FIND FIRST DUPLICATE NUMBER
        Console.WriteLine(FindFirstDuplicateNumber([1, 2, 3, 2, 4])); // 2
        Console.WriteLine(FindFirstDuplicateNumber([5, 1, 5, 2, 1])); // 5
        Console.WriteLine(FindFirstDuplicateNumber([1, 2, 3] )); // null
        Console.WriteLine(FindFirstDuplicateNumber([7, 7, 1] )); // 7
        Console.WriteLine(FindFirstDuplicateNumber([] )); // null

        // CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();
    }
    /*



        ============================================================
        CODING CHALLENGE 3:
        REMOVE DUPLICATE IDS PRESERVING ORDER
        ============================================================

        Create this method:

        public static List<int> RemoveDuplicateIdsPreservingOrder(List<int> ids)

        Requirements:

        * Return an empty list if ids is null.
        * Keep the first appearance of each ID.
        * Remove later duplicates.
        * Preserve original order.
        * You may use List<int>.Contains.
        * No LINQ.
        * No Dictionary.
        * No HashSet.

        Examples:

        [1, 2, 2, 3, 1] -> [1, 2, 3]

        [5, 5, 5] -> [5]

        [1, 2, 3] -> [1, 2, 3]

        [] -> []


        ============================================================
        LEARNING FOCUS:
        REQUEST OBJECTS / DTO-STYLE THINKING
        ============================================================

        So far, your methods mostly take separate parameters:

        BuyCardWithResult(player, cardName)

        In APIs, data often arrives as an object.

        Example:

        public class BuyCardRequest
        {
            public string PlayerName { get; set; }
            public string CardName { get; set; }
        }

        This is similar to a DTO.

        DTO means Data Transfer Object.

        It carries data into or out of a method, service, or API endpoint.

        Today we are still in plain C#.
        But this is preparing you for controller/service/API thinking.


        ============================================================
        OOP CHALLENGE 4:
        CREATE REQUEST CLASSES
        ============================================================

        Create this class in Shared:

        File name:

        BuyCardRequest.cs

        Class:

        public class BuyCardRequest

        Properties:

        public string PlayerName { get; set; }
        public string CardName { get; set; }

        Requirements:

        * Both strings should default to string.Empty.
        * Add a default constructor.
        * Add a constructor with both values.


        Then create this class in Shared:

        File name:

        SellCardRequest.cs

        Class:

        public class SellCardRequest

        Properties:

        public string PlayerName { get; set; }
        public string CardName { get; set; }

        Requirements:

        * Both strings should default to string.Empty.
        * Add a default constructor.
        * Add a constructor with both values.


        ============================================================
        OOP CHALLENGE 5:
        BUY CARD WITH REQUEST
        ============================================================

        Add this method to CardShop:

        public CardShopResult BuyCardWithRequest(
            Player? player,
            BuyCardRequest? request
        )

        Requirements:

        * Return failure result if player is null:
            Success: false
            Message: "Player is required"
            CardName: ""
            Amount: 0

        * Return failure result if request is null:
            Success: false
            Message: "Request is required"
            CardName: ""
            Amount: 0

        * Return failure result if request.PlayerName is null, empty, or whitespace:
            Success: false
            Message: "Player name is required"
            CardName: ""
            Amount: 0

        * Return failure result if request.PlayerName does not match player.Name:
            Success: false
            Message: "Player mismatch"
            CardName: request.CardName
            Amount: 0

        * Return failure result if request.CardName is null, empty, or whitespace:
            Success: false
            Message: "Card name is required"
            CardName: ""
            Amount: 0

        * After validation, reuse your existing method:

            BuyCardWithResult(player, request.CardName)

        * Do not duplicate all the purchase logic again.
        * No LINQ.


        Example:

        Player name:

        "V"

        Request:

        PlayerName = "V"
        CardName = "Johnny Silverhand"

        Expected:

        Calls BuyCardWithResult(player, "Johnny Silverhand")


        ============================================================
        OOP CHALLENGE 6:
        SELL CARD WITH REQUEST
        ============================================================

        Add this method to CardShop:

        public CardShopResult BuyCardFromPlayerWithRequest(
            Player? player,
            SellCardRequest? request
        )

        Requirements:

        * Return failure result if player is null:
            Success: false
            Message: "Player is required"
            CardName: ""
            Amount: 0

        * Return failure result if request is null:
            Success: false
            Message: "Request is required"
            CardName: ""
            Amount: 0

        * Return failure result if request.PlayerName is null, empty, or whitespace:
            Success: false
            Message: "Player name is required"
            CardName: ""
            Amount: 0

        * Return failure result if request.PlayerName does not match player.Name:
            Success: false
            Message: "Player mismatch"
            CardName: request.CardName
            Amount: 0

        * Return failure result if request.CardName is null, empty, or whitespace:
            Success: false
            Message: "Card name is required"
            CardName: ""
            Amount: 0

        * After validation, reuse your existing method:

            BuyCardFromPlayerWithResult(player, request.CardName)

        * Do not duplicate all the sale logic again.
        * No LINQ.


        ============================================================
        OPTIONAL OOP STRETCH 7:
        BUILD REQUEST SUMMARY
        ============================================================

        Add this method to CardShop:

        public string BuildBuyRequestSummary(BuyCardRequest? request)

        Requirements:

        * Return "" if request is null.
        * Return a one-line summary using this exact format:

        "Player:V Card:Johnny Silverhand"

        * No LINQ.
    */
}
