using System.Reflection.Metadata.Ecma335;
using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static int CountUniqueIds(List<int> ids)
    {
        if(ids is null)
        {
            return 0;
        }

        List<int> uniqueIdsList = [];

        foreach(int value in ids)
        {
            if(!uniqueIdsList.Contains(value))
            {
                uniqueIdsList.Add(value);
            }
        }

        return uniqueIdsList.Count;
    }
    public static void Main(string[] args)
    {   
        // COUNT UNIQUE IDS
        Console.WriteLine(CountUniqueIds([1, 2, 2, 3, 1])); // 3
        Console.WriteLine(CountUniqueIds([5, 5, 5])); // 1
        Console.WriteLine(CountUniqueIds([1, 2, 3])); // 3
        Console.WriteLine(CountUniqueIds([])); // 0
        Console.WriteLine(CountUniqueIds(null!)); //
        // CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();
    }
    /*
    ============================================================
    CODING CHALLENGE 1:
    COUNT UNIQUE IDS
    ============================================================

    Create this method:

    public static int CountUniqueIds(List<int> ids)

    Requirements:

    * Return 0 if ids is null.
    * Count how many unique IDs are in the list.
    * Preserve the idea that duplicates only count once.
    * You may use List<int>.Contains.
    * No LINQ.
    * No Dictionary.
    * No HashSet.

    Examples:

    [1, 2, 2, 3, 1] -> 3

    [5, 5, 5] -> 1

    [1, 2, 3] -> 3

    [] -> 0


    HINT:

    Create a new List<int> called seenIds.
    Loop through ids.
    If seenIds does not contain the current ID, add it.


    ============================================================
    CODING CHALLENGE 2:
    FIND CLOSEST SCORE TO TARGET
    ============================================================

    Create this method:

    public static int? FindClosestScoreToTarget(
        int[] scores,
        int target
    )

    Requirements:

    * Return null if scores is null.
    * Return null if scores is empty.
    * Return the score closest to the target.
    * If two scores are equally close, return the higher score.
    * No LINQ.

    Examples:

    [40, 60, 80], target 65 -> 60

    [50, 70], target 60 -> 70
    Explanation:
    50 is distance 10 from 60.
    70 is distance 10 from 60.
    Return the higher score.

    [10, 90, 100], target 95 -> 90

    [88], target 70 -> 88

    [] -> null


    HINT:

    Track four things:

    int closestScore
    int closestDistance
    int currentScore
    int currentDistance

    Start by assuming scores[0] is the closest.


    ============================================================
    CODING CHALLENGE 3:
    FIND DUPLICATE IDS
    ============================================================

    Create this method:

    public static List<int> FindDuplicateIds(List<int> ids)

    Requirements:

    * Return an empty list if ids is null.
    * Return IDs that appear more than once.
    * Each duplicate ID should only appear once in the result.
    * Preserve the order in which duplicates are first discovered.
    * You may use List<int>.Contains.
    * No LINQ.
    * No Dictionary.
    * No HashSet.

    Examples:

    [1, 2, 2, 3, 1] -> [2, 1]

    [5, 5, 5] -> [5]

    [1, 2, 3] -> []

    [4, 4, 2, 2, 4] -> [4, 2]


    HINT:

    Use two lists:

    seenIds
    duplicateIds

    If an ID has been seen before and is not already in duplicateIds,
    add it to duplicateIds.


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
