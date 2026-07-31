using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static void Main(string[] args)
    {   
        CardShopRequestObjectCleanupChallenge.Run();
        //CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();

        
    /*
        ============================================================
        FRIDAY CHALLENGES
        PHASE 2: OOP / CLASSES / OBJECTS
        06_REQUEST OBJECTS CLEANUP
        ============================================================

        REQUIRED:
        3 coding challenges
        2 OOP challenges

        EXTRA:
        1 closest-target reinforcement drill

        OPTIONAL:
        1 OOP stretch


        ============================================================
        EXTRA CODING DRILL:
        FIND CLOSEST ATTACK TO TARGET
        ============================================================

        Create this method:

        public static int? FindClosestAttackToTarget(
            int[] attacks,
            int target
        )

        Requirements:

        * Return null if attacks is null.
        * Return null if attacks is empty.
        * Return the attack value closest to the target.
        * If two attack values are equally close, return the higher attack.
        * No LINQ.

        Examples:

        [40, 60, 80], target 65 -> 60

        [50, 70], target 60 -> 70

        [10, 90, 100], target 95 -> 100

        [88], target 70 -> 88

        [] -> null


        REQUIRED VARIABLE NAMES:

        int closestAttack
        int closestDistance
        int currentAttack
        int currentDistance


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
