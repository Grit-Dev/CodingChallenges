public class Program
{   

    public static void Main(string[] args)
    {
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();

        /*
            ============================================================
            LEARNING FOCUS:
            OPERATION RESULT OBJECTS
            ============================================================

            A bool tells you whether something worked:

            true
            false

            But real applications usually need more information:

            Was it successful?
            Why did it fail?
            What card was involved?
            How many credits changed?

            This is similar to API thinking.

            Example:

            Instead of only returning false, a method can return:

            Success: false
            Message: "Card not found"

            Later in APIs, this kind of thinking connects to:

            200 OK
            400 Bad Request
            404 Not Found


            ============================================================
            OOP CHALLENGE 4:
            CREATE CARDSHOPRESULT CLASS
            ============================================================

            Create a new class:

            public class CardShopResult

            Put it in Shared.

            Properties:

            public bool Success { get; set; }
            public string Message { get; set; }
            public string CardName { get; set; }
            public int Amount { get; set; }

            Requirements:

            * Message should default to string.Empty.
            * CardName should default to string.Empty.
            * Add a default constructor.
            * Add a constructor with all four values.

            Example:

            new CardShopResult(
                true,
                "Purchase successful",
                "Johnny Silverhand",
                400
            );


            ============================================================
            OOP CHALLENGE 5:
            BUY CARD WITH RESULT
            ============================================================

            Add this method to CardShop:

            public CardShopResult BuyCardWithResult(
                Player player,
                string cardName
            )

            Requirements:

            * If player is null, return:
                Success: false
                Message: "Player is required"
                CardName: ""
                Amount: 0

            * If cardName is null, empty, or whitespace, return:
                Success: false
                Message: "Card name is required"
                CardName: ""
                Amount: 0

            * If card is not found in Inventory, return:
                Success: false
                Message: "Card not found"
                CardName: cardName
                Amount: 0

            * If player cannot afford the card, return:
                Success: false
                Message: "Insufficient credits"
                CardName: found card name
                Amount: card price

            * If purchase succeeds:
                - add card to player's OwnedCards;
                - remove card from Inventory;
                - record a Purchase transaction;
                - return:
                    Success: true
                    Message: "Purchase successful"
                    CardName: purchased card name
                    Amount: card price

            * Do not record a transaction if the purchase fails.
            * No LINQ.


            ============================================================
            OOP CHALLENGE 6:
            SELL CARD WITH RESULT
            ============================================================

            Add this method to CardShop:

            public CardShopResult BuyCardFromPlayerWithResult(
                Player player,
                string cardName
            )

            This means:
            the shop buys a card from the player.

            Requirements:

            * If player is null, return:
                Success: false
                Message: "Player is required"
                CardName: ""
                Amount: 0

            * If cardName is null, empty, or whitespace, return:
                Success: false
                Message: "Card name is required"
                CardName: ""
                Amount: 0

            * Use player.RemoveCardByName(cardName).

            * If the player does not own the card, return:
                Success: false
                Message: "Player does not own card"
                CardName: cardName
                Amount: 0

            * If sale succeeds:
                - add card to shop Inventory;
                - give player half the card price as credits;
                - record a Sale transaction;
                - return:
                    Success: true
                    Message: "Sale successful"
                    CardName: sold card name
                    Amount: half the card price

            * Do not record a transaction if the sale fails.
            * No LINQ.


            ============================================================
            OOP CHALLENGE 7:
            GET LAST TRANSACTION
            ============================================================

            Add this method to CardShop:

            public ShopTransaction? GetLastTransaction()

            Requirements:

            * Return null if there are no transactions.
            * Return the last transaction in the Transactions list.
            * Do not remove anything.
            * Do not modify Transactions.
            * No LINQ.

            Example:

            Transactions:
            Purchase
            Sale
            Purchase

            Expected:
            the final Purchase transaction


            ============================================================
            OPTIONAL OOP STRETCH 8:
            BUILD RESULT SUMMARY
            ============================================================

            Add this method to CardShop:

            public string BuildResultSummary(CardShopResult result)

            Requirements:

            * Return "" if result is null.
            * Return a one-line summary using this exact format:

            "Success:true Message:Purchase successful Card:Johnny Silverhand Amount:400"

            * No LINQ.
        */

    }
}
