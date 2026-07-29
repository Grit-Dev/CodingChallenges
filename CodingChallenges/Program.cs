using System.Reflection.Metadata.Ecma335;
using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static void Main(string[] args)
    {   
        // CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();
    }
    /*


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
