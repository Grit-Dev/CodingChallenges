public class Program
{
    public static List<int> FindIdsInBothLists(List<int> firstIds, List<int> secondIds)
    {
        if (firstIds is null || secondIds is null)
        {
            return [];
        }

        List<int> commonalityList = [];

        foreach (int outterValue in firstIds)
        {
            foreach (int innerValue in secondIds)
            {
                if (outterValue == innerValue)
                {
                    if (!commonalityList.Contains(outterValue))
                    {
                        commonalityList.Add(outterValue);
                    }
                }
            }
        }

        return commonalityList;
    }
    public static void Main(string[] args)
    {
        // FIND IDS IN BOTH LISTS
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([1, 2, 3], [2, 3, 4])) == "2, 3");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([5, 5, 6], [5, 7])) == "5");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([1, 2], [3, 4])) == "");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([], [1, 2])) == "");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([1, 2], [])) == "");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([1, 2, 3], [1, 2, 3])) == "1, 2, 3");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([5, 5, 5, 6, 6], [5, 6])) == "5, 6");
        Console.WriteLine(string.Join(", ", FindIdsInBothLists([10, 20, 30, 20], [20])) == "20");
        Console.WriteLine(FindIdsInBothLists(null!, [1, 2]).Count == 0);
        Console.WriteLine(FindIdsInBothLists([1, 2], null!).Count == 0);

        // CardShopRequestObjectCleanupChallenge.Run();
        // CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();


        /*
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
