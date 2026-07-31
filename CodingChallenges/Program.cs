using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   public static int? FindClosestAttackToTarget(int[] attacks, int target)
    {
        if(attacks is null || attacks.Length == 0)
        {
            return null;
        }

        int closestToTargetsoFar = attacks[0];
        int closestvalueFromArray = target;

        foreach(var value in attacks)
        {
            int rangeFromTarget = Math.Abs(target - value);

            if(rangeFromTarget < closestToTargetsoFar)
            {
                closestToTargetsoFar = rangeFromTarget;
                closestvalueFromArray = value;
            }
            else if(rangeFromTarget == closestToTargetsoFar && value > closestvalueFromArray)
            {
                closestvalueFromArray = value;
            }
        }

        return closestvalueFromArray;
    }

    public static int CountIdsAboveTarget(List<int> ids, int target)
    {
        if(ids is null)
        {
            return 0;
        }

        int counter = 0;

        foreach(int value in ids)
        {
            if(value > target)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {   
        // COUNT IDS ABOVE TARGET
        Console.WriteLine(CountIdsAboveTarget([1, 5, 10], 4)); // 2
        Console.WriteLine(CountIdsAboveTarget([3, 3, 3], 3)); // 0
        Console.WriteLine(CountIdsAboveTarget([10, 20, 30], 15)); // 2
        Console.WriteLine(CountIdsAboveTarget([], 0)); // 0
        
        // FIND CLOSEST ATTACK TO TARGET
        Console.WriteLine(FindClosestAttackToTarget([40, 60, 80], 65)); // 60
        Console.WriteLine(FindClosestAttackToTarget([50, 70], 60)); // 70
        Console.WriteLine(FindClosestAttackToTarget([10, 90, 100], 95)); // 100
        Console.WriteLine(FindClosestAttackToTarget([], 95)); // null

        // CardShopRequestObjectCleanupChallenge.Run();
        //CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();

        
    /*
        ============================================================
        CODING CHALLENGE 1:
        COUNT IDS ABOVE TARGET
        ============================================================

        Create this method:

        public static int CountIdsAboveTarget(
            List<int> ids,
            int target
        )

        Requirements:

        * Return 0 if ids is null.
        * Count how many IDs are greater than target.
        * No LINQ.

        Examples:

        [1, 5, 10], target 4 -> 2

        [3, 3, 3], target 3 -> 0

        [10, 20, 30], target 15 -> 2

        [] -> 0


        ============================================================
        CODING CHALLENGE 2:
        PARSE VALID CARD PRICES FROM CSV
        ============================================================

        Create this method:

        public static List<int> ParseValidCardPricesFromCsv(string input)

        Requirements:

        * Return an empty list if input is null, empty, or whitespace.
        * Values are separated by commas.
        * Trim spaces around each value.
        * Use int.TryParse.
        * Only prices greater than 0 are valid.
        * Ignore 0.
        * Ignore negative numbers.
        * Ignore invalid text.
        * Preserve original order.
        * No LINQ.

        Examples:

        "100, 200, 300" -> [100, 200, 300]

        "50, -10, hello, 400" -> [50, 400]

        "0, -1, abc" -> []

        " 25, 75 , test, 125 " -> [25, 75, 125]


        ============================================================
        CODING CHALLENGE 3:
        FIND IDS IN BOTH LISTS
        ============================================================

        Create this method:

        public static List<int> FindIdsInBothLists(
            List<int> firstIds,
            List<int> secondIds
        )

        Requirements:

        * Return an empty list if firstIds is null.
        * Return an empty list if secondIds is null.
        * Return IDs that appear in both lists.
        * Each matching ID should only appear once in the result.
        * Preserve the order from firstIds.
        * You may use List<int>.Contains.
        * No LINQ.
        * No Dictionary.
        * No HashSet.

        Examples:

        first: [1, 2, 3]
        second: [2, 3, 4]
        result: [2, 3]

        first: [5, 5, 6]
        second: [5, 7]
        result: [5]

        first: [1, 2]
        second: [3, 4]
        result: []

        first: []
        second: [1, 2]
        result: []


        ============================================================
        OOP CHALLENGE 4:
        FIX BUYCARDWITHREQUEST
        ============================================================

        Fix your existing method:

        public CardShopResult BuyCardWithRequest(
            Player? player,
            BuyCardRequest? request
        )

        Requirements:

        * Fix message casing.

          Correct message:

          "Player is required"

          Not:

          "player is Required"

        * Fix the player mismatch check.

          Wrong:

          request.PlayerName compared to request.PlayerName

          Correct:

          request.PlayerName compared to player.Name

        * Use StringComparison.OrdinalIgnoreCase.

        * After validation, reuse:

          BuyCardWithResult(player, request.CardName)

        * Do not duplicate the purchase logic again.


        ============================================================
        OOP CHALLENGE 5:
        ADD PRIVATE PLAYER MATCH HELPER
        ============================================================

        Add this private method to CardShop:

        private bool DoesPlayerMatchRequest(
            Player player,
            string playerName
        )

        Requirements:

        * Return false if player is null.
        * Return false if playerName is null, empty, or whitespace.
        * Return true if player.Name matches playerName.
        * Match should be case-insensitive.
        * Use StringComparison.OrdinalIgnoreCase.
        * No LINQ.

        Then use this helper inside:

        BuyCardWithRequest

        and:

        BuyCardFromPlayerWithRequest


        ============================================================
        OPTIONAL OOP STRETCH 6:
        BUILD SELL REQUEST SUMMARY
        ============================================================

        Add this method to CardShop:

        public string BuildSellRequestSummary(SellCardRequest? request)

        Requirements:

        * Return "" if request is null.
        * Return a one-line summary using this exact format:

          "Player:V Card:Johnny Silverhand"

        * No LINQ.
    */

    }

}
