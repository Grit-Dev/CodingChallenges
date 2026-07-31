public class Program
{
    public static void Main(string[] args)
    {
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
