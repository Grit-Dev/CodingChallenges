using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopRequestObjectCleanupChallenge
    {
        public static void Run()
        {
            // ============================================================
            // CHALLENGE 4
            // FIX BUYCARDWITHREQUEST
            // ============================================================

            CardShop buyShop = new();
            Player buyer = new("V", 1000);

            buyShop.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));

            CardShopResult buyResult1 = buyShop.BuyCardWithRequest(null, new BuyCardRequest());
            Console.WriteLine(buyResult1.Success == false);
            Console.WriteLine(buyResult1.Message == "Player is required");
            Console.WriteLine(buyResult1.CardName == "");
            Console.WriteLine(buyResult1.Amount == 0);

            CardShopResult buyResult2 = buyShop.BuyCardWithRequest(buyer, null);
            Console.WriteLine(buyResult2.Success == false);
            Console.WriteLine(buyResult2.Message == "Request is required");
            Console.WriteLine(buyResult2.CardName == "");
            Console.WriteLine(buyResult2.Amount == 0);

            CardShopResult buyResult3 = buyShop.BuyCardWithRequest(
                buyer,
                new BuyCardRequest("", "Johnny Silverhand"));

            Console.WriteLine(buyResult3.Success == false);
            Console.WriteLine(buyResult3.Message == "Player name is required");
            Console.WriteLine(buyResult3.CardName == "");
            Console.WriteLine(buyResult3.Amount == 0);

            CardShopResult buyResult4 = buyShop.BuyCardWithRequest(
                buyer,
                new BuyCardRequest("WrongPlayer", "Johnny Silverhand"));

            Console.WriteLine(buyResult4.Success == false);
            Console.WriteLine(buyResult4.Message == "Player mismatch");
            Console.WriteLine(buyResult4.CardName == "Johnny Silverhand");
            Console.WriteLine(buyResult4.Amount == 0);

            CardShopResult buyResult5 = buyShop.BuyCardWithRequest(
                buyer,
                new BuyCardRequest("V", ""));

            Console.WriteLine(buyResult5.Success == false);
            Console.WriteLine(buyResult5.Message == "Card name is required");
            Console.WriteLine(buyResult5.CardName == "");
            Console.WriteLine(buyResult5.Amount == 0);

            CardShopResult buyResult6 = buyShop.BuyCardWithRequest(
                buyer,
                new BuyCardRequest("v", "Johnny Silverhand"));

            Console.WriteLine(buyResult6.Success == true);
            Console.WriteLine(buyResult6.Message == "Purchase successful");
            Console.WriteLine(buyResult6.CardName == "Johnny Silverhand");
            Console.WriteLine(buyResult6.Amount == 400);


            // ============================================================
            // CHALLENGE 5
            // HELPER METHOD TESTS (INDIRECTLY TESTED)
            // ============================================================

            // Case-insensitive match
            CardShopResult helperResult1 = buyShop.BuyCardWithRequest(
                new Player("PAUL", 1000),
                new BuyCardRequest("paul", "Anything"));

            Console.WriteLine(helperResult1.Message != "Player mismatch");

            // Mismatch
            CardShopResult helperResult2 = buyShop.BuyCardWithRequest(
                new Player("Paul", 1000),
                new BuyCardRequest("Johnny", "Anything"));

            Console.WriteLine(helperResult2.Message == "Player mismatch");


            // ============================================================
            // BUYCARDFROMPLAYERWITHREQUEST
            // ============================================================

            CardShop sellShop = new();
            Player seller = new("Seller", 100);

            seller.AddCard(new Card("Judy Alvarez", "Rare", 80, 200));

            CardShopResult sellResult1 = sellShop.BuyCardFromPlayerWithRequest(
                null,
                new SellCardRequest());

            Console.WriteLine(sellResult1.Success == false);
            Console.WriteLine(sellResult1.Message == "Player is required");
            Console.WriteLine(sellResult1.CardName == "");
            Console.WriteLine(sellResult1.Amount == 0);

            CardShopResult sellResult2 = sellShop.BuyCardFromPlayerWithRequest(
                seller,
                null);

            Console.WriteLine(sellResult2.Success == false);
            Console.WriteLine(sellResult2.Message == "Request is required");
            Console.WriteLine(sellResult2.CardName == "");
            Console.WriteLine(sellResult2.Amount == 0);

            CardShopResult sellResult3 = sellShop.BuyCardFromPlayerWithRequest(
                seller,
                new SellCardRequest("", "Judy Alvarez"));

            Console.WriteLine(sellResult3.Success == false);
            Console.WriteLine(sellResult3.Message == "Player name is required");
            Console.WriteLine(sellResult3.CardName == "");
            Console.WriteLine(sellResult3.Amount == 0);

            CardShopResult sellResult4 = sellShop.BuyCardFromPlayerWithRequest(
                seller,
                new SellCardRequest("WrongSeller", "Judy Alvarez"));

            Console.WriteLine(sellResult4.Success == false);
            Console.WriteLine(sellResult4.Message == "Player mismatch");
            Console.WriteLine(sellResult4.CardName == "Judy Alvarez");
            Console.WriteLine(sellResult4.Amount == 0);

            CardShopResult sellResult5 = sellShop.BuyCardFromPlayerWithRequest(
                seller,
                new SellCardRequest("Seller", ""));

            Console.WriteLine(sellResult5.Success == false);
            Console.WriteLine(sellResult5.Message == "Card name is required");
            Console.WriteLine(sellResult5.CardName == "");
            Console.WriteLine(sellResult5.Amount == 0);

            CardShopResult sellResult6 = sellShop.BuyCardFromPlayerWithRequest(
                seller,
                new SellCardRequest("Seller", "Adam Smasher"));

            Console.WriteLine(sellResult6.Success == false);
            Console.WriteLine(sellResult6.Message == "Player does not own card");
            Console.WriteLine(sellResult6.CardName == "Adam Smasher");
            Console.WriteLine(sellResult6.Amount == 0);

            CardShopResult sellResult7 = sellShop.BuyCardFromPlayerWithRequest(
                seller,
                new SellCardRequest("seller", "Judy Alvarez"));

            Console.WriteLine(sellResult7.Success == true);
            Console.WriteLine(sellResult7.Message == "Sale successful");
            Console.WriteLine(sellResult7.CardName == "Judy Alvarez");
            Console.WriteLine(sellResult7.Amount == 100);


            // ============================================================
            // STRETCH 6
            // BUILDSELLREQUESTSUMMARY
            // ============================================================

            Console.WriteLine(
                sellShop.BuildSellRequestSummary(null) == "");

            Console.WriteLine(
                sellShop.BuildSellRequestSummary(
                    new SellCardRequest(
                        "V",
                        "Johnny Silverhand"))
                == "Player:V Card:Johnny Silverhand");
        }
    }
}