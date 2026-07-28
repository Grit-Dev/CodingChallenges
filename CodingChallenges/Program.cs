using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static void Main(string[] args)
    {   
    
        CardShopResultRefactorChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();
    }

    /*
        ============================================================
        LEARNING FOCUS:
        REFACTORING RESULT METHODS
        ============================================================

        You now have methods that return CardShopResult.

        That is good because the caller gets more information than
        just true or false.

        But result methods can become repetitive.

        Today you will clean that up using private helper methods.

        The goal:

        * less duplicated result-building code
        * clearer success/failure paths
        * same behaviour as before
        * cleaner backend-style business logic


        ============================================================
        OOP CHALLENGE 3:
        ADD PRIVATE FAILURE RESULT HELPER
        ============================================================

        Add this private method to CardShop:

        private CardShopResult CreateFailureResult(
            string message,
            string cardName,
            int amount
        )

        Requirements:

        * Return a CardShopResult.
        * Success should always be false.
        * Message should use the supplied message.
        * CardName should use the supplied cardName.
        * Amount should use the supplied amount.

        Example:

        CreateFailureResult(
            "Card not found",
            "Unknown Card",
            0
        )

        Expected result:

        Success: false
        Message: "Card not found"
        CardName: "Unknown Card"
        Amount: 0


        ============================================================
        OOP CHALLENGE 4:
        ADD PRIVATE SUCCESS RESULT HELPER
        ============================================================

        Add this private method to CardShop:

        private CardShopResult CreateSuccessResult(
            string message,
            string cardName,
            int amount
        )

        Requirements:

        * Return a CardShopResult.
        * Success should always be true.
        * Message should use the supplied message.
        * CardName should use the supplied cardName.
        * Amount should use the supplied amount.


        ============================================================
        OOP CHALLENGE 5:
        ADD PRIVATE TRANSACTION HELPER
        ============================================================

        Add this private method to CardShop:

        private void RecordTransaction(
            Player player,
            Card card,
            string transactionType,
            int amount
        )

        Requirements:

        * Add a new ShopTransaction to Transactions.
        * Use player.Name.
        * Use card.Name.
        * Use the supplied transactionType.
        * Use the supplied amount.
        * This method should not return anything.
        * No LINQ.

        Example:

        RecordTransaction(
            player,
            johnny,
            "Purchase",
            400
        );


        ============================================================
        OOP CHALLENGE 6:
        REFACTOR BUYCARDWITHRESULT
        ============================================================

        Refactor this method:

        public CardShopResult BuyCardWithResult(
            Player player,
            string cardName
        )

        Requirements:

        * Keep the exact same behaviour as before.
        * Use CreateFailureResult for failed results.
        * Use CreateSuccessResult for successful results.
        * Use RecordTransaction when the purchase succeeds.
        * Do not record a transaction if the purchase fails.
        * No LINQ.

        Expected failure messages should stay:

        "Player is required"
        "Card name is required"
        "Card not found"
        "Insufficient credits"

        Expected success message should stay:

        "Purchase successful"


        ============================================================
        OOP CHALLENGE 7:
        REFACTOR BUYCARDFROMPLAYERWITHRESULT
        ============================================================

        Refactor this method:

        public CardShopResult BuyCardFromPlayerWithResult(
            Player player,
            string cardName
        )

        Requirements:

        * Keep the exact same behaviour as before.
        * Use CreateFailureResult for failed results.
        * Use CreateSuccessResult for successful results.
        * Use RecordTransaction when the sale succeeds.
        * Do not record a transaction if the sale fails.
        * No LINQ.

        Expected failure messages should stay:

        "Player is required"
        "Card name is required"
        "Player does not own card"

        Expected success message should stay:

        "Sale successful"


        ============================================================
        OPTIONAL OOP STRETCH 8:
        ADD HAS SUCCESSFUL TRANSACTIONS
        ============================================================

        Add this method to CardShop:

        public bool HasTransactions()

        Requirements:

        * Return true if Transactions has at least one item.
        * Return false if Transactions is empty.
        * No LINQ.
    */

}
